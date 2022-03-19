using ContactBook.Contracts;
using ContactBook.Models;

namespace ContactBook.Classes;
public class Contacts : IContactOperations
{
    private static readonly List<Contact> ContactList = new();

    public void Add(Contact contact)
    {
        ContactList.Add(contact);
    }

    public void GetByNumber(int number)
    {
        var contact = ContactList.FirstOrDefault(c => c.Number == number);
        if (contact is null) Console.WriteLine("Contact Number Not Found! \n");
        else PrintDetail(contact);
    }

    public void GetAll()
    {
        foreach (var contact in ContactList) Console.WriteLine($"Name : {contact.Name} Contact No : {contact.Number}");
    }

    public void GetByName(string name)
    {
        var searchName = ContactList.Where(c => c.Name.ToLower().Contains(name)).ToList();
        if (searchName.Count < 1) Console.WriteLine("Contact Not Found! \n");
        else GetDetails(searchName);
    }

    private static void PrintDetail(Contact contact)
    {
        //string isFav = (contact.IsFavourite) ? "Contact Is Favourite!" : "Contact Is Not Favourite"; 
        Console.WriteLine($"Contact: {contact.Name} - {contact.Number} \n");
    }

    private static void GetDetails(List<Contact> contacts)
    {
        foreach (var contact in contacts) PrintDetail(contact);
    }
}