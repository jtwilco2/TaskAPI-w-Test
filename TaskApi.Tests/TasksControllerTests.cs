using Microsoft.AspNetCore.Mvc;
using TaskApi.Controllers;
using TaskApi.Models;

namespace TaskApi.Tests
{
    public class TasksControllerTests
    {
        [Fact]
        public void GetTasks_ReturnsOkResult_WithListOfTasks()
        {
            // Arrange
            var controller = new TasksController();

            // Act
            var result = controller.GetTasks();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var tasks = Assert.IsAssignableFrom<List<TaskItem>>(okResult.Value);
            
            Assert.Equal(2, tasks.Count);
        }
    }
}
