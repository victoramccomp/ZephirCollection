using System;
using System.Collections.Generic;

namespace ZephirCollection.Domain.Entities
{
    public class Card
    {
        public int CardId { get; set; }

        public string Description { get; set; }

        public string CardNumber { get; set; }

        public int CardTypeId { get; set; }
        public virtual CardType CardType { get; set; }

        public int CollectionId { get; set; }
        public virtual Collection Collection { get; set; }

        public int RarityId { get; set; }
        public virtual Rarity Rarity { get; set; }

        public string ImagePath { get; set; }
    }
}
