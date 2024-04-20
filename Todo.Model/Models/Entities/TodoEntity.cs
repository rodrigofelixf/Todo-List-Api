using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Model.Models.Entities
{
    public class TodoEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required(ErrorMessage = "O título é obrigatório.")]
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }
        public int Priority { get; set; }

        public TodoEntity()
        {
        }

        public TodoEntity(long id, string title, string description, bool completed, int priority)
        {
            Id = id;
            Title = title;
            Description = description;
            Completed = completed;
            Priority = priority;
        }
    }
}
