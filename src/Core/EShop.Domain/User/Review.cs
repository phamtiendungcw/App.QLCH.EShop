using EShop.Domain.Common;

namespace EShop.Domain.User
{
    public class Review : BaseEntity
    {
        public User? User { get; set; }
        public int UserId { get; set; }

        public int OrderId { get; set; }

        public int RatingValue { get; set; }
        public string Comment { get; set; }
    }
}