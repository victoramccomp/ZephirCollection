using System;

namespace ZephirCollection.Domain.Entities
{
    public class Collection
    {
        public int CollectionId { get; set; }

        public string Description { get; set; }

        public int SeriesId { get; set; }
        public virtual Series Series { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int CollectionCards { get; set; }

        public int SecretCards { get; set; }

        public string CSSClassSymbol { get; set; }
    }
}
