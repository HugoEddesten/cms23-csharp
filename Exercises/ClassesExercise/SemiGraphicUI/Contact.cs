using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemiGraphicUI
{
    internal class Contact
    {
        // declare the private properties
        private string firstName;
        private string lastName;
        private string address;
        private string email;
        private string phoneNumber;

        // Make the properties !null
        public Contact()
        {
            firstName = String.Empty;
            lastName = String.Empty;
            address = String.Empty;
            email = String.Empty;
            phoneNumber = String.Empty;
        }

        // declare and assign the public properties from which the private properties are assigned
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value != "!")
                    firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value != "!")
                    lastName = value;
            }
        }
        public string Address
        {
            get { return address; }
            set
            {
                if (value != "!")
                    address = value;
            }
        }
        public string Email
        {
            get { return email; }
            set { if (IsValidEmail(value) && value != "!") { email = value; } }
        }

        private bool IsValidEmail(string email)
        {
            // To be implemented
            return true;
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (value != "!")
                    phoneNumber = value;
            }
        }

    }

}
