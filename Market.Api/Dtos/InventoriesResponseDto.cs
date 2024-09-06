namespace Market.Api.Dtos
{
    public class InventoriesResponseDto
    {
        public Guid Id { get; set; }
        public int CurrentStock { get; set; }
        public int RecordLevel { get; set; }
    }
}
