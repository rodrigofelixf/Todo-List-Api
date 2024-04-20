using Microsoft.AspNetCore.Mvc;
using Todo.Model.Models.Entities;
using Todo.Service.Interfaces;

namespace Todo.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {

        private readonly ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }


        [HttpPost]
        public async Task<ActionResult> CreateTask(TodoEntity todo)
        {
            var createdTodos = await _todoService.CreateTodo(todo);

            return StatusCode(201, createdTodos);
        }

        [HttpGet]
        public async Task<ActionResult> GetAllTask()
        {
            var allTasks = await _todoService.GetAllAsync();
            return Ok(allTasks);
        }

    }
}
