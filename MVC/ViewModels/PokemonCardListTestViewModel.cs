using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC.ViewModels
{
    public class PokemonCardListTestViewModel
    {
        [Key]
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