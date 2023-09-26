using EShop.Domain.Common;
using EShop.Domain.Product;

namespace EShop.Domain.Shopping
{
    public class CartItem : BaseEntity
    {
        public Cart? Cart { get; set; }
        public int CartId { get; set; }

        public Item? Item { get; set; }
        public int ItemId { get; set; }

        public int Qty { get; set; }
    }
}