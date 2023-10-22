using Assigment_maui.Services;
using Assignment_maui.MVVM.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Assigment_maui.MVVM.ViewModels;

public partial class AddViewModel : ObservableObject
{
// Fields
    [ObservableProperty]
    ContactModel contact = new();

    private readonly ContactService _contactService;

// CONSTRUCTOR
    // Takes the ContactService object and copys it onto the page's _contactService
    public AddViewModel(ContactService contactService)
    {
        _contactService = contactService;
    }

    // Adds the contact the user has created and resets the contact property to an empty ContactModel for the next time the user wants to create a contact. Then it switches page to the previous one
    [RelayCommand]
    async Task SaveContact()
    {
        _contactService.AddContact(Contact);
        Contact = new ContactModel();
        
        await Shell.Current.GoToAsync($"..");
    }

}
