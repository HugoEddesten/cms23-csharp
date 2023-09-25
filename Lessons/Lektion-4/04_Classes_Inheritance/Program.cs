using _04_Classes_Inheritance.Models;

var customer = new PrivateCustomer
{
    FirstName = "Lasse",
    LastName = "Johansson",
    Email = "lasse@domain.com"
};



Console.WriteLine(customer.Id);
Console.WriteLine($"{customer.FirstName} {customer.LastName}");
Console.WriteLine($"Created: {customer.Created}");
Console.WriteLine($"Modified: {customer.Modified}");
Console.ReadLine();


var customer2 = new CompanyCustomer
{
    CompanyName = "FinaGrejor",
    Email = "finagrejor@domain.com",
    PhoneNumber = "1234567890"
};

Console.WriteLine(customer2.Id);
Console.WriteLine(customer2.CompanyName);
Console.WriteLine(customer2.PhoneNumber);

Console.WriteLine($"Created: {customer2.Created}");
Console.WriteLine($"Modified: {customer2.Modified}");
Console.ReadLine();