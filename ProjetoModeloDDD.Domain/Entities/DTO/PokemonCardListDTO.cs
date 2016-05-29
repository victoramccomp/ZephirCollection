using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZephirCollection.Domain.Entities.DTO
{
    [Serializable]
    public class PokemonCardListDTO
    {
        public int CardId { get; set; }

        public string CardNumber { get; set; }

        public string CardDescription { get; set; }

        public string CardTypeDescription { get; set; }

        public string CollectionDescription { get; set; }

        public int CollectionCards { get; set; }

        public string SeriesDescription { get; set; }

        public string RarityAbbreviation { get; set; }

        public string ImagePath { get; set; }
    }
}
