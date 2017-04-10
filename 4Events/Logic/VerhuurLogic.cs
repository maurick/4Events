using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Events.Database;
using _4Events.Model;

namespace _4Events.Logic
{
    class VerhuurLogic
    {
        private IVerhuurRepository repository = new VerhuurContext();

        public VerhuurLogic(IVerhuurRepository repository)
        {
            this.repository = repository;
        }

        public List<Exemplaar> GetExemplaren(int amount)
        {
            return repository.GetExemplaren(amount);
        }

        public bool InsertVerhuur(Verhuur verhuur)
        {
            return repository.InsertVerhuur(verhuur);
        }

        public bool DeleteVerhuurById(int id, int exemplaarid)
        {
            return repository.DeleteVerhuurById(id, exemplaarid);
        }

        public List<Verhuur> GetVerhuurByAccount(Account account)
        {
            return repository.GetVerhuurByAccount(account);
        }
    }
}
