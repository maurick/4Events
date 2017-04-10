using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Events.Model
{
    public class Categorie
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        public int? MainCategorieID { get; set; }

        public override string ToString()
        {
            return Naam;
        }
    }
}
