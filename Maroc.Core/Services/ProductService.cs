using Maroc.Core.Entities;
using Maroc.Core.Interfaces;
using Maroc.Core.Interfaces.Services;

namespace Maroc.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> AddAsync(Product entity)
        {
            try
            {
                // Assuming future logic here.
                return await _productRepository.AddAsync(entity);
            }
            catch (Exception ex)
            {
                // Log the exception, transform it, or handle it as needed
                throw new InvalidOperationException("Error adding product.", ex);
            }
        }

        public IQueryable<Product> GetAll()
        {
            try
            {
                return _productRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error retrieving products.", ex);
            }
        }

        public async Task<ICollection<Product>> GetAllAsync()
        {
            try
            {
                return await _productRepository.GetAllAsync();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error retrieving products.", ex);
            }
        }

        public async Task<Product> GetByIdAsync(int id)
        {

            try
            {
                var product = await _productRepository.GetByIdAsync(id);
                if (product == null)
                {
                    throw new KeyNotFoundException($"Product with ID {id} was not found.");
                }
                return product;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error retrieving product.", ex);
            }
        }

        public async Task<Product> UpdateAsync(Product entity)
        {
            try
            {
                // Assuming future logic here.
                return await _productRepository.UpdateAsync(entity);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error updating product.", ex);
            }
        }
    }
}
