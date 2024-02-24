namespace Task_Manager_Application.Mvc.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
    }
}
