using ScaniaPro.Core.Common;

namespace ScaniaPro.Core.Entities
{
    public sealed class ScaniaOrderService : BaseEntity
    {
        public ScaniaOrderService(string title, decimal price) : base()
        {
            Title = title;
            Price = price;
        }

        public string Title { get; private set; }
        public decimal Price { get; private set; }
    }
}
