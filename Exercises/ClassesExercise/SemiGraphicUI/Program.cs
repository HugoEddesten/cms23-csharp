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







            int currentChoice = 1;
            ConsoleKeyInfo keyPress;
            bool programIsOn = true;


            while (programIsOn == true)
            {
                currentChoice = 1;



                do
                {
                    Console.Clear();
                    if (currentChoice == 1)
                    {
                        Console.WriteLine("Your contact list:");

                        Console.WriteLine("=> {Display contacts}");
                        Console.WriteLine("2: Add contact");
                        Console.WriteLine("0: Exit");
                    }
                    else if (currentChoice == 2)
                    {
                        Console.WriteLine("Your contact list:");

                        Console.WriteLine("1: Display contacts");
                        Console.WriteLine("=> {Add contact}");
                        Console.WriteLine("0: Exit");
                    }
                    else if (currentChoice == 3)
                    {
                        Console.WriteLine("Your contact list:");

                        Console.WriteLine("1: Display contacts");
                        Console.WriteLine("2: Add contact");
                        Console.WriteLine("=> {Exit}");
                    }



                    keyPress = Console.ReadKey();
                    if (keyPress.Key == ConsoleKey.DownArrow && currentChoice < 3)
                    {
                        currentChoice++;
                    }
                    else if (keyPress.Key == ConsoleKey.UpArrow && currentChoice > 1)
                    {
                        currentChoice--;
                    }
                    //Console.WriteLine(currentChoice);
                } while (keyPress.Key != ConsoleKey.Enter);
               
                switch (currentChoice)
                {
                    case 2:
                        Console.Clear();
                        AddContact(contacts);
                        break;
                    case 3:
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


    }
}