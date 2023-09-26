using EShop.Domain.Common;

namespace EShop.Domain.Shipping
{
    public class Method : BaseEntity
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
