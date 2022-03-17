using ContactBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook.Classes
{
    public interface IContactOperations
    {
        public void AddContact(Contact contact);
        public void DisplayContact(string contactNo);
        public void DisplayAllContact();
        public void SearchByName(string name);
    }
}
