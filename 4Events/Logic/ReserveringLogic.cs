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
        Reservering reserveringsmodel = new Reservering();

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

        public List<Locatie> GetAllLocaties()
        {
            return repository.GetAllLocaties();
        }
        public void Reserveer(int kampeerplaats, int aantalpersonen, DateTime begindatum, DateTime einddatum)
        {
            reserveringsmodel.Kampeerplaats = kampeerplaats;
        }
    }
}
