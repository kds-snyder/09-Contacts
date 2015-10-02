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
    /// Interaction logic for EditContactWindow.xaml
    /// </summary>
    public partial class EditContactWindow : Window
    {

        public EditContactWindow()
        {
            InitializeComponent();
        }

        // Initialize contact entry: set contact Id to null value
        public void InitContractEntry()
        {
            label_Id.Content = ID.NullId;
        }
        
        // Display input contact entry
        public void DisplayContactEntry (ContactEntry contact)
        {
            textBox_firstName.Text = contact.FirstName;
            textBox_lastName.Text = contact.LastName;
            textBox_emailAddress.Text = contact.EmailAddress;
            textBox_telephoneNumber.Text = contact.TelephoneNumber;
            textBox_Address1.Text = contact.AddressLine1;
            textBox_Address2.Text = contact.AddressLine2;
            textBox_city.Text = contact.City;
            textBox_state.Text = contact.State;
            textBox_zipCode.Text = contact.ZipCode;
            label_Id.Content = contact.Id;
        }

        // Save button clicked: save contact and close window
        private void button_save_Click(object sender, RoutedEventArgs e)
        {
            // If contact ID is null, add new contact  
            //  otherwise update contact

            int contactID = (int)label_Id.Content;
            if (contactID == ID.NullId)
            {
                addNewContact();
            } 
            else
            {
                updateContact();
            }

            // Close the window
            this.Close();
        }

        // Quit button clicked: close window
        private void button_quit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Add new contact from window data
        private void addNewContact()
        {
            // Create a new contact with all the data from the window
            ContactEntry newContact = new ContactEntry();
            copyContactData(newContact);
            
            // Get a new ID for the contact
            newContact.Id = ID.getNewId();

            // Add the new contact
            ContactService.AddContact(newContact);
        }

        // Update existing contact
        private void updateContact()
        {
            // Get the contact corresponding to the contact ID
            ContactEntry EditedContact =
                ContactService.GetContactById((int)label_Id.Content);

            // Copy window data to contact
            copyContactData(EditedContact);

            // Refresh the data grid in the main window
            var mainWindow = (MainWindow)Owner;
            mainWindow.dataGrid_contacts.Items.Refresh();
        }

        // Copy contact data from window to contact object
        private void copyContactData (ContactEntry contact)
        {
            contact.FirstName = textBox_firstName.Text;
            contact.LastName = textBox_lastName.Text;
            contact.EmailAddress = textBox_emailAddress.Text;
            contact.TelephoneNumber = textBox_telephoneNumber.Text;
            contact.AddressLine1 = textBox_Address1.Text;
            contact.AddressLine2 = textBox_Address2.Text;
            contact.City = textBox_city.Text;
            contact.State = textBox_state.Text;
            contact.ZipCode = textBox_zipCode.Text;
            contact.Id = (int)label_Id.Content;
        }

    }
}
