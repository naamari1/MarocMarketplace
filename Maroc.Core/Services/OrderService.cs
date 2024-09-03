using Maroc.Core.Entities;
using Maroc.Core.Interfaces;
using Maroc.Core.Interfaces.Services;

namespace Maroc.Core.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Order> AddAsync(Order entity)
        {
            try
            {
                return await _orderRepository.AddAsync(entity);

            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error adding order.", ex);
            }
        }

        public IQueryable<Order> GetAll()
        {
            try
            {
                return _orderRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error retrieving orders.", ex);
            }
        }

        public async Task<ICollection<Order>> GetAllAsync()
        {
            try
            {
                return await _orderRepository.GetAllAsync();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error retrieving orders.", ex);
            }
        }

        public async Task<Order> GetByIdAsync(Guid id)
        {
            try
            {

                var order = await _orderRepository.GetByIdAsync(id);
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

        public async Task<Order> UpdateAsync(Order entity)
        {
            try
            {
                return await _orderRepository.UpdateAsync(entity);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error updating order.", ex);
            }
        }
    }
}
