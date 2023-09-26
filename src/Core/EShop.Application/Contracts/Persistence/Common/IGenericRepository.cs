namespace EShop.Application.Contracts.Persistence.Common
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAsync();

        Task<T> GetByIdAsync(int id);

        Task<T> CreateAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);
    }
}