using EShop.Application.Contracts.Persistence.Common;
using EShop.Domain.Order;

namespace EShop.Application.Contracts.Persistence;

public interface IOrderLine : IGenericRepository<Line>
{
}