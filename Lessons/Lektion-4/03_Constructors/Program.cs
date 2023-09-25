using _03_Constructors.Models;

var customer1 = new Customer();
customer1.Id = 1;
customer1.Name = "Hans Mattin-Lassei";
customer1.Email = "hans@domain.com";

var customer2 = new Customer
{
    Id = 1,
    Name = "Hans Mattin-Lassei",
    Email = "hans@domain.com"
};
s