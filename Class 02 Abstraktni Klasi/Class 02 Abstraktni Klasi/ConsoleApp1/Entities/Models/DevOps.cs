using ConsoleApp1.Entities.BaseEntity;

namespace ConsoleApp1.Entities.Models
{
    public class DevOps: Human
    {
        public DevOps(int id, string firstName, string lastName, int age, string phone, bool awsCert, bool azureCert) : base(id, firstName, lastName, age, phone)
        {
            AWSCertified = awsCert;
            AzureCertified = azureCert;
        }

        public bool AWSCertified { get; set; }
        public bool AzureCertified { get; set; }

    }
}
