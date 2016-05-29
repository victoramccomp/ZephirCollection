using ZephirCollection.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ZephirCollection.Infra.Data.EntityConfig
{
    public class CollectionConfig : EntityTypeConfiguration<Collection>
    {
        public CollectionConfig()
        {
            HasKey(c => c.CollectionId);

            Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(150);

            HasRequired(p => p.Series)
                .WithMany()
                .HasForeignKey(p => p.SeriesId);

            Property(p => p.CSSClassSymbol)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.CollectionCards)
                .IsRequired();

            Property(p => p.SecretCards)
                .IsRequired();

            Property(p => p.ReleaseDate)
                .IsRequired();
        }
    }
}
