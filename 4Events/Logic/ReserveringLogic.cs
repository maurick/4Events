using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Events.Database;
using _4Events.Model;

namespace _4Events.Logic
{
    public class ReserveringLogic
    {
        private IReserveringRepository repository = new ReserveringContext();


        public List<Model.Reservering> GetAllReserveringen()
        {
            return repository.GetAllReserveringen();
        }

        public List<Locatie> GetAllLocaties()
        {
            return repository.GetAllLocaties();
        }
    }
}
