using EShop.Domain.Common;

namespace EShop.Domain.Promotion
{
    public class Promotion : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int DiscountRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}