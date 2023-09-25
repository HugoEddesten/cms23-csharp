using Lektion_6.Interfaces;
using Lektion_6.Models;

namespace Lektion_6.Services;

internal class TodoService : ITodoService
{

    private readonly List<Todo> list = new List<Todo>();

    public void Add(Todo todo)
    {
        list.Add(todo);
    }

    public void Delete(Guid id)
    {
        var todo = list.FirstOrDefault(x => x.Id == id);
        if (todo != null)
            list.Remove(todo);
    }

    public IEnumerable<Todo> GetAll()
    {
        return list.OrderByDescending(todo => todo.Created);
    }
}
