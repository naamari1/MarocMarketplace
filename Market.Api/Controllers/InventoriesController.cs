using Market.Api.Dtos;
using Maroc.Core.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Market.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoriesController : ControllerBase
    {
        private readonly IInventoryService _inventoryService;

        public InventoriesController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var inventories = await _inventoryService.GetAllAsync();
                var inventoriesDtos = inventories.Select(i => new InventoriesResponseDto
                {
                    Id = i.Id,
                    CurrentStock = i.CurrentStock,
                    RecordLevel = i.RecordLevel
                }).ToList();
                return Ok(inventoriesDtos);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }



        [AllowAnonymous]
        [HttpGet("{id}")] 
        public async Task<IActionResult> Get(Guid id)
        {
            try
            {
                var inventory = await _inventoryService.GetByIdAsync(id);

                if (inventory == null)
                {
                    return NotFound();
                }

                var inventoryDto = new InventoriesResponseDto
                {
                    Id = inventory.Id,
                    CurrentStock = inventory.CurrentStock,
                    RecordLevel = inventory.RecordLevel
                };
                return Ok(inventory);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            } 
        }
    }
}
