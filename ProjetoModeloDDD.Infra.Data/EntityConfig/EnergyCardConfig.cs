using ZephirCollection.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ZephirCollection.Infra.Data.EntityConfig
{
    public class EnergyCardConfig : EntityTypeConfiguration<EnergyCard>
    {
        public EnergyCardConfig ()
	    {
            HasKey(p => p.EnergyCardId);

                HasRequired(p => p.Card)
                    .WithMany()
                    .HasForeignKey(p => p.CardId);

                Property(p => p.SpecialEnergy)
                    .IsRequired();
	    }        
    }
}
