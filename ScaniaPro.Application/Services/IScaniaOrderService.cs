using ScaniaPro.Application.InputModels;
using ScaniaPro.Application.ViewModels;

namespace ScaniaPro.Core.Interfaces.Services
{
    internal interface IScaniaOrderService
    {
        Task<string> Add(AddScaniaOrderInputModel model);
        Task<ScaniaOrderViewModel> GetOrderCode(string code);
    }
}
