using ZephirCollection.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ZephirCollection.Infra.Data.EntityConfig
{
    public class TrainerCardConfig : EntityTypeConfiguration<TrainerCard>
    {
        public TrainerCardConfig()
        {
            HasKey(p => p.TrainerCardId);

            HasRequired(p => p.Card)
                .WithMany()
                .HasForeignKey(p => p.CardId);

            HasRequired(p => p.TrainerType)
                .WithMany()
                .HasForeignKey(p => p.TrainerTypeId);
        }
    }
}
