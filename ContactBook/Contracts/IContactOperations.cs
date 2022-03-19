using ContactBook.Models;

namespace ContactBook.Contracts;

public interface IContactOperations
{
    void Add(Contact contact);
    void GetByNumber(int number);
    void GetAll();
    void GetByName(string name);
}