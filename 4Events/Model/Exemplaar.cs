using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Events.Model
{
    class Exemplaar
    {
        public int ExemplaarID { get; set; }
        public Product Product { get; set; }
        public int Aantal { get; set; }

        public override string ToString()
        {
            return Product.Naam + " Aantal: " + Aantal;
        }
    }
}
