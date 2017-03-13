using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Events.Model
{
    public class Account
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        public string Plaats { get; set; }
        public string Straat { get; set; }
        public int Huisnummer { get; set; }
        public string HuisnummerToevoeging { get; set; }
        public string Postcode { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return ID + " " + Naam + " " + Email;
        }
    }
}
