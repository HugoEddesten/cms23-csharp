namespace Assignment_ConsoleApp.Interfaces
{
    public interface IContact
    {
        IAddress Address { get; set; }
        string Email { get; set; }
        string FirstName { get; set; }
        Guid Id { get; set; }
        string LastName { get; set; }
        string Phone { get; set; }
    }
}