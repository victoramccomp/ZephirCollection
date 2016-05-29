using ZephirCollection.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ZephirCollection.Infra.Data.EntityConfig
{
    public class RarityConfig : EntityTypeConfiguration<Rarity>
    {
        public RarityConfig()
        {
            HasKey(p => p.RarityId);

            Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Abbreviation)
                .IsRequired()
                .HasMaxLength(10);

            Property(p => p.CSSClassImage)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
