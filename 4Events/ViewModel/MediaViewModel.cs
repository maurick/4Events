using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Events.Model;

namespace _4Events.ViewModel
{
    class MediaViewModel
    {
        public List<Bericht> ListBerichten { get; set; }
        public Account Account { get; set; }
        public Bericht SelectedBericht { get; set; }
    }
}
