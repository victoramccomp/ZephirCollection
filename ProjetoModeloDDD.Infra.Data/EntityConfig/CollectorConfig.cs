using ZephirCollection.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ZephirCollection.Infra.Data.EntityConfig
{
    public class CollectorConfig : EntityTypeConfiguration<Collector>
    {
        public CollectorConfig()
        {
            HasKey(p => p.CollectorId);

            Property(p => p.Quantity)
                .IsRequired();

            Property(p => p.QuantityReverseFoil)
                .IsRequired();

            HasRequired(p => p.Card)
                .WithMany()
                .HasForeignKey(p => p.CardId);
        }
    }
}
