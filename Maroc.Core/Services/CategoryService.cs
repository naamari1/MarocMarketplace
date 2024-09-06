using Maroc.Core.Entities;
using Maroc.Core.Interfaces;
using Maroc.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maroc.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Category> AddAsync(Category entity)
        {

            try
            {
                return await _categoryRepository.AddAsync(entity);
            }
            catch (Exception ex)
            {

                throw new InvalidOperationException("Error adding category", ex);
            }
        }

        public IQueryable<Category> GetAll()
        {
            try
            {
                return _categoryRepository.GetAll();
            }
            catch (Exception ex)
            {

                throw new InvalidOperationException("Error retrieving categories", ex);
            }
        }

        public async Task<ICollection<Category>> GetAllAsync()
        {
            try
            {
               return await _categoryRepository.GetAllAsync();
            }
            catch (Exception ex)
            {

                throw new InvalidOperationException("Error retrieving categories",ex);
            }
        }

        public async Task<Category> GetByIdAsync(Guid id)
        {
            try
            {
                var category = await _categoryRepository.GetByIdAsync(id);
                if (category == null) 
                {
                    throw new KeyNotFoundException($"category with ID {id} was not found.");
                }
                return category;
            }
            catch (Exception ex)
            {
                throw new InvalidCastException("Error retrieving category.", ex);
            }
        }

        public async Task<Category> UpdateAsync(Category entity)
        {
            try
            {
                return await _categoryRepository.UpdateAsync(entity);
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error updating.", ex);
            }
        }
    }
}
