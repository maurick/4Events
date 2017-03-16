using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _4Events.Model;
using System.Threading.Tasks;

namespace _4Events.ViewModel
{
    public class BeheerViewModel
    {
        /* Account */
        public Account Account { get; set; }
        public List<Account> AccountList { get; set; }
        public Account SelectedAccount { get; set; }
        /* Event */
        public List<Event> EventList { get; set; }
        public Event SelectedEvent { get; set; }
    }
}
