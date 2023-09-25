namespace _02_TodoList.Tests
{
    public class TodoServiceTests
    {
        [Fact]
        public void AddTodo_ShouldAddTodoItemToList_ReturnTrue()
        {
            // Arrange - förberedelser
            TodoService _todoService = new TodoService();
            TodoServiceTests todo = new Todo() { Id = 1; Name = "Hejsan", Created = DateTime.Now };

            // Act - utförande
            bool result = _todoService.AddTodo();

            // Assert - kontroll
            Assert.True(result);

        }
    }
}