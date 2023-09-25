using Lektion_6.Models;

namespace Lektion_6.Interfaces;

internal interface ITodoService
{
    void Add(Todo todo);

    IEnumerable<Todo> GetAll();

    void Delete(Guid id);

}
