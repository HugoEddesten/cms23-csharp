namespace Assignment_maui.MVVM.Models;

public class AddressModel
{
    public string StreetName { get; set; } = "Street";
    public string StreetNumber { get; set; } = "XX";
    public string PostalCode { get; set; } = "Postal code";
    public string City { get; set; } = "City/Region";

    public string FullAddress => $"{StreetName} {StreetNumber}, {PostalCode}, {City}";
}
