using Microsoft.EntityFrameworkCore;
using Task_Manager_Application.Mvc.Models;
using Task = Task_Manager_Application.Mvc.Models.Task;

namespace Task_Manager_Application.Mvc.Data
{
    public class TaskManagerDbContext : DbContext
    {
        public TaskManagerDbContext(DbContextOptions<TaskManagerDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<Person> People { get; set; }
    }
}
