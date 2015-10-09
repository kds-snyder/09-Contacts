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
        public const string placeholderPhoneNumber = "Enter phone number";

        public AuthenticateWindow()
        {
            InitializeComponent();
        }        

        // User entered phone number: send SMS with verification code,
        //  and then show code controls and hide phone number submit button
        private void button_submitPhoneNumber_Click(object sender, RoutedEventArgs e)
        {
            // Display error message if phone number is not valid
            //  or SMS could not be sent
            if (!phoneNumberValid(textBox_phoneNumber.Text))
            {
                ShowSmsError("Please enter a valid phone number");               
                return;
            }
            if (SmsService.sendSms(textBox_phoneNumber.Text, 
                VerificationCodeService.GetNewVerificationCode()))
            {
                // SMS sent successfully: 
                // Set the window to get the verification code
                SetWindowToGetCode();
            }
            else
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
                // Display success, load the contacts, and close this window
                MessageBox.Show("You have been authenticated");
                var mainWindow = (MainWindow)Owner;                                
                mainWindow.LoadContacts();
                mainWindow.dataGrid_contacts.Items.Refresh();
                this.Close();
                mainWindow.Show();
            }
            // If it doesn't match, display message to that effect and
            //  set the window for getting a phone number
            else
            {
                MessageBox.Show("The verification code did not match");
                SetWindowToGetPhoneNumber();
            }
        }

        // Phone number changed: clear the SMS error message 
        private void textBox_phoneNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBlock_smsError.Text = "";
            textBlock_smsError.Visibility = Visibility.Hidden;
        }

        // User attempted to close window: shut down application
        private void Window_Closed(object sender, EventArgs e)
        {
            MessageBox.Show("Shutting down application");
            //Application.Current.Shutdown();
        }

        // Validate that input is phone number
        // Return true if valid, otherwise false
        // If input is empty, return false
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

    }
}
