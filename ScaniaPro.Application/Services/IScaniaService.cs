using ScaniaPro.Application.ViewModels;

namespace ScaniaPro.Application.Services
{
    public interface IScaniaService
    {
        Task<List<ScaniaServiceViewModel>> GetAll();
    }
}
