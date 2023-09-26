using EShop.Domain.Common;

namespace EShop.Domain.Promotion
{
    public class Category : BaseEntity
    {
        public Product.Category? ProductCategory { get; set; }
        public int ProductCategoryId { get; set; }

        public Promotion? Promotion { get; set; }
        public int PromotionId { get; set; }
    }
}