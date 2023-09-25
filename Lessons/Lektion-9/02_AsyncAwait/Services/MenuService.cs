using System.Data.Common;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace _02_AsyncAwait.Services;

internal class MenuService
{
    public record User(string Name, string Email);

    public static void AddUser()
    {
        var user = new User("Hans", "hans@domain.com");
        Console.WriteLine("Starting...");
        Console.WriteLine("Saving user to database");
        Task.Run(() => UserService.SaveUserAsync(user));

        Console.WriteLine("Continue doing some work");

    }
}
