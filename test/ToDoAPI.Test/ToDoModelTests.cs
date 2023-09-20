using ToDoAPI.Models;

namespace ToDoAPI.Test;

public class ToDoModelTests
{
    [Fact]
    public void CanChangeName()
    {
        //Arrange
        var testToDo = new ToDoItem
        {
            Task = "Complete unit test",
            Done = false
        };

        //Act
        testToDo.Task = "Complete azure pipeline";

        //Assert
        Assert.Equal("Complete azure pipeline", testToDo.Task);
    }
}