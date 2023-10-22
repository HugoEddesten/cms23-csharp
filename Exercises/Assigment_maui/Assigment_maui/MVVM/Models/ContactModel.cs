namespace Assignment_maui.MVVM.Models;

public class ContactModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime Created { get; set; } = DateTime.Now; // Never gets used but i'll keep it here for later
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string FullName => $"{FirstName} {LastName}";
    public string Email { get; set; } = "Email address";
    public string Phone { get; set; } = "Phone number";
    public AddressModel Address { get; set; } = new AddressModel();


}
