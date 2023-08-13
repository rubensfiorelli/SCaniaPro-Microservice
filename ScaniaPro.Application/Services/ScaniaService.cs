using ScaniaPro.Application.ViewModels;
using ScaniaPro.Core.Interfaces.Repositories;

namespace ScaniaPro.Application.Services
{
    public class ScaniaService : IScaniaService
    {
        protected readonly IScaniaServiceRepository _repository;

        public ScaniaService(IScaniaServiceRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<ScaniaServiceViewModel>> GetAll()
        {
            var services = await _repository.GetAllAsync();

            return services
                .Select(s => new ScaniaServiceViewModel(s.Id, s.Title, s.Description, s.Oil, s.PricePerGl, s.LaborPrice))
                .ToList();
        }
    }
}
