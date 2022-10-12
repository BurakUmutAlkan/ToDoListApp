using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListApp.Data.Entities;

namespace ToDoListApp.Data
{
    internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("name=myConnection")
        {
        }

        // DbSets will be added here

        public DbSet<ToDo> ToDos { get; set; }
    }
}
