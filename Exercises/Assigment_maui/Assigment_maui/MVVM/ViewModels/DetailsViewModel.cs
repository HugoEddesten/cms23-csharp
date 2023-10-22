using Assigment_maui.MVVM.Views;
using Assigment_maui.Services;
using Assignment_maui.MVVM.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Assigment_maui.MVVM.ViewModels;

public partial class DetailsViewModel : ObservableObject, IQueryAttributable
{
// Fields
    private readonly ContactService _contactService;

    [ObservableProperty]
    private ContactModel contact = new();

// CONSTRUCTOR
    // Takes the ContactService object and syncs it with the json file
    public DetailsViewModel(ContactService contactService)
    {
        _contactService = contactService;
        UpdateContact();
    }

// METHODS
    // Takes a Dictionary as input, sets the contact property as the ContactModel object in the Dictionary
    // and calls the UpdateContact method
    void IQueryAttributable.ApplyQueryAttributes(IDictionary<string, object> query)
    {
        Contact = query["Contact"] as ContactModel;
        UpdateContact(); // Important when the user edits a contact and immediately goes back to the DetailsPage
    }

    // Removes the ContactModel object contact from the list _contacts and switches page to the previous.
    [RelayCommand]
    async Task OnRemoveButtonPressed() 
    {
        _contactService.RemoveContact(Contact);
        await Shell.Current.GoToAsync($"..");
    }

    // Syncs the contact property with the same contact in the _contacts list
    private void UpdateContact()
    {
        Contact = _contactService.GetContact(Contact.Id);
    }

    // Takes a ContactModel object as input, switches page to EditPage and takes with it a Dictionary containing the ContactModel.
    [RelayCommand]
    async Task GoToEdit(ContactModel contact)
    {
        var navigatorParameter = new Dictionary<string, object> 
        {
            {"Contact", contact}
        };
        await Shell.Current.GoToAsync(nameof(EditPage), navigatorParameter);
    }
}
