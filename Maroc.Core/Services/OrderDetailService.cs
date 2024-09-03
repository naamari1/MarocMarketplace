using Maroc.Core.Entities;
using Maroc.Core.Interfaces;
using Maroc.Core.Interfaces.Services;

namespace Maroc.Core.Services
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IOrderDetailRepository _orderDetailRepository;

        public OrderDetailService(IOrderDetailRepository orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }

        public async Task<OrderDetail> AddAsync(OrderDetail entity)
        {
            try
            {
                return await _orderDetailRepository.AddAsync(entity);

            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error adding order.", ex);
            }
        }

        public IQueryable<OrderDetail> GetAll()
        {
            try
            {
                return _orderDetailRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error retrieving orders.", ex);
            }
        }

        public async Task<ICollection<OrderDetail>> GetAllAsync()
        {
            try
            {
                return await _orderDetailRepository.GetAllAsync();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error retrieving orders.", ex);
            }
        }

        public async Task<OrderDetail> GetByIdAsync(Guid id)
        {
            try
            {

                var order = await _orderDetailRepository.GetByIdAsync(id);
                if (order == null)
                {
                    throw new InvalidOperationException("Order not found.");
                }
                return order;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error retrieving order.", ex);
            }
        }

        public async Task<OrderDetail> UpdateAsync(OrderDetail entity)
        {
            try
            {
                return await _orderDetailRepository.UpdateAsync(entity);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error updating order.", ex);
            }
        }
    }
}
