/* Json = JavaScript Object Notation

    "key": "value"

    {
    "firstName": "Hans",
    "lastName": "Mattin-Lassei",
    "skills": ["C#", "JS", "Python"]
    }


*/


using _01_SaveAndToFromRead.Models;
using _01_SaveAndToFromRead.Services;


var customerService = new CustomerService();
customerService.GetCustomers();

var customer = new Customer
{
    FirstName = "Lasse",
    LastName = "Larsson",
    Email = "lasse@domain.com"
};




customerService.AddToList(customer);


Console.ReadKey();
