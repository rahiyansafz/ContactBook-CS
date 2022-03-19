using System.ComponentModel.DataAnnotations;
using ContactBook.Contracts;

namespace ContactBook.Models;

public class Contact : IContact
{
    public Contact(string name, int number)
    {
        Name = name;
        Number = number;
    }

    [StringLength(10, ErrorMessage = "Name is too big!!!")]
    public string Name { get; set; }

    [Required] public int Number { get; set; }
    //public bool IsFavourite { get; set; }
}