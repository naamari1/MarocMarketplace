namespace Market.Api.Dtos
{
    public class OrdersDetailResponseDto
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
    }
}
