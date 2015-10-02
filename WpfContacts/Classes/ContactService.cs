using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using System.IO;

namespace WpfContacts.Classes
{
    // Service class for list of contacts
    public class ContactService
    {
        // List of contacts, stored as observable collection
        public static ObservableCollection<ContactEntry> ContactList
                                = new ObservableCollection<ContactEntry>();

        // Method to return contact entry according to input contact ID
        // Returns null if contact with that ID does not exist
        public static ContactEntry GetContactById(int id)
        {
           try
            {
                return ContactList.Single(i => i.Id == id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Method to return index of contact entry according to input contact ID
        // Returns null if contact with that ID does not exist
        public static int? GetIndexById(int id)
        {
            try
            {
                return ContactList.IndexOf
                    (ContactList.Single(i => i.Id == id));
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Method to add contract entry to the list
        // Input is the contact to add
        public static void AddContact(ContactEntry contact)
        {
            ContactList.Add(contact);
        }

        // Method to delete contact corresponding to input contact ID
        public static void DeleteContact (int id)
        {
            int? contactIndex = GetIndexById(id);
            if (contactIndex != null)
            {
                ContactList.RemoveAt((int)contactIndex);
            }            
        }

        // Method to read contacts from file
        public static void ReadFromFile(string fileName)
        {
            string json = File.ReadAllText(fileName);
            ContactList =
              JsonConvert.DeserializeObject<ObservableCollection<ContactEntry>>(json);
        }

        // Method to save contacts to file
        public static void SaveToFile (string fileName)
        {
            string json =
                 JsonConvert.SerializeObject(ContactList);
            File.WriteAllText(fileName, json);
        }

    }
}
