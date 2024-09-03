using Market.Api.Dtos;
using Maroc.Core.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Market.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersDetailController : ControllerBase
    {
        private readonly IOrderDetailService _orderDetailService;

        public OrdersDetailController(IOrderDetailService orderDetailService)
        {
            _orderDetailService = orderDetailService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var ordersDetail = await _orderDetailService.GetAllAsync();
                var orderDetailDtos = ordersDetail.Select(o => new OrdersDetailResponseDto
                {
                    Id = o.Id,
                    OrderId = o.OrderId,
                    ProductId = o.ProductId,
                    Quantity = o.Quantity,
                    Price = o.Price
                }).ToList();
                return Ok(orderDetailDtos);
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
                var orderDetail = await _orderDetailService.GetByIdAsync(id);

                if (orderDetail == null)
                {
                    return NotFound();
                }
                var orderDetailDto = new OrdersDetailResponseDto
                {
                    Id = orderDetail.Id,
                    OrderId = orderDetail.OrderId,
                    ProductId = orderDetail.ProductId,
                    Quantity = orderDetail.Quantity,
                    Price = orderDetail.Price
                };
                return Ok(orderDetailDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
