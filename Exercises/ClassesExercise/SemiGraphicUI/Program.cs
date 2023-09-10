using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace SemiGraphicUI
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
            







            
            ConsoleKeyInfo keyPress;
            bool programIsOn = true;


            while (programIsOn == true)
            {
                int mainMenuChoice = 0;



                do
                {
                    // Displays the main menu 
                    MainMenu(mainMenuChoice);

                    // Reads input and keeps count of which option is selected
                    keyPress = Console.ReadKey();
                    mainMenuChoice = CheckKeyInput(keyPress, mainMenuChoice, 3);

                } while (keyPress.Key != ConsoleKey.Enter);

                switch (mainMenuChoice)
                {

                    case 0:


                        int contactChoice = 0;
                        do
                        {
                            Console.Clear();
                            
                            Console.WriteLine("Your contacts:|");
                            Console.WriteLine("--------------+\n");


                            if (contacts.Count > 0)
                            {
                                // Loops through the list contacts and displays each contact by name
                                ContactMenu(contacts, contactChoice);

                                // Reads input and keeps count of which option is selected
                                keyPress = Console.ReadKey();
                                contactChoice = CheckKeyInput(keyPress, contactChoice, contacts.Count);
                            }
                            else
                            {
                                Console.WriteLine("Well... this place is empty! Add a contact to see them here.");
                                Console.WriteLine("Create a Contact?");

                                keyPress = Console.ReadKey();
                                if (keyPress.Key == ConsoleKey.Backspace)
                                    break;
                                else if (keyPress.Key == ConsoleKey.Enter)
                                {
                                    goto case 1;
                                }
                            }

                        } while (keyPress.Key != ConsoleKey.Enter && keyPress.Key != ConsoleKey.Backspace);
                        if (keyPress.Key == ConsoleKey.Backspace)
                            break;
                        else
                        {

                            int propertyChoice = 0;
                            do
                            {
                                // Displays the menu where the user chooses between contacts
                                PropertyMenu(contacts[contactChoice], propertyChoice);


                                // Reads input and keeps count of which option is selected
                                keyPress = Console.ReadKey();
                                propertyChoice = CheckKeyInput(keyPress, propertyChoice, 5);

                            } while (keyPress.Key != ConsoleKey.Enter && keyPress.Key != ConsoleKey.Backspace);

                            if (keyPress.Key == ConsoleKey.Backspace)
                            {
                                goto case 0;
                            } 
                            else
                            {
                                Contact contact = contacts[contactChoice];
                                switch (propertyChoice)
                                {
                                    case 0:
                                        Console.Clear();
                                        Console.Write("First Name: ");
                                        contact.FirstName = Console.ReadLine() ?? "";
                                        break;
                                    case 1:
                                        Console.Clear();
                                        Console.Write("Last Name: ");
                                        contact.LastName = Console.ReadLine() ?? "";
                                        break;
                                    case 2:
                                        Console.Clear();
                                        Console.Write("Address: ");
                                        contact.Address = Console.ReadLine() ?? "";
                                        break;
                                    case 3:
                                        Console.Clear();
                                        Console.Write("Email: ");
                                        contact.Email = Console.ReadLine() ?? "";
                                        break;
                                    case 4:
                                        Console.Clear();
                                        Console.Write("Phone number: ");
                                        contact.PhoneNumber = Console.ReadLine() ?? "";
                                        break;
                                }
                            }
                            
                        }   
                        break;
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Create a new contact|");
                        Console.WriteLine("--------------------+\n");
                        AddContact(contacts);
                        break;
                    case 2:
                        programIsOn = false;
                        break;

                }   
            }

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


        public static void DisplayContact(Contact contact, bool isEnumerated = false)
        {
            if (isEnumerated == true)
            {
                
                Console.WriteLine($"1: {contact.FirstName}");
                Console.WriteLine($"2: {contact.LastName}");
                Console.WriteLine($"3: {contact.Address}");
                Console.WriteLine($"4: {contact.Email}");
                Console.WriteLine($"5: {contact.PhoneNumber}");

            }
            else
            {
                
                Console.WriteLine($"First Name:     {contact.FirstName}");
                Console.WriteLine($"Last Name:      {contact.LastName}");
                Console.WriteLine($"Address:        {contact.Address}");
                Console.WriteLine($"Email:          {contact.Email}");
                Console.WriteLine($"Phone Number:   {contact.PhoneNumber}");

            }

        }

        public static int CheckKeyInput(ConsoleKeyInfo keyPress, int currentChoice, int numberOfChoices)
        {
            if (keyPress.Key == ConsoleKey.DownArrow && currentChoice < numberOfChoices-1)
            {
                currentChoice++;
            }
            else if (keyPress.Key == ConsoleKey.UpArrow && currentChoice > 0)
            {
                currentChoice--;
            }
            return currentChoice;
        }

        public static void MainMenu(int mainMenuChoice)
        {
            Console.Clear();
            if (mainMenuChoice == 0)
            {
                Console.WriteLine("Your contact list:|");
                Console.WriteLine("------------------+");

                Console.WriteLine("  +----------------+");
                Console.WriteLine("  |Display contacts|");
                Console.WriteLine("  +----------------+");

                Console.WriteLine("   Add contact\n");

                Console.WriteLine("   Exit");
            }
            else if (mainMenuChoice == 1)
            {
                Console.WriteLine("Your contact list:|");
                Console.WriteLine("------------------+\n");

                Console.WriteLine("   Display contacts");
                Console.WriteLine("  +-----------+");
                Console.WriteLine("  |Add contact|");
                Console.WriteLine("  +-----------+");
                Console.WriteLine("   Exit");
            }
            else if (mainMenuChoice == 2)
            {
                Console.WriteLine("Your contact list:|");
                Console.WriteLine("------------------+\n");

                Console.WriteLine("   Display contacts\n");
                Console.WriteLine("   Add contact");
                Console.WriteLine("  +------+");
                Console.WriteLine("  |Exit  |");
                Console.WriteLine("  +------+\n");
            }
        }

        public static void ContactMenu(List<Contact> contacts, int contactChoice)
        {
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contactChoice == i)
                {

                    Console.WriteLine($" |{contacts[i].FirstName} {contacts[i].LastName}|");

                }
                else
                    Console.WriteLine($"  {contacts[i].FirstName} {contacts[i].LastName}");
            }
        }

        public static void PropertyMenu(Contact contact, int currentChoice)
        {
            Console.Clear();
            if (currentChoice == 0)
            {
                Console.WriteLine($"[Edit]    =>    {contact.FirstName}");
                Console.WriteLine($"Last Name:      {contact.LastName}");
                Console.WriteLine($"Address:        {contact.Address}");
                Console.WriteLine($"Email:          {contact.Email}");
                Console.WriteLine($"Phone Number:   {contact.PhoneNumber}");
            }
            else if (currentChoice == 1)
            {
                Console.WriteLine($"First Name:     {contact.FirstName}");
                Console.WriteLine($"[Edit]    =>    {contact.LastName}");
                Console.WriteLine($"Address:        {contact.Address}");
                Console.WriteLine($"Email:          {contact.Email}");
                Console.WriteLine($"Phone Number:   {contact.PhoneNumber}");
            }
            else if (currentChoice == 2)
            {
                Console.WriteLine($"First Name:     {contact.FirstName}");
                Console.WriteLine($"Last Name:      {contact.LastName}");
                Console.WriteLine($"[Edit]    =>    {contact.Address}");
                Console.WriteLine($"Email:          {contact.Email}");
                Console.WriteLine($"Phone Number:   {contact.PhoneNumber}");
            }
            else if (currentChoice == 3)
            {
                Console.WriteLine($"First Name:     {contact.FirstName}");
                Console.WriteLine($"Last Name:      {contact.LastName}");
                Console.WriteLine($"Address:        {contact.Address}");
                Console.WriteLine($"[Edit]    =>    {contact.Email}");
                Console.WriteLine($"Phone Number:   {contact.PhoneNumber}");
            }
            else if (currentChoice == 4)
            {
                Console.WriteLine($"First Name:     {contact.FirstName}");
                Console.WriteLine($"Last Name:      {contact.LastName}");
                Console.WriteLine($"Address:        {contact.Address}");
                Console.WriteLine($"Email:          {contact.Email}");
                Console.WriteLine($"[Edit]    =>    {contact.PhoneNumber}");
            }
        }
            
        
    


    }
}