using ScaniaPro.Application.InputModels;
using ScaniaPro.Application.ViewModels;
using ScaniaPro.Core.Interfaces.Repositories;
using ScaniaPro.Core.Interfaces.Services;

namespace ScaniaPro.Application.Services
{
    public class ScaniaOrderService : IScaniaOrderService
    {
        protected readonly IScaniaOrderRepository _repository;

        public ScaniaOrderService(IScaniaOrderRepository repository)
        {
            _repository = repository;
        }
        public async Task<string> Add(AddScaniaOrderInputModel model)
        {
            var scaniaOrder = model.ToEntity();

            var services = model
                .Services
                .Select(s => s.ToEntity())
                .ToList();

            scaniaOrder.SetupServices(services);

            await _repository.AddAsync(scaniaOrder);

            return scaniaOrder.OrderCode;

        }

        public async Task<ScaniaOrderViewModel> GetOrderCode(string code)
        {
            var scaniaOrder = await _repository.GetOrderCodeAsync(code);

            return ScaniaOrderViewModel.FromEntity(scaniaOrder);
        }
    }
}
