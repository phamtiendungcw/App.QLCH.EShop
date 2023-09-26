using EShop.Domain.Common;
using EShop.Domain.Order;
using EShop.Domain.User;

namespace EShop.Domain.Shipping
{
    public class Order : BaseEntity
    {
        public User.User? User { get; set; }
        public int UserId { get; set; }

        public DateTime OrderDate { get; set; }

        public PaymentMethod? PaymentMethod { get; set; }
        public int PaymentMethodId { get; set; }

        public Address? Address { get; set; }
        public int AddressId { get; set; }

        public Method? Method { get; set; }
        public int MethodId { get; set; }

        public int Total { get; set; }

        public Status? Status { get; set; }
        public int StatusId { get; set; }
    }
}
