
namespace ZephirCollection.Domain.Entities
{
    public class TrainerCard
    {
        public int TrainerCardId { get; set; }

        public int CardId { get; set; }
        public virtual Card Card { get; set; }

        public int TrainerTypeId { get; set; }
        public virtual TrainerType TrainerType { get; set; }
    }
}
