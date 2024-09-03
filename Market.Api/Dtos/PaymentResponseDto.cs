using Maroc.Core.Enums;

namespace Market.Api.Dtos
{
    public class PaymentResponseDto
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public decimal Amount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
