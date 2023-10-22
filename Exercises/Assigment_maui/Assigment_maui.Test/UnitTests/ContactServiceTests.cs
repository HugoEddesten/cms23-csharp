using Assigment_maui.MVVM.ViewModels;
using Assigment_maui.Services;
using Assignment_maui.MVVM.Models;

namespace Assigment_maui.Test.UnitTests;

public class ContactServiceTests
{
    
    // This test might not be a unit test. So i made another test as well.
    [Fact]
    public void GetContact_Should_ReturnContactWithTheSameId()
    {
        // Arrange
        ContactService contactService = new ContactService();
        MainViewModel mainViewModel = new(contactService);

        ContactModel contact = new ContactModel
        {
            FirstName = "TestFirstName",
            LastName = "TestLastName",
            Email = "TestEmail",
            Phone = "TestPhone",
            Address = new AddressModel
            {
                StreetName = "TestStreetName",
                StreetNumber = "TestStreetNumber",
                PostalCode = "TestPostalCode",
                City = "TestCity"
            }
        };
        contactService.AddContact(contact);

        // Act
        ContactModel returnedContact = contactService.GetContact(contact.Id);

        // Assert
        Assert.Equal(contact.Id, returnedContact.Id);
    }
}
