using ScaniaPro.Core.Entities;

namespace ScaniaPro.Core.Interfaces.Repositories
{
    public interface IScaniaServiceRepository : IUnitOfWork
    {
        Task<List<ScaniaService>> GetAllAsync();
    }
}
