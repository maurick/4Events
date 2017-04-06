using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Events.Model
{
    class Verhuur
    {
        public Account Account { get; set; }
        public Exemplaar Exemplaar { get; set; }
        public DateTime DatumBegin { get; set; }
        public DateTime DatumEind { get; set; }
    }
}
