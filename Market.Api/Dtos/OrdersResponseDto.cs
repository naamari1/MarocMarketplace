using Maroc.Core.Enums;

namespace Market.Api.Dtos
{
    public class OrdersResponseDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public int TotalItems { get; set; }
    }
}
