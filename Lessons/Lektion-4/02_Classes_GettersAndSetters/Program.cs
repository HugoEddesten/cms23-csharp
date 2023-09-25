using _02_Classes_GettersAndSetters.Models;
using System.Text;

var customer = new Customer();


// Set
customer.FirstName = "Hans";
customer.LastName = "Mattin-Lassei";

// Get

var name = customer.FullName;


var user = new User();
user.FirstName = "Hans";
user.LastName = "Mattin-Lassei";
user.Email = " Hans.mattin-lassei@domain.com";

user.SetSecurePassword("password");
var password = Encoding.UTF8.GetString(user.Password);
Console.WriteLine(password);
Console.ReadLine();