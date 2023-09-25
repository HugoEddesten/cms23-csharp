using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise.Models;

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
        firstName = string.Empty;
        lastName = string.Empty;
        address = string.Empty;
        email = string.Empty;
        phoneNumber = string.Empty;
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


