using ContactBook.Classes;
using ContactBook.Models;

Console.WriteLine("Smart Contact Book! \n");

Output.Greeting();

var userInput = Console.ReadLine();

var contacts = new Contacts();

while (true)
{
    switch (userInput)
    {
        case "1":
            Console.WriteLine("Contact Name: ");
            var cName = Console.ReadLine();
            Console.WriteLine("Contact Number: ");
            var cNumber = Console.ReadLine();

            if (cName is null) Console.WriteLine("Contact Name Cannot be Empty \n");
            if (cNumber is null) Console.WriteLine("Contact Number Cannot be Empty \n");

            Contact? newContact = new(cName!, cNumber!);
            contacts.AddContact(newContact);
            break;

        case "2":
            Console.WriteLine("Search number: \n");
            var searchNumber = Console.ReadLine()!.ToLower();
            contacts.DisplayContact(searchNumber);

            break;

        case "3":
            contacts.DisplayAllContact();
            break;

        case "4":
            Console.WriteLine("Search by Name: \n");
            var searchByName = Console.ReadLine()!.ToLower();
            contacts.SearchByName(searchByName);

            break;
        case "x":
            return;
        default:
            Console.WriteLine("Select a Valid Operation \n");
            break;
    }
    Output.Greeting();
    Console.WriteLine("Select Operation Again? \n");
    userInput = Console.ReadLine();
}

