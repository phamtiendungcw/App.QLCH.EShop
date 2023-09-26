using EShop.Domain.Common;

namespace EShop.Domain.User
{
    public class PaymentMethod : BaseEntity
    {
        public User? User { get; set; }
        public int UserId { get; set; }

        public PaymentType? PaymentType { get; set; }
        public int PaymentTypeId { get; set; }

        public string Provider { get; set; }
        public string AccountNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int IsDefault { get; set; }
    }
}