using _02_TodoList.Interfaces;

namespace _02_TodoList.Tests.UnitTests;

public class TodoService_Should
{
    [Fact]
    public void AddTodo_Should_AddOneTodoToList_AndReturnTrue()
    {

        // Arrange
        ITodoService todoService = new TodoService();
        ITodo todo = new Todo();

        // Act
        todo.Id = Guid.NewGuid();
        todo.Activity = "TestAktivitet";
        todo.Created = DateTime.Now;

        bool result = todoService.AddTodo(todo);

        // Assert
        Assert.True(result);
    }
}
