using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Events.Model;

namespace _4Events.ViewModel
{
    public class MainViewModel
    {
        public List<Event> EventList { get; set; }
        public Account Account { get; set; }
    }
}
