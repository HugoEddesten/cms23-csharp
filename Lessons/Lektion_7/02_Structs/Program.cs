using _02_Structs.Structs.Domain_Driven_Design;
using _02_Structs.Structs.Interoperability;
using _02_Structs.Structs.Mathematical_Models;
using _02_Structs.Structs.Performance_Sensitive;
using _02_Structs.Structs.Value_Semantics;

// Matematiska  modeller
Vector2D vector = new Vector2D(3.4, 4.2);
Console.WriteLine($"Vector: X={vector.X}, Y={vector.Y}");

// Interoperabilitet
Todo todo = new Todo{userId = 1, id = 1, title = "delectus aut autem", completed = false};
Console.WriteLine($"Todo: {todo.userId}, {todo.title}");

// Prestandakänsliga applikationer
RgbColor color = new RgbColor(255, 0, 0);
Console.WriteLine($"Color: R={color.R}, G={color.G}, B={color.B}");

// Värdesemantik
Money salary = new Money(5000M, "SEK");
Console.WriteLine($"Money: Amount={salary.Amount}, Currency={salary.Currency}");

// Domain Driven Design
var user = new User 
{ 
    FirstName = "Hans", 
    LastName = "Mattin-Lassei", 
    Email = new Email("hans@Domain.com"), 
    Password = new Password("BytMig123!") 
};
Console.WriteLine($"{user.FirstName} {user.LastName} <{user.Email}>");
