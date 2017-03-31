using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Events.Model
{
    public class Bericht
    {

        public int ID { get; set; }
        public byte[] Bestand { get; set; }
        public int? ReplyTo { get; set; } // Kan hier een bericht type van maken.
        public string Tags { get; set; }
        public string Tekst { get; set; }
        public int AccountID { get; set; } // Kan hier een account type van maken.
        public int AmountLikes { get; set; } = 0;

        public override string ToString()
        {
            return ID + " " + Tekst + " | Account:" + AccountID + "| Likes:" + AmountLikes;
        }
    }
}
