using ContactBook.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook.Models
{
    public class Contact : IContact
    {
        public Contact(string name, string number)
        {
            Name = name;
            Number = number;
        }

        [StringLength(10, ErrorMessage = "Name is too big!!!")]
        public string Name { get; set; } = null!;
        [Required]
        public string Number { get; set; }
        public bool IsFavourite { get; set; }
    }
}
