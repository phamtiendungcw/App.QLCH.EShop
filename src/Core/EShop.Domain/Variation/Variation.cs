using EShop.Domain.Common;
using EShop.Domain.Product;

namespace EShop.Domain.Variation
{
    public class Variation : BaseEntity
    {
        public string Name { get; set; }

        public Category? Category { get; set; }
        public int CategoryId { get; set; }
    }
}