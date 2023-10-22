using Assignment_ConsoleApp.Interfaces;

namespace Assignment_ConsoleApp.Models;

public class Contact : IContact
{
    //public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime Created { get; set; } = DateTime.Now;
    public string FirstName { get; set; } = "Empty";
    public string LastName { get; set; } = "Empty";
    public string FullName => $"{FirstName} {LastName}";
    public string Email { get; set; } = "Empty";
    public string Phone { get; set; } = "Empty";
    public Address Address { get; set; } = null!;
}
