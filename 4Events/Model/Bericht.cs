using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Events.Model
{
    class Bericht
    {
        public int ID { get; set; }
        public byte[] Bestand { get; set; }
        public string Tags { get; set; }
        public string Tekst { get; set; }
    }
}
