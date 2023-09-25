using Assignment_ConsoleApp.Interfaces;

namespace Assignment_ConsoleApp.Models;

public class Contact : IContact
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public IAddress Address { get; set; }
}
