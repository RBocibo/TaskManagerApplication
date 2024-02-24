
using Task_Manager_Application.Mvc.Data;

namespace Task_Manager_Application.Mvc.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TaskManagerDbContext _context;

        public UnitOfWork(TaskManagerDbContext context)
        {
            _context = context;
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
