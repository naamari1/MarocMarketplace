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
    public class InventoryService : IInventoryService
    {
        private readonly IInventoryRepository _inventoryRepository;

        public InventoryService(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        public async Task<Inventory> AddAsync(Inventory entity)
        {
            try
            {
                return await _inventoryRepository.AddAsync(entity);
            }
            catch (Exception ex)
            {

                throw new InvalidOperationException("Error adding new inventory", ex);
            }
        }

        public IQueryable<Inventory> GetAll()
        {
            try
            {
                return _inventoryRepository.GetAll();
            }
            catch (Exception ex)
            {

                throw new InvalidOperationException("Error retrieving inventory",ex);
            }
        }

        public async Task<ICollection<Inventory>> GetAllAsync()
        {
            try
            {
                return await _inventoryRepository.GetAllAsync();
            }
            catch (Exception ex)
            {

                throw new InvalidOperationException("Error retrieving inventory.",ex);
            }
        }

        public async Task<Inventory> GetByIdAsync(Guid id)
        {
            try
            {
                var inventory = await _inventoryRepository.GetByIdAsync(id);

                if (inventory == null) 
                {
                    throw new KeyNotFoundException($"Inventory with ID {id} was not found.");
                }
                return inventory;
            }
            catch (Exception ex)
            {

                throw new InvalidOperationException("Error retrieving inventory", ex);
            }
        }

        public async Task<Inventory> UpdateAsync(Inventory entity)
        {
            try
            {
                return await _inventoryRepository.UpdateAsync(entity);
            }
            catch (Exception ex)
            {

                throw new InvalidOperationException("Error updating inventory", ex);
            }
        }
    }
}
