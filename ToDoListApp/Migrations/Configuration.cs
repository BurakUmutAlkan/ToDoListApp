namespace ToDoListApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ToDoListApp.Data;
    using ToDoListApp.Data.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            // Example data will be added here

            if (!context.ToDos.Any())
            {
                var exampleToDo1 = new ToDo()
                {
                    Name = "Example Task 1",
                    IsDone = false
                };
                var exampleToDo2 = new ToDo()
                {
                    Name = "Example Task 2",
                    IsDone = false
                };
                var exampleToDo3 = new ToDo()
                {
                    Name = "Example Task 3",
                    IsDone = true
                };
                var exampleToDo4 = new ToDo()
                {
                    Name = "Example Task 4",
                    IsDone = true
                };

                context.ToDos.Add(exampleToDo1);
                context.ToDos.Add(exampleToDo2);
                context.ToDos.Add(exampleToDo3);
                context.ToDos.Add(exampleToDo4);
            }

            context.SaveChanges();
        }
    }
}
