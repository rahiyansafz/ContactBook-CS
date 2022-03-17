using ContactBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook.Classes
{
    public class Contacts : IContactOperations
    {
        private List<Contact> ContactList { get; set; } = new();
        private static void GetAllItems(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name} - {contact.Number} \n");
        }

        private static void GetDetails(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                GetAllItems(contact);
            }
        }

        public void AddContact(Contact contact)
        {
            ContactList.Add(contact);
        }

        public void DisplayContact(string contactNo)
        {
            var contact = ContactList.FirstOrDefault(c => c.Number == contactNo);
            if (contact is null) Console.WriteLine("Contact Number Not Found! \n");
            else GetAllItems(contact);
        }

        public void DisplayAllContact()
        {
            GetDetails(ContactList);
        }

        public void SearchByName(string name)
        {
            var searchName = ContactList.Where(c => c.Name.Contains(name)).ToList();
            GetDetails(searchName);
        }
    }
}
