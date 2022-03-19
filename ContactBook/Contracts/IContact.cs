namespace ContactBook.Contracts;

public interface IContact
{
    public string Name { get; set; }

    public int Number { get; set; }
    //public bool IsFavourite { get; set; }
}