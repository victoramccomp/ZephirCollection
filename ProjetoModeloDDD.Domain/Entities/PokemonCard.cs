
namespace ZephirCollection.Domain.Entities
{
    public class PokemonCard
    {
        public int PokemonCardId { get; set; }

        public int CardId { get; set; }
        public virtual Card Card { get; set; }

        public int HealthPoints { get; set; }

        public int EvolutionStageId { get; set; }
        public virtual EvolutionStage EvolutionStage { get; set; }

        public int PokemonTypeId { get; set; }
        public virtual PokemonType PokemonType { get; set; }
    }
}
