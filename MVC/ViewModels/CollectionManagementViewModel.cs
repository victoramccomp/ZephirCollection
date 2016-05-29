using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.ViewModels
{
    [Serializable]
    public class CollectionManagementViewModel
    {
        public string CollectionDescription { get; set; }
        public string CardNumber { get; set; }
        public string CardDescription { get; set; }
        public string RarityAbbreviation { get; set; }
        public bool IsInCollection { get; set; }
    }
}
