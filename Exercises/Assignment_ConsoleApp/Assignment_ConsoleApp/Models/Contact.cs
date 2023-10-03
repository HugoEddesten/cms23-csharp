using Assignment_ConsoleApp.Interfaces;

namespace Assignment_ConsoleApp.Models;

public class Contact : IContact
{
    public Guid Id { get; set; }
    public DateTime Created { get; set; } = DateTime.Now;
    public string FirstName { get; set; } = "Empty";
    public string LastName { get; set; } = "Empty";
    public string Email { get; set; } = "Empty";
    public string Phone { get; set; } = "Empty";
    public IAddress Address { get; set; } = null!;
}
