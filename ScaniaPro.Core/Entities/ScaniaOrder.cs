using ScaniaPro.Core.Common;
using ScaniaPro.Core.Enums;

namespace ScaniaPro.Core.Entities
{
    public sealed class ScaniaOrder : BaseEntity
    {
        public ScaniaOrder(string description, decimal qtyInGl, Guid clientId)
        {
            OrderCode = GanerateOrderCode();
            Description = description;
            QtyInGl = qtyInGl;
            ClientId = clientId;


            Type = OilType.OilMotor10w40;
            Services = new List<ScaniaOrderService>();

        }

        public string OrderCode { get; private set; }
        public OilType Type { get; private set; }
        public string Description { get; private set; }
        public decimal QtyInGl { get; private set; }
        public Guid ClientId { get; private set; }
        public decimal TotalPrice { get; private set; }
        public List<ScaniaOrderService> Services { get; private set; }


        public void SetupServices(List<ScaniaService> services)
        {
            foreach (var service in services)
            {
                var servicePrice = service.PricePerGl + service.LaborPrice * QtyInGl;
                TotalPrice += servicePrice;

                Services.Add(new ScaniaOrderService(service.Title, servicePrice));
            }

        }

        private static string GanerateOrderCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numbers = "0123456789";

            var code = new char[10];
            var random = new Random();

            for (var i = 0; i < 5; i++)
            {
                code[i] = chars[random.Next(chars.Length)];
            }

            for (var i = 5; i < 10; i++)
            {
                code[i] = numbers[random.Next(numbers.Length)];
            }

            return new string(code);
        }

    }
}
