using Maroc.Core.Entities;
using Maroc.Core.Interfaces;
using Maroc.Core.Interfaces.Services;

namespace Maroc.Core.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;

        public ReviewService(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }
        public async Task<Review> AddAsync(Review entity)
        {
            try
            {
                // Assuming future logic here.
                return await _reviewRepository.AddAsync(entity);
            }
            catch (Exception ex)
            {
                // Log the exception, transform it, or handle it as needed
                throw new InvalidOperationException("Error adding Review.", ex);
            }
        }

        public IQueryable<Review> GetAll()
        {
            try
            {
                return _reviewRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error retrieving Reviews.", ex);
            }
        }

        public async Task<ICollection<Review>> GetAllAsync()
        {
            try
            {
                return await _reviewRepository.GetAllAsync();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error retrieving Reviews.", ex);
            }
        }

        public async Task<Review> GetByIdAsync(Guid id)
        {

            try
            {
                var review = await _reviewRepository.GetByIdAsync(id);
                if (review == null)
                {
                    throw new KeyNotFoundException($"Review with ID {id} was not found.");
                }
                return review;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error retrieving Review.", ex);
            }
        }

        public async Task<Review> UpdateAsync(Review entity)
        {
            try
            {
                // Assuming future logic here.
                return await _reviewRepository.UpdateAsync(entity);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error updating Review.", ex);
            }
        }
    }
}
