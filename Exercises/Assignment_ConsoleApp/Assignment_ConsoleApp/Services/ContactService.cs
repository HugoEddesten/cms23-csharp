using Assignment_ConsoleApp.Interfaces;
using Assignment_ConsoleApp.Models;

namespace Assignment_ConsoleApp.Services;

internal class ContactService : IContactService
{
    private List<IContact> _contacts = new List<IContact>();

    public void AddContact(IContact contact)
    {
        _contacts.Add(contact);
    }
    public void RemoveContact(IContact contact)
    {
        _contacts.Remove(contact);
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
            return _contacts;
        }
        catch (Exception) { }
        return null!;
    }

}
