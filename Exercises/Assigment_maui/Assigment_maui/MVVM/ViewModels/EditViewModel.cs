
using Assigment_maui.MVVM.Views;
using Assignment_maui.MVVM.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Assigment_maui.Services;
using System.Collections.ObjectModel;


namespace Assigment_maui.MVVM.ViewModels
{
    public partial class EditViewModel : ObservableObject, IQueryAttributable
    {
    // Properties 
        [ObservableProperty]
        private ContactModel contact = new();

        private readonly ContactService _contactService;


    // Constructor
        // Takes the ContactService object and copys it onto the page's _contactService
        public EditViewModel(ContactService contactService)
        {
            _contactService = contactService;
        }
      
        
    // Methods
        // Saves the user chosen ContactModel object to the property contact
        void IQueryAttributable.ApplyQueryAttributes(IDictionary<string, object> query)
        {
            Contact = query["Contact"] as ContactModel;
            // Does not need a ContactUpdate because of how the project is structured
        }

        // Saves the changes that the user made to the contact and switches page to the previous one
        [RelayCommand]
        async Task SaveContact()
        {
            _contactService.UpdateContacts();
            await Shell.Current.GoToAsync($"..");
        }
    }
}
