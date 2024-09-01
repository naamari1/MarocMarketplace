﻿namespace Maroc.Core.Interfaces.Services
{
    public interface ICrudService<T> where T : class
    {
        public IQueryable<T> GetAll();
        public Task<T> GetByIdAsync(int id);
        public Task<T> AddAsync(T entity);
        public Task<ICollection<T>> GetAllAsync();
        public Task<T> UpdateAsync(T entity);
    }
}