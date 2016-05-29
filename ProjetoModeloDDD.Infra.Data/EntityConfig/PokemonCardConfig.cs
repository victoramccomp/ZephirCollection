using ZephirCollection.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ZephirCollection.Infra.Data.EntityConfig
{
    public class PokemonCardConfig : EntityTypeConfiguration<PokemonCard>
    {
        public PokemonCardConfig()
        {
            HasKey(p => p.PokemonCardId);

            HasRequired(p => p.Card)
                .WithMany()
                .HasForeignKey(p => p.CardId);

            HasRequired(p => p.EvolutionStage)
                .WithMany()
                .HasForeignKey(p => p.EvolutionStageId);

            HasRequired(p => p.PokemonType)
                .WithMany()
                .HasForeignKey(p => p.PokemonTypeId);

            Property(p => p.HealthPoints)
                .IsRequired();
        }
    }
}
