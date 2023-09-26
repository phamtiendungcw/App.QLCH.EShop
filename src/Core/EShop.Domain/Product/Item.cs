using EShop.Domain.Common;

namespace EShop.Domain.Product
{
    public class Item : BaseEntity
    {
        public Product? Product { get; set; }
        public int ProductId { get; set; }

        public string Sku { get; set; }
        public int QtyInStock { get; set; }
        public string? ProductImage { get; set; }
        public int Price { get; set; }
    }
}