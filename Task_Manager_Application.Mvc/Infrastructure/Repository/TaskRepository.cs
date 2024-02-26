using Task_Manager_Application.Mvc.Data;
using Task_Manager_Application.Mvc.Entities.Repositories;

namespace Task_Manager_Application.Mvc.Infrastructure.Repository
{
    public class TaskRepository : BaseRepository<Models.Task>, ITaskRepository
    {
        public TaskRepository(TaskManagerDbContext dbContext) : base(dbContext)
        {
        }
    }
}
