using Assignment_maui.MVVM.Models;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Assigment_maui.Services;

public class ContactService
{
// Fields
    private List<ContactModel> _contacts = new List<ContactModel>();
    public event Action ContactsUpdated;


// Contsructor 
    // Calls the GetAllContacts method to sync _contacts with the json file
    public ContactService()
    {
        GetAllContacts();    
    }

// Methods
    // Takes a ContactModel object as input, adds it to the _contacts list, saves the change and calls that the list has beed updated
    public void AddContact(ContactModel contact)
    {
        _contacts.Add(contact);
        FileService.SaveToFile(JsonConvert.SerializeObject(_contacts));
        ContactsUpdated.Invoke();
    }

    // Takes a ContactModel object as input, removes it from the _contacts list, saves the change and calls that the list has been updated 
    public void RemoveContact(ContactModel contact)
    {
        _contacts.Remove(contact);
        FileService.SaveToFile(JsonConvert.SerializeObject(_contacts));
        ContactsUpdated.Invoke();
    }

    // Saves all contacts to the savefile and updates the _contacts list by invoking ContactsUpdated
    public void UpdateContacts()
    {
        try
        {
            FileService.SaveToFile(JsonConvert.SerializeObject(_contacts));
            ContactsUpdated.Invoke();
        } catch (Exception ex) { Debug.WriteLine(ex); }
    }

    // Takes a Guid as input, finds and returns the contact in the list with the same Guid
    public ContactModel GetContact(Guid id)
    {
        try
        {
            var _contact = _contacts.FirstOrDefault(x => x.Id == id);
            {
                if (_contact != null)
                    return _contact;
            }
        }
        catch (Exception ex) { Debug.WriteLine(ex); }

        return null!;
    }

    // Takes the contents of the json file, syncs the _contacts list with them and returns the new _contacts list as an IEnumerable
    public IEnumerable<ContactModel> GetAllContacts()
    {
        try
        {
            string contentAsJson = FileService.ReadFromFile();
            if (contentAsJson != "")
                _contacts = JsonConvert.DeserializeObject<List<ContactModel>>(contentAsJson)!;
        }
        catch (Exception ex) { Debug.WriteLine(ex); }

        return _contacts;
    }
}
