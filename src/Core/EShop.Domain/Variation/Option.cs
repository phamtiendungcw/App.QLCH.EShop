using EShop.Domain.Common;

namespace EShop.Domain.Variation
{
    public class Option : BaseEntity
    {
        public Variation? Variation { get; set; }
        public int VariationId { get; set; }

        public string Value { get; set; }
    }
}