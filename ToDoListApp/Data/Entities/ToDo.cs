using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp.Data.Entities
{
    [Table("ToDos")]
    public class ToDo
    {
        public ToDo()
        {
            CreationTime = DateTime.Now;
            IsDone = false;
        }

        [Key]
        public int ID { get; set; }

        [Required, Display(Name = "Task")]
        public string Name { get; set; }

        [Required]
        public DateTimeOffset CreationTime { get; set; }

        [Required, Display(Name = "Is Done")]
        public bool IsDone { get; set; }
    }
}
