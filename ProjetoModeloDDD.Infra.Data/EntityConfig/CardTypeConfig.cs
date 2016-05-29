using ZephirCollection.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ZephirCollection.Infra.Data.EntityConfig
{
    public class CardTypeConfig : EntityTypeConfiguration<CardType>
    {
        public CardTypeConfig()
        {
            HasKey(c => c.CardTypeId);

            Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
