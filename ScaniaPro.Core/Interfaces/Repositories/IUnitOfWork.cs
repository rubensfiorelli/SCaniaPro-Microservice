namespace ScaniaPro.Core.Interfaces.Repositories
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
        Task Rollback();

    }
}
