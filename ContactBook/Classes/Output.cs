namespace ContactBook.Classes;

public class Output
{
    public static void Greeting()
    {
        Console.WriteLine("Select Operation: \n");
        Console.WriteLine("1. Add Contact");
        Console.WriteLine("2. Search Contact by Number");
        Console.WriteLine("3. View All Contacts");
        Console.WriteLine("4. Search Contact by a Given Name");
        Console.WriteLine("x. Exit \n");
    }
}