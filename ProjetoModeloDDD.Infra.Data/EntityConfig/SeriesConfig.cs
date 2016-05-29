using ZephirCollection.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ZephirCollection.Infra.Data.EntityConfig
{
    public class SeriesConfig : EntityTypeConfiguration<Series>
    {
        public SeriesConfig()
        {
            HasKey(p => p.SeriesId);

            Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
