
namespace ZephirCollection.Domain.Entities
{
    public class EnergyCard
    {
        public int EnergyCardId { get; set; }

        public int CardId { get; set; }
        public virtual Card Card { get; set; }

        public bool SpecialEnergy { get; set; }
    }
}
