using EShop.Domain.Common;

namespace EShop.Domain
{
    public class Address : BaseEntity
    {
        public string UnitNumber { get; set; }
        public string StreetNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string? PostalCode { get; set; }

        public Country? Country { get; set; }
        public int CountryId { get; set; }
    }
}