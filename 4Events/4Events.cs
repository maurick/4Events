using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Events.Logic;

namespace _4Events
{
    public class _4Events
    {
        public Beheer BeheerRepository { get; set; }
        public Media MediaRepository { get; set; }
        public ReserveringLogic ReserveringRepository { get; set; }
        public VerhuurLogic VerhuurRepository { get; set; }
    }
}
