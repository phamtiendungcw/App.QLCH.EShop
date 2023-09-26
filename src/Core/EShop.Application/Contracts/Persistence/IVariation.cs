using EShop.Application.Contracts.Persistence.Common;
using EShop.Domain.Variation;

namespace EShop.Application.Contracts.Persistence;

public interface IVariation : IGenericRepository<Variation>
{
}