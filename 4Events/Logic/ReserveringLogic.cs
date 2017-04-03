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

        public ReserveringLogic(IReserveringRepository repository)
        {
            this.repository = repository;
        }

        public List<Model.Reservering> GetAllReserveringen()
        {
            return repository.GetAllReserveringen();
        }

        public List<Model.Reservering> GetReserveringenByEvent(int EventID)
        {
            return repository.GetReserveringenByEvent(EventID);
        }

        public bool UpdateReservering(Reservering reservering)
        {
            return repository.UpdateReservering(reservering);
        }

        public List<Locatie> GetAllLocaties()
        {
            return repository.GetAllLocaties();
        }
    }
}
