using ZephirCollection.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ZephirCollection.Infra.Data.EntityConfig
{
    public class TrainerTypeConfig : EntityTypeConfiguration<TrainerType>
    {
        public TrainerTypeConfig()
        {
            HasKey(p => p.TrainerTypeId);

            Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
