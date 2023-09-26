using EShop.Application.Contracts.Persistence.Common;
using EShop.Domain.Shipping;

namespace EShop.Application.Contracts.Persistence;

public interface IShopOrder : IGenericRepository<Order>
{
}