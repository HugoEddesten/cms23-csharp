using Assigment_maui.Services;
using Assigment_maui.MVVM.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using Assignment_maui.MVVM.Models;


namespace Assigment_maui.MVVM.ViewModels;

public partial class MainViewModel : ObservableObject
{

// Fields

    private readonly ContactService _contactService;

    [ObservableProperty]
    private ObservableCollection<ContactModel> contacts = new();
    
// CONSTRUCTOR

    // Takes the ContactService object and syncs it with the json file
    public MainViewModel(ContactService contactService)
    {
        _contactService = contactService;
        GetContacts();

        // Runs when ContactsUpdated has been invoked. Resyncs the ObservableCollection contacts with the json file
        _contactService.ContactsUpdated += () =>
        {
            GetContacts();
        };
    }

// METHODS

    // Clears all contacts from the ObservableCollection and resyncs it with the json file if GetAllContacts does not return null
    private void GetContacts()
    {
        Contacts.Clear();
        if (_contactService.GetAllContacts() != null)
        {
            foreach (ContactModel contact in _contactService.GetAllContacts())
            {
                Contacts.Add(contact);
            }
        }
    }

    // Takes a ContactModel object as input and switches page to DetailsPage and takes with it a Dictionary containing the ContactModel.
    [RelayCommand]
    async Task GoToDetails(ContactModel contact)
    {
        var navigationParameter = new Dictionary<string, object>
        {
            {"Contact", contact}
        };
        await Shell.Current.GoToAsync(nameof(DetailsPage), navigationParameter);
    }

    // Switches page to AddPage 
    [RelayCommand]
    async Task GoToAdd()
    {
        await Shell.Current.GoToAsync(nameof(AddPage));
    }

    // Switches page to FavouritesPage
    [RelayCommand]
    async Task GoToFavourites()
    {
        await Shell.Current.GoToAsync(nameof(FavouritesPage));
    }
  

   
}
