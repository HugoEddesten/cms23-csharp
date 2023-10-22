using Assignment_ConsoleApp.Interfaces;
using Assignment_ConsoleApp.Models;
using Newtonsoft.Json;
using System;

namespace Assignment_ConsoleApp.Services;

internal class ContactService : IContactService
{
    private List<IContact> _contacts = new List<IContact>();


    public void AddContact(IContact contact)
    {
        _contacts.Add(contact);
        string contentAsJson = JsonConvert.SerializeObject(_contacts);
        FileService.SaveToFile(contentAsJson);
    }
    public void RemoveContact(IContact contact)
    {
        _contacts.Remove(contact);
        string contentAsJson = JsonConvert.SerializeObject(_contacts);
        FileService.SaveToFile(contentAsJson);
    }
    public IContact GetContact(uint index)
    {
        try
        {
            for (int i = 0; i < _contacts.Count; i++)
            {
                if (i == index)
                    return _contacts[i];
            }
        }
        catch (Exception) { }

        return null!;
        // return _contacts.FirstOrDefault(x => x == index)!;
    }
    
    public List<IContact> GetAllContacts() 
    {
        try
        {
            string contentAsJson = FileService.ReadFromFile();
            List<Contact> contactsAsClass = JsonConvert.DeserializeObject<List<Contact>>(contentAsJson)!;
            _contacts = contactsAsClass.Cast<IContact>().ToList();

            return _contacts;
        }
        catch (Exception) { return _contacts; }
    }

}
