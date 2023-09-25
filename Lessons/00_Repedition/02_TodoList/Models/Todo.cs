using _02_TodoList.Interfaces;

namespace _02_TodoList.Models;

internal class Todo : ITodo
{
    public Guid Id { get; set; }
    public string Activity { get; set; } = null!;
    public DateTime Created { get; set; }
}
