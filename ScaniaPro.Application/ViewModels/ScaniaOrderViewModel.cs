using ScaniaPro.Core.Entities;

namespace ScaniaPro.Application.ViewModels
{
    public class ScaniaOrderViewModel
    {
        public ScaniaOrderViewModel(string orderCode,
                                    string description,
                                    decimal qtyInGl,
                                    string clientId,
                                    DateTime createAt) : base()
        {
            OrderCode = orderCode;
            Description = description;
            QtyInGl = qtyInGl;
            ClientId = clientId;
            CreateAt = createAt;
        }

        public string OrderCode { get; private set; }
        public string Description { get; private set; }
        public decimal QtyInGl { get; private set; }
        public string ClientId { get; private set; }
        public DateTime CreateAt { get; private set; }

        public static ScaniaOrderViewModel FromEntity(ScaniaOrder scaniaEntity)
        {
            return new ScaniaOrderViewModel(

                scaniaEntity.OrderCode,
                scaniaEntity.Description,
                scaniaEntity.QtyInGl,
                scaniaEntity.ClientId.ToString(),
                scaniaEntity.CreateAt
                );
        }
    }
}
