using Market.Api.Dtos;
using Maroc.Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Market.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentsController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var payments = await _paymentService.GetAllAsync();
                var paymentDto = payments.Select(p => new PaymentResponseDto
                {
                    Id = p.Id,
                    Amount = p.Amount,
                    PaymentDate = p.PaymentDate,
                    PaymentMethod = p.PaymentMethod,
                    OrderId = p.OrderId

                }).ToList();
                return Ok(paymentDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            try
            {
                var payment = await _paymentService.GetByIdAsync(id);

                if (payment == null)
                {
                    return NotFound();
                }
                var paymentDto = new PaymentResponseDto
                {
                    Id = payment.Id,
                    Amount = payment.Amount,
                    PaymentDate = payment.PaymentDate,
                    PaymentMethod = payment.PaymentMethod,
                    OrderId = payment.OrderId
                };
                return Ok(paymentDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
