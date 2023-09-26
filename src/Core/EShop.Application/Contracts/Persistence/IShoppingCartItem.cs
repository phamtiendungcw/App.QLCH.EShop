using EShop.Application.Contracts.Persistence.Common;
using EShop.Domain.Shopping;

namespace EShop.Application.Contracts.Persistence;

public interface IShoppingCartItem : IGenericRepository<CartItem>
{
}