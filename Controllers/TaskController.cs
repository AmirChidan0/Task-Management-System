using Microsoft.AspNetCore.Mvc;
using TaskManagerAPI.Models;
using TaskManagerAPI.Data;
using TaskManagerAPI.Services;

namespace TaskManagerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        private readonly ITaskService _taskService;

        public TaskController(ApplicationDbContext context)
        {
            _context = context;
        }
        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }


        [HttpGet]
        public IActionResult GetAllTasks()
        {
            var tasks = _taskService.GetAllTasks();
            return Ok(tasks);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTaskById(int id)
        {
            var task = await _taskService.GetTaskById(id);
            if (task == null)
                return NotFound();
            return Ok(task);
        }

        [HttpPost]
        public IActionResult CreateTask([FromBody] Task task)
        {
            _taskService.CreateTask(task);
            return CreatedAtAction(nameof(GetAllTasks), new { id = task.Id }, task);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTask(int id, [FromBody] Task task)
        {
            if (id != task.Id)
                return BadRequest();
            _taskService.UpdateTask(task);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
        {
            _taskService.DeleteTask(id);
            return NoContent();
        }
    }
}

