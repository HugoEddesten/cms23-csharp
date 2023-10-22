using Assignment_ConsoleApp.Interfaces;

namespace Assignment_ConsoleApp.Models;

public class Address //: IAddress
{
    public string StreetName { get; set; } = "Empty";
    public string StreetNumber { get; set; } = "Empty";
    public string PostalCode { get; set; } = "Empty";
    public string City { get; set; } = "Empty";

    public string FullAddress => $"{StreetName} {StreetNumber}, {PostalCode} {City}";
}
