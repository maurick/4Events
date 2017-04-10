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
        public int EventID { get; set; }
        public int Aantalpersonen { get; set; }
        public DateTime BeginDatum { get; set; }
        public DateTime EindDatum { get; set; }
        public int Kampeerplaats { get; set; }

        public DateTime Datum { get; set; }
        public bool Ingechecked { get; set; }
        public bool Betaald { get; set; }
        public string MainAccountNaam { get; set; }

        public override string ToString()
        {
            return ID + " " + Datum.ToShortDateString() + " " + MainAccountNaam + " " + Betaald;
        }
    }
}
