using ScaniaPro.Core.Entities;

namespace ScaniaPro.Core.Interfaces.Repositories
{
    public interface IScaniaOrderRepository : IUnitOfWork
    {
        Task<ScaniaOrder> GetOrderCodeAsync(string code);
        Task AddAsync(ScaniaOrder order);

    }
}
