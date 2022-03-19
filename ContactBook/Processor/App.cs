using ContactBook.Classes;
using ContactBook.Models;
using static System.Console;

namespace ContactBook.Processor;

public static class App
{
    public static void Run()
    {

        Contacts contacts = new();
        WriteLine("Smart ContactBook!");

    programStart:
        Output.Greeting();
        var userInput = ReadLine();
        try
        {
            switch (userInput)
            {
                case "1":

                    Write("Contact Name: ");
                    var contactName = ReadLine();
                    if (contactName!.Length < 1) WriteLine("Contact Name Cannot be Empty.");

                    contactNumber:
                    Write("Contact Number: ");
                    var contactNumber = ReadLine();
                    var success = int.TryParse(contactNumber, out var number);
                    if (contactNumber is null || !success)
                    {
                        WriteLine("Contact Number Cannot be Zero nor Empty.");
                        goto contactNumber;
                    }

                    Contact? newContact = new(contactName!, number!);
                    contacts.Add(newContact);
                    break;

                case "2":
                    Write("Search by Number: ");
                    var searchNumber = int.Parse(ReadLine()!);
                    contacts.GetByNumber(searchNumber);

                    break;

                case "3":
                    contacts.GetAll();
                    break;

                case "4":
                    Write("Search by Name: ");
                    var searchByName = ReadLine()!.ToLower();
                    contacts.GetByName(searchByName);
                    break;
                case "x":
                    return;
                default:
                    WriteLine("Select a Valid Operation");
                    goto programStart;
            }

            Write("Select Operation Again (Y/n) ? - ");
            var opinion = ReadLine();
            if (opinion!.ToLower().Contains('y'))
            {
                goto programStart;
            }
        }
        catch (Exception e)
        {
            WriteLine(e.Message);
            goto programStart;
        }
    }
}