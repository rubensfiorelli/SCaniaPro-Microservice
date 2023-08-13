using ScaniaPro.Core.Common;
using ScaniaPro.Core.ValueObject;

namespace ScaniaPro.Core.Entities
{
    public sealed class Client : BaseEntity
    {
        public Client(Name name,
            string cpf,
            string whatsApp,
            Guid scaniaOrderId)
        {
            Name = name;
            Cpf = cpf;
            WhatsApp = whatsApp;
            ScaniaOrderId = scaniaOrderId;
            IsDeleted = false;
        }

        public Name Name { get; private set; }
        public string Cpf { get; private set; }
        public string WhatsApp { get; private set; }
        public Guid ScaniaOrderId { get; private set; }
        public bool IsDeleted { get; set; }

        public void Update(string newCpf, string newWhatsApp)
        {
            Cpf = newCpf;
            WhatsApp = newWhatsApp;

        }

        public void Delete()
        {
            IsDeleted = true;
        }

    }
}
