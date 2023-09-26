using EShop.Domain.Common;
using EShop.Domain.Product;

namespace EShop.Domain.Order
{
    public class Line : BaseEntity
    {
        public Item? Item { get; set; }
        public int ItemId { get; set; }

        public int Qty { get; set; }
        public int Price { get; set; }
    }
}