using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Events.Model
{
    public class Reservering
    {
        public int ID { get; set; }
        public DateTime Datum { get; set; }
        public bool Ingechecked { get; set; }
        public bool Betaald { get; set; }

        public override string ToString()
        {
            return ID + " " + Datum.ToShortDateString();
        }
    }
}
