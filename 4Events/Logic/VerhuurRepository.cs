using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Events.Database;
using _4Events.Model;

namespace _4Events.Logic
{
    public class VerhuurRepository
    {
        private IVerhuurContext context;

        public VerhuurRepository(IVerhuurContext context)
        {
            this.context = context;
        }


        public List<Verhuur> GetAllMessages()
        {
            return context.GetAllVerhuur();
        }
    }
}
