namespace Maroc.Core.Entities
{
    public class Inventory
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public int CurrentStock { get; set; }
        public int RecordLevel { get; set; }
    }
}
