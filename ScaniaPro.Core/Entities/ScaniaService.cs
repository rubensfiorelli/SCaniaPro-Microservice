using ScaniaPro.Core.Common;
using ScaniaPro.Core.Enums;

namespace ScaniaPro.Core.Entities
{
    public sealed class ScaniaService : BaseEntity
    {
        public ScaniaService(string title,
                             string description,
                             OilType oil,
                             decimal pricePerGl,
                             decimal laborPrice) : base()
        {
            Title = title;
            Description = description;
            Oil = oil;
            PricePerGl = pricePerGl;
            LaborPrice = laborPrice;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public OilType Oil { get; private set; }
        public decimal PricePerGl { get; private set; }
        public decimal LaborPrice { get; private set; }

    }
}
