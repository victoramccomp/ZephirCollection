using ZephirCollection.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ZephirCollection.Infra.Data.EntityConfig
{
    public class CardConfig : EntityTypeConfiguration<Card>
    {
        public CardConfig()
        {
            HasKey(k => k.CardId);

            Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(300);

            Property(p => p.CardNumber)
                .IsRequired()
                .HasMaxLength(300);

            HasRequired(p => p.CardType)
                .WithMany()
                .HasForeignKey(p => p.CardTypeId);

            HasRequired(p => p.Collection)
                .WithMany()
                .HasForeignKey(p => p.CollectionId);

            HasRequired(p => p.Rarity)
                .WithMany()
                .HasForeignKey(p => p.RarityId);

            Property(p => p.ImagePath)
                .IsRequired()
                .HasMaxLength(400);
        }
    }
}
