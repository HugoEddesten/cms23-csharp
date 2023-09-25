namespace _02_TodoList.Tests
{
    public class TodoServiceTests
    {
        [Fact]
        public void AddTodo_ShouldAddTodoItemToList_ReturnTrue()
        {
            // Arrange - f�rberedelser
            TodoService _todoService = new TodoService();
            TodoServiceTests todo = new Todo() { Id = 1; Name = "Hejsan", Created = DateTime.Now };

            // Act - utf�rande
            bool result = _todoService.AddTodo();

            // Assert - kontroll
            Assert.True(result);

        }
    }
}