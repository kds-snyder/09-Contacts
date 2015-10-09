using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfContacts.Classes;

namespace WpfContacts
{
    /// <summary>
    /// Interaction logic for AuthenticateWindow.xaml
    /// </summary>
    public partial class AuthenticateWindow : Window
    {
        public const string placeholderPhoneNumber = 
            "Enter phone number, using only digits";

        public AuthenticateWindow()
        {
            InitializeComponent();
        }
          
         // Window loaded: insert phone number placeholder
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textBox_phoneNumber.Text = placeholderPhoneNumber;
            textBox_phoneNumber.Foreground = Brushes.Gray;
        }

         // User entered phone number: send SMS with verification code,
        //  and then show code controls and hide phone number submit button
        private void button_submitPhoneNumber_Click(object sender, RoutedEventArgs e)
        {

            // Display error message if nothing was entered or
            // phone number is not valid
            if (textBox_phoneNumber.Text == placeholderPhoneNumber)
            {
                ShowSmsError("Please enter a valid phone number");
                return;
            }
            if (!phoneNumberValid(textBox_phoneNumber.Text))
            {
                ShowSmsError("Please enter a valid phone number");               
                return;
            }

            //  Valid phone number: send SMS with new verification code
            if (SmsService.sendSms(textBox_phoneNumber.Text, 
                VerificationCodeService.GetNewVerificationCode()))
            {
                // SMS sent successfully: 
                // Set the window to get the verification code
                SetWindowToGetCode();
            }
            else
            // Display error message if SMS could not be sent
            {
                ShowSmsError
                  ("SMS could not be sent; please try a different phone number");              
                return;
            }            
        }

        // User entered verification code: 
        // If it matches, allow access to the contacts application
        // If it doesn't match, allow another attempt
        private void button_submitCode_Click(object sender, RoutedEventArgs e)
        {
            if (VerificationCodeService.VerificationCodeMatches(textBox_code.Text))
            {
                // Code matches:
                // Display success, load the contacts window, 
                //  and close this window
                MessageBox.Show("You have been authenticated");

                // Create main contacts window
                MainWindow contactsWindow = new MainWindow();
                contactsWindow.Show();
                this.Close();
               
            }
            // If code doesn't match, display message to that effect and
            //  set the window for getting a phone number
            else
            {
                MessageBox.Show("The verification code did not match");
                SetWindowToGetPhoneNumber();
            }
        }

        // User entered the phone number text box: 
        //  Remove placeholder if applicaable,
        //   and clear the SMS error message 
        private void textBox_phoneNumber_GotFocus(object sender, RoutedEventArgs e)
        {
            if (textBox_phoneNumber.Text == placeholderPhoneNumber)
            {
                textBox_phoneNumber.Text = "";
                textBox_phoneNumber.Foreground = Brushes.Black;
            }
            ClearSmsError();
        }

        // User left the phone number text box: 
        //  insert placeholder if text box is empty
        private void textBox_phoneNumber_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textBox_phoneNumber.Text == "")
            {
                textBox_phoneNumber.Text = placeholderPhoneNumber;
                textBox_phoneNumber.Foreground = Brushes.Gray;
            }
        }

        // Validate that input is phone number
        // Return true if valid, otherwise false
        // (if input is empty, return false)
        private bool phoneNumberValid (string input)
        {
            bool result = false;
            // Check that input is not empty and contains only digits
            if (input.Length != 0)
            {
                if (input.All(char.IsDigit))
                {
                    result = true;
                }
            }
            //MessageBox.Show("validation result: " + result);
            return result;
        }

        // Set window controls to get the verification code:
        //  Show the controls for the verification code,
        //  and hide the button to submit a phone number
        private void SetWindowToGetCode()
        {
            textBlock_codeSent.Visibility = Visibility.Visible;
            textBox_code.Visibility = Visibility.Visible;
            button_submitCode.Visibility = Visibility.Visible;
            button_submitPhoneNumber.Visibility = Visibility.Hidden;
            textBlock_smsError.Visibility = Visibility.Hidden;
        }

        // Set window controls to get the phone number:
        //  Hide the controls for the verification code,
        //  and show the button to submit a phone number
        private void SetWindowToGetPhoneNumber()
        {
            textBlock_codeSent.Visibility = Visibility.Hidden;
            textBox_code.Visibility = Visibility.Hidden;
            button_submitCode.Visibility = Visibility.Hidden;
            button_submitPhoneNumber.Visibility = Visibility.Visible;
            textBlock_smsError.Visibility = Visibility.Hidden;
        }

        // Display error message in textblock_smsError
        private void ShowSmsError (string message)
        {
            textBlock_smsError.Text = message;
            textBlock_smsError.Visibility = Visibility.Visible;
        }

        // Clear error message in textblock_smsError
        private void ClearSmsError()
        {
            textBlock_smsError.Text = "";
            textBlock_smsError.Visibility = Visibility.Hidden;           
        }
 
    }
}
