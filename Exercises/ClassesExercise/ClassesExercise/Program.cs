using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Net.Security;
using System.Runtime.InteropServices;
using ClassesExercise.Models;

namespace ClassesExercise
{

    internal class Program
    {



        static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>();
            Contact testObject = new();
            testObject.FirstName = "Hugo";
            testObject.LastName = "Eddesten";
            testObject.Address = "Yttersta tvärgränd 3a";
            testObject.Email = "hugo.eddesten1@gmail.com";
            testObject.PhoneNumber = "0737627767";
            contacts.Add(testObject);

            Contact testObject2 = new();
            testObject2.FirstName = "Bengt";
            testObject2.LastName = "Lundgren";
            testObject2.Address = "Smetgatan 5";
            testObject2.Email = "bengt.lundgren1@gmail.com";
            testObject2.PhoneNumber = "0737516336";
            contacts.Add(testObject2);



            string answer = "";
            do
            {
                Console.Clear();

                // Resets the redo-check
                answer = "";
                
                // Displays menu
                Console.WriteLine("Your contact list:");

                Console.WriteLine("1: Display contacts");
                Console.WriteLine("2: Edit contact list");
                Console.WriteLine("0: Exit");
                answer = Console.ReadLine() ?? "";

                switch (answer)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Your contacts:");
                        bool back = false;
                        while (back == false)
                        {
                            // Loops through the list contacts and displays each contact by name
                            for (int i = 0; i < contacts.Count; i++)
                                Console.WriteLine($"{i + 1}:    {contacts[i].FirstName} {contacts[i].LastName}");

                            Console.WriteLine("");
                            Console.WriteLine("Which contact do you wish to open?");


                            // Reads user input and tries to make it into an int
                            string stringtoBeOpened = Console.ReadLine() ?? "";
                            bool intCheck = int.TryParse(stringtoBeOpened, out int toBeOpened);

                            // Checks if user input is a number and if the input is positive and if its less than or equal to the length of the contacts list
                            if (intCheck && toBeOpened - 1 >= 0 && toBeOpened <= contacts.Count)
                            {
                                toBeOpened--;

                                // Displays the contacts
                                DisplayContact(contacts[toBeOpened]);
                            }
                            else
                            {
                                break;
                            }

                            Console.WriteLine("\nDo you wish to edit this contact? y/n");
                            string editContact = Console.ReadLine() ?? "";
                            if (editContact == "y")
                            {
                                DisplayContact(contacts[toBeOpened], true);

                                Console.WriteLine("Which property do you wish to edit?");
                                string whichProperty = Console.ReadLine() ?? "";
                                switch (whichProperty)
                                {
                                    case "1":
                                        Console.Write("New first name: ");
                                        contacts[toBeOpened].FirstName = Console.ReadLine() ?? "!";
                                        break;
                                    case "2":
                                        Console.Write("New last name: ");
                                        contacts[toBeOpened].LastName = Console.ReadLine() ?? "!";
                                        break;
                                    case "3":
                                        Console.Write("New adress: ");
                                        contacts[toBeOpened].Address = Console.ReadLine() ?? "!";
                                        break;
                                    case "4":
                                        Console.Write("New email: ");
                                        contacts[toBeOpened].Email = Console.ReadLine() ?? "!";
                                        break;
                                    case "5":
                                        Console.Write("New phone number: ");
                                        contacts[toBeOpened].PhoneNumber = Console.ReadLine() ?? "!";
                                        break;
                                    default:
                                        break;
                                }
                            }
                            // After the contact has been edited or user didnt want to
                            Console.ReadLine();
                            break;
                        }
                        // If while condition is not met
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Edit contact list: ");
                        Console.WriteLine("1: Add contact");
                        Console.WriteLine("2: Remove contact");
                        string editScreenChoice = Console.ReadLine() ?? "";

                        switch (editScreenChoice)
                        {
                            case "1":
                                Console.Clear();
                                Console.WriteLine("New contact: ");
                                AddContact(contacts);


                                break;
                            case "2":
                                Console.Clear();
                                Console.WriteLine("Your contacts:");
                                for (int i = 0; i < contacts.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}    {contacts[i].FirstName} {contacts[i].LastName}");
                                }
                                Console.WriteLine("Which contact do you wish to delete (This is permanent)");

                                // Reads which contact the user wishes to delete
                                string deleteChoice = Console.ReadLine() ?? "";
                                bool intCheck = int.TryParse(deleteChoice, out int toBeOpened);

                                // If its an int and no less than 0 and no more than the length of the list.
                                if(intCheck && toBeOpened - 1 >= 0 && toBeOpened <= contacts.Count)
                                    contacts.Remove(contacts[toBeOpened-1]);

                                break;
                            default:
                                break;
                        }
                        break;

                    default:

                        break;

                }
                
            } while (answer != "0");
            

            //WriteContacts(contacts);

        }

        public static void RemoveContact(List<Contact> contacts, Contact contact)
        {
            contacts.Remove(contact);
        }



        public static void AddContact(List<Contact> contacts)
        {
            // Creates object
            Contact contact = new();

            // Assigns the property values
            Console.WriteLine("First Name:");
            contact.FirstName = Console.ReadLine() ?? "";

            Console.WriteLine("Last Name:");
            contact.LastName = Console.ReadLine() ?? "";

            Console.WriteLine("Address:");
            contact.Address = Console.ReadLine() ?? "";

            Console.WriteLine("Email:");
            contact.Email = Console.ReadLine() ?? "";

            Console.WriteLine("Phone number:");
            contact.PhoneNumber = Console.ReadLine() ?? "";

            // Adds new contact to list
            contacts.Add(contact);


        }

        public static void WriteContacts(List<Contact> contacts) 
        {
            // Writes the properties of the contacts in the list
            Console.Clear();
            foreach (Contact contact in contacts)
                Console.WriteLine($"{contact.FirstName} {contact.LastName} \n{contact.Address} \n<{contact.Email}> {contact.PhoneNumber}\n");
            Console.WriteLine("");
        }

        public static void DisplayContact(Contact contact, bool isEnumerated = false)
        {
            if (isEnumerated == true)
            {
                Console.Clear();
                Console.WriteLine($"1: {contact.FirstName}");
                Console.WriteLine($"2: {contact.LastName}");
                Console.WriteLine($"3: {contact.Address}");
                Console.WriteLine($"4: {contact.Email}");
                Console.WriteLine($"5: {contact.PhoneNumber}");

            }
            else
            {
                Console.Clear();
                Console.WriteLine($"First Name:     {contact.FirstName}");
                Console.WriteLine($"Last Name:      {contact.LastName}");
                Console.WriteLine($"Address:        {contact.Address}");
                Console.WriteLine($"Email:          {contact.Email}");
                Console.WriteLine($"Phone Number:   {contact.PhoneNumber}");

            }
            
        }



    }



}