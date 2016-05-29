using ZephirCollection.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ZephirCollection.Infra.Data.EntityConfig
{
    public class PokemonTypeConfig : EntityTypeConfiguration<PokemonType>
    {
        public PokemonTypeConfig()
        {
            HasKey(p => p.PokemonTypeId);

            Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
