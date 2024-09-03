namespace Maroc.Core.Interfaces
{
    public interface ICrudRepository<T> where T : class
    {
        public IQueryable<T> GetAll();
        public Task<T> GetByIdAsync(Guid id);
        public Task<T> AddAsync(T entity);
        public Task<ICollection<T>> GetAllAsync();
        public Task<T> UpdateAsync(T entity);
    }
}
