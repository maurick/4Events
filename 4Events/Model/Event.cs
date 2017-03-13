using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Events.Model
{
    class Event
    {
        public int ID { get; set; }
        public int MaxBezoekers { get; set; }
        public int LocatieID { get; set; }
        public DateTime Datum { get; set; }
    }
}
