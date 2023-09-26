using EShop.Domain.Common;

namespace EShop.Domain.User
{
    public class UserAddress : BaseEntity
    {
        public User? User { get; set; }
        public int UserId { get; set; }

        public Address? Address { get; set; }
        public int AddressId { get; set; }

        public int IsDefault { get; set; }
    }
}