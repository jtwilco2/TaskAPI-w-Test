using Microsoft.AspNetCore.Mvc;
using TaskApi.Models;

namespace TaskApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTasks()
        {
            var tasks = new List<TaskItem>
            {
                new TaskItem { Id = 1, Title = "Prepare for interview", IsComplete = false },
                new TaskItem { Id = 2, Title = "Build demo app", IsComplete = true }
            };

            return Ok(tasks);
        }
    }
}