using ZephirCollection.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ZephirCollection.Infra.Data.EntityConfig
{
    public class EvolutionStageConfig : EntityTypeConfiguration<EvolutionStage>
    {
        public EvolutionStageConfig ()
	    {
            HasKey(p => p.EvolutionStageId);

            Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(60);
	    }
    }
}
