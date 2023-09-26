using EShop.Domain.Common;
using EShop.Domain.Variation;

namespace EShop.Domain.Product
{
    public class Configuration : BaseEntity
    {
        public Item? Item { get; set; }
        public int ItemId { get; set; }

        public Option? Option { get; set; }
        public int OptionId { get; set; }
    }
}