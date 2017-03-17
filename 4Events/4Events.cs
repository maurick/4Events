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
        public BeheerRepository BeheerRepository { get; set; }
        public MediaRepository MediaRepository { get; set; }
        public ReserveringRepository ReserveringRepository { get; set; }
        public VerhuurRepository VerhuurRepository { get; set; }
    }
}
