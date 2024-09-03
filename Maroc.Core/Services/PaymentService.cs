using Maroc.Core.Entities;
using Maroc.Core.Interfaces;
using Maroc.Core.Interfaces.Services;

namespace Maroc.Core.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }
        public async Task<Payment> AddAsync(Payment entity)
        {
            try
            {
                return await _paymentRepository.AddAsync(entity);

            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error adding Payment.", ex);
            }
        }

        public IQueryable<Payment> GetAll()
        {
            try
            {
                return _paymentRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error retrieving Payments.", ex);
            }
        }

        public async Task<ICollection<Payment>> GetAllAsync()
        {
            try
            {
                return await _paymentRepository.GetAllAsync();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error retrieving Payments.", ex);
            }
        }

        public async Task<Payment> GetByIdAsync(Guid id)
        {
            try
            {

                var order = await _paymentRepository.GetByIdAsync(id);
                if (order == null)
                {
                    throw new InvalidOperationException("Payment not found.");
                }
                return order;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error retrieving Payment.", ex);
            }
        }

        public async Task<Payment> UpdateAsync(Payment entity)
        {
            try
            {
                return await _paymentRepository.UpdateAsync(entity);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error updating Payment.", ex);
            }
        }
    }
}
