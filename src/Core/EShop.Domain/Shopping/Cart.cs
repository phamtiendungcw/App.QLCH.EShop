using EShop.Domain.Common;

namespace EShop.Domain.Shopping
{
    public class Cart : BaseEntity
    {
        public User.User? User { get; set; }
        public int UserId { get; set; }
    }
}