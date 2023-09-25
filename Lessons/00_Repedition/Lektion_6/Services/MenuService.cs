using Lektion_6.Interfaces;
using Lektion_6.Models;

namespace Lektion_6.Services;

internal class MenuService : IMenuService
{
    private readonly ITodoService todoService = new TodoService();

    public void AddMenu()
    {
        var todo = new Todo();

        Console.Clear();
        Console.Write("Ange Aktivitet: ");
        todo.Activity = Console.ReadLine()!;

        todoService.Add(todo);
    }

    public void DeleteMenu()
    {
        try
        {
            Console.Clear();
            Console.Write("Ange id: ");
            var id = Console.ReadLine()!;
            todoService.Delete(new Guid(id));
        }
        catch { }
    }

    public void ListMenu()
    {

        Console.Clear();
        Console.WriteLine("ATT-GÖRA-LISTAN");
        Console.WriteLine("---------------");

        foreach (var todo in todoService.GetAll()) 
        {
            Console.WriteLine($"{todo.Activity}");
            Console.WriteLine($"{todo.Id} - {todo.Created}");
            Console.WriteLine();
        }
        Console.ReadKey();
    }

    public void MainMenu()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("ATT-GÖRA-LISTAN");
            Console.WriteLine("---------------");
            Console.WriteLine("1. Lägg till aktivitet");
            Console.WriteLine("2. Visa alla aktiviteter");
            Console.WriteLine("3. Ta bort en aktivitet");
            Console.Write("Ange ett av talen ovan: ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddMenu();
                    break;
                case "2":
                    ListMenu();
                    break;
                case "3":
                    DeleteMenu();
                    break;
            }

        } while (true);
    }
}
