using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Events.Database;
using _4Events.Model;

namespace _4Events.Logic
{
    public class ReserveringRepository
    {
        private IReserveringContext context;

        public ReserveringRepository(IReserveringContext context)
        {
            this.context = context;
        }


        public List<Reservering> GetAllMessages()
        {
            return context.GetAll();
        }
    }
}
