using EShop.Application.Contracts.Persistence.Common;
using EShop.Domain.Product;

namespace EShop.Application.Contracts.Persistence;

public interface IProductCategory : IGenericRepository<Category>
{
}