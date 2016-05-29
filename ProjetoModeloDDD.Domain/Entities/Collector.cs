
namespace ZephirCollection.Domain.Entities
{
    public class Collector
    {
        public int CollectorId { get; set; }

        public int QuantityReverseFoil { get; set; }

        public int Quantity { get; set; }

        public int CardId { get; set; }
        public virtual Card Card { get; set; }
    }
}
