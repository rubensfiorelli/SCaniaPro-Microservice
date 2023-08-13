using ScaniaPro.Core.Entities;
using ScaniaPro.Core.Enums;
using ScaniaPro.Core.ValueObject;

namespace ScaniaPro.Application.InputModels
{
    public class AddScaniaOrderInputModel
    {
        public string Description { get; set; }
        public decimal QtyInGl { get; set; }
        public Guid ClientId { get; set; }
        public List<ScaniaServiceInputModel> Services { get; set; }

        public ScaniaOrder ToEntity()
            => new ScaniaOrder(Description, QtyInGl, ClientId);

    }

    public class NameInputModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Name ToValueObject()
            => new Name(FirstName, LastName);
    }

    public class ScaniaServiceInputModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public OilType Oil { get; set; }
        public decimal PricePerGl { get; set; }
        public decimal LaborPrice { get; set; }

        public ScaniaService ToEntity()
            => new ScaniaService(Title, Description, Oil, PricePerGl, LaborPrice);
    }




}
