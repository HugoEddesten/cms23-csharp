using Assignment_ConsoleApp.Interfaces;

namespace Assignment_ConsoleApp.Models;

public class Address : IAddress
{
    public string StreetName { get; set; }
    public string StreetNumber { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }
}
