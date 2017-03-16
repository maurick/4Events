using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Events.Model;

namespace _4Events.ViewModel
{
    public class EventBeheerViewModel
    {
        public Event SelectedEvent { get; set; }
        public List<Event> EventList { get; set; }
    }
}
