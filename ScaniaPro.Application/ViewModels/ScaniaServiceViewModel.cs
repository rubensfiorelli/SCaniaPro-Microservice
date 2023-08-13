using ScaniaPro.Core.Enums;

namespace ScaniaPro.Application.ViewModels
{
    public class ScaniaServiceViewModel
    {
        public ScaniaServiceViewModel(Guid id,
                                      string title,
                                      string description,
                                      OilType oil,
                                      decimal pricePerGl,
                                      decimal laborPrice)
        {
            Id = id;
            Title = title;
            Description = description;
            Oil = oil;
            PricePerGl = pricePerGl;
            LaborPrice = laborPrice;
        }

        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public OilType Oil { get; private set; }
        public decimal PricePerGl { get; private set; }
        public decimal LaborPrice { get; private set; }

    }
}
