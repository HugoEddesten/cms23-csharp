﻿namespace Assignment_ConsoleApp.Models
{
    public interface IContact
    {
        //Guid Id { get; set; }
        DateTime Created { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string FullName { get; }
        Address Address { get; set; }
        string Phone { get; set; }
        string Email { get; set; }
    }
}