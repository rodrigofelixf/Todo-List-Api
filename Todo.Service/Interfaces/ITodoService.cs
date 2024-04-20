using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Model.Models.Entities;

namespace Todo.Service.Interfaces
{
    public interface ITodoService
    {
        Task<List<TodoEntity>> CreateTodo(TodoEntity todo);
        Task<List<TodoEntity>> GetAllAsync();


    }


}
