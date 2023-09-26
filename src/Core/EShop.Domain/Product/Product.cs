using EShop.Domain.Common;

namespace EShop.Domain.Product
{
    public class Product : BaseEntity
    {
        public Category? Category { get; set; }
        public int CategoryId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string ProductImage { get; set; }
    }
}