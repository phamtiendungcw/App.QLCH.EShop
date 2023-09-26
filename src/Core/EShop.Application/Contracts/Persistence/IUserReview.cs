using EShop.Application.Contracts.Persistence.Common;
using EShop.Domain.User;

namespace EShop.Application.Contracts.Persistence;

public interface IUserReview : IGenericRepository<Review>
{
}