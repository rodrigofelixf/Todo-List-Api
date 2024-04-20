using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Todo.Infra.Context;
using Todo.Model.Models.Entities;
using Todo.Service.Interfaces;

namespace Todo.Service.Services
{
    public class TodoService : ITodoService
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly ILogger<TodoService> _logger;

        public TodoService(ApplicationDbContext applicationDbContext, ILogger<TodoService> logger)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
        }

        public async Task<List<TodoEntity>> CreateTodo(TodoEntity todo)
        {
            _applicationDbContext.Todos.Add(todo);
            await _applicationDbContext.SaveChangesAsync();
            return await GetAllAsync();
        }

        public Task<List<TodoEntity>> GetAllAsync()
        {
            return _applicationDbContext.Todos.ToListAsync();
        }
    }
}
