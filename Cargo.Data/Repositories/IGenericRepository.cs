using Cargo.Data.Models;

namespace Cargo.Data.Repositories
{
    public interface IGenericRepository <T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAllAsync(); 
        Task<T> GetByIdAsync (int id);
        Task<T> PostAsync (T entity);
        Task<T> PutAsync (T entity);
        Task<T> DeleteAsync (int id);

    }
}
