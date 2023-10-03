using Assignment_ConsoleApp.Interfaces;
using Assignment_ConsoleApp.Models;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Assignment_ConsoleApp.Services;

internal class MenuService
{

    private readonly static IContactService contactService = new ContactService();

    public static bool AddContactMenu()
    {
        // Creates a Contact object
        IContact contact = new Contact();

        Console.Clear();

        Console.WriteLine("Add Contact|");
        Console.WriteLine("-----------+");
        Console.WriteLine("");

        Console.Write("First name: ");
        string firstName = Console.ReadLine() ?? "";
        contact.FirstName = firstName;

        Console.Write("Last name: ");
        string lastName = Console.ReadLine() ?? "";
        contact.LastName = lastName;

        Console.Write("Email: ");
        string email = Console.ReadLine() ?? "";
        contact.Email = email;

        Console.Write("Phone number: ");
        string phone = Console.ReadLine() ?? "";
        contact.Phone = phone;

        // Creates an Address object
        IAddress address = new Address();
        
        Console.Write("Streetname: ");
        string streetName = Console.ReadLine() ?? "";
        address.StreetName = streetName;

        Console.Write("Streetnumber: ");
        string streetNumber = Console.ReadLine() ?? "";
        address.StreetNumber = streetNumber;
        
        Console.Write("Postal Code: ");
        string postalCode = Console.ReadLine() ?? "";
        address.PostalCode = postalCode; 
        
        Console.Write("City: ");
        string city = Console.ReadLine() ?? "";
        address.City = city;
        
        // Inserts the Address object into the Address property of the Contact object
        contact.Address = address;

        // Adds the Contact object into the private list _contacts
        contactService.AddContact(contact);

        // Returns true for testing
        return true;
    }

    public static void RemoveContactMenu()
    {
        Console.Clear();
        Console.WriteLine("Remove Contact|");
        Console.WriteLine("--------------+");
        Console.WriteLine();

        List<IContact> contacts = new List<IContact>();
        contacts = contactService.GetAllContacts();

        int count = 0;
        foreach (IContact contact in contacts)
        {
            count++;
            Console.WriteLine($"{count}: {contact.FullName}");
        }
        Console.WriteLine();

        Console.WriteLine("Which contact do you want to remove? (This is permanent)");
        string choice = Console.ReadLine() ?? "";

        bool isParsable = UInt32.TryParse(choice, out UInt32 index);
        index -= 1;
        if (isParsable && index <= contacts.Count)
        {
            IContact contactToRemove = contactService.GetContact(index)!;
            contactService.RemoveContact(contactToRemove);
        }
        else
        {
            Console.WriteLine($"the input [{choice}] does not represent a contact");
        }
    }

    public static void ViewAllContactsMenu()
    {
        Console.Clear();
        Console.WriteLine("Your Contacts|");
        Console.WriteLine("-------------+");

        List<IContact> contacts = contactService.GetAllContacts();
        int count = 0;
        foreach (IContact contact in contacts)
        {
            count++;
            Console.WriteLine($"{count}: {contact.FullName} {contact.Phone}");
        }
        Console.WriteLine();

        Console.Write("Open contact: ");
        string choice = Console.ReadLine() ?? "";

        bool isParsable = UInt32.TryParse(choice, out UInt32 index);
        index -= 1;
        if (isParsable && index <= contacts.Count)
        {
            ViewOneContactMenu(index);
        }
        else
        {
            Console.WriteLine($"the input [{choice}] does not represent a contact");
        }
    }

    public static void ViewOneContactMenu(uint index)
    {
        Console.Clear();
        Console.WriteLine("Contact Viewer|");
        Console.WriteLine("--------------+");

        IContact contact = contactService.GetContact(index)!;
        Console.WriteLine($"Name: {contact.FullName}");
        Console.WriteLine($"Email: {contact.Email}");
        Console.WriteLine($"Phone: {contact.Phone}");
        Console.WriteLine($"Address: {contact.Address.FullAddress}");

        Console.WriteLine();
        Console.Write("Edit contact? y/n: ");
        string Choice = Console.ReadLine() ?? "";
        if (Choice == "y")
        {
            EditContactMenu(contact);
        }
    }
    
    public static void EditContactMenu(IContact contact)
    {
        Console.Clear();
        Console.WriteLine("Contact Editor|");
        Console.WriteLine("--------------+");

        Console.WriteLine($"1: {contact.FirstName}");
        Console.WriteLine($"2: {contact.LastName}");
        Console.WriteLine($"3: {contact.Email}");
        Console.WriteLine($"4: {contact.Phone}");
        Console.WriteLine($"5: {contact.Address.StreetName}");
        Console.WriteLine($"6: {contact.Address.StreetNumber}");
        Console.WriteLine($"7: {contact.Address.PostalCode}");
        Console.WriteLine($"8: {contact.Address.City}");

        Console.WriteLine();
        Console.WriteLine("Which attribute do you wish to edit? (leave empty to go back)");
        string choice = Console.ReadLine() ?? "";
        if (UInt32.TryParse(choice, out UInt32 propertyIndex))
        {
            EditPropertyMenu(contact, propertyIndex);
        } 
    }

    public static void EditPropertyMenu(IContact contact, uint propertyIndex)
    {
        Console.Clear();
        Console.WriteLine("Contact Editor|");
        Console.WriteLine("--------------+");
        switch (propertyIndex)
        {
            case 1:
                Console.Write("New first name: ");
                contact.FirstName = Console.ReadLine() ?? ""; ;
                break;
            case 2:
                Console.Write("New last name: ");
                contact.LastName = Console.ReadLine() ?? ""; ;
                break;
            case 3:
                Console.Write("New email: ");
                contact.Email = Console.ReadLine() ?? ""; ;
                break;
            case 4:
                Console.Write("New phone: ");
                contact.Phone = Console.ReadLine() ?? ""; ;
                break;
            case 5:
                Console.Write("New street name: ");
                contact.Address.StreetName = Console.ReadLine() ?? ""; ;
                break;
            case 6:
                Console.Write("New street number: ");
                contact.Address.StreetNumber = Console.ReadLine() ?? ""; ;
                break;
            case 7:
                Console.Write("New postal code: ");
                contact.Address.PostalCode = Console.ReadLine() ?? ""; ;
                break;
            case 8:
                Console.Write("New city/region: ");
                contact.Address.City = Console.ReadLine() ?? ""; ;
                break;
        }
        EditContactMenu(contact);
    }

    public static void MainMenu()
    {
        IContact contact = new Contact
        {
            FirstName = "Hugo",
            LastName = "Eddesten",
            Email = "hugo@domain.com",
            Phone = "0737627767",
            Address = new Address
            {
                StreetName = "Yttersta tvärgränd",
                StreetNumber = "3A",
                PostalCode = "118 23",
                City = "Stockholm"
            }
        };
        contactService.AddContact(contact);
        IContact contact2 = new Contact
        {
            FirstName = "Bengt",
            LastName = "Eddesten",
            Email = "hugo@domain.com",
            Phone = "0737627767",
            Address = new Address
            {
                StreetName = "Yttersta tvärgränd",
                StreetNumber = "3A",
                PostalCode = "118 23",
                City = "Stockholm"
            }
        };
        contactService.AddContact(contact2);

        bool isRunning = true;
        do
        {
            Console.Clear();
            Console.WriteLine("Contact List|");
            Console.WriteLine("------------+");

            Console.WriteLine("1: View contacts");
            Console.WriteLine("2: Add contact");
            Console.WriteLine("3: Remove Contact");
            Console.WriteLine("0: Exit");

            

            string choice = Console.ReadLine() ?? "";
            switch (choice)
            {
                case "1":
                    ViewAllContactsMenu();
                    break;
                case "2":
                    AddContactMenu();
                    break;
                case "3":
                    RemoveContactMenu();
                    break;
                case "0":
                    isRunning = false;
                    break;
            }
        }
        while (isRunning);
    }
}
