﻿namespace Assignment_ConsoleApp.Interfaces;

public interface IAddress
{
    string City { get; set; }
    string PostalCode { get; set; }
    string StreetName { get; set; }
    string StreetNumber { get; set; }
    string FullAddress { get; }
}