using Assignment_ConsoleApp.Models;

namespace Assignment_ConsoleApp.Interfaces
{
    internal interface IContactService
    {
        void AddContact(IContact contact);
        void RemoveContact(IContact contact);
        IContact? GetContact(uint index);
        List<IContact> GetAllContacts();
    }
}