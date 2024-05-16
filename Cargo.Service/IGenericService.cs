namespace Cargo.Service
{
    public interface IGenericService <T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> PostAsync(T Entity);
        Task<T> PutAsync(T Entity);
        Task<T> DeleteAsync(int id);
    }
}
