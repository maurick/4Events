using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Events.Model;

namespace _4Events.Database
{
    public interface IReserveringRepository
    {
        List<Reservering> GetAllReserveringen();
        List<Reservering> GetReserveringenByEvent(int EventID);
        bool UpdateReservering(Reservering reservering);
        List<Locatie> GetAllLocaties();
        List<Plek> GetAllKampeerPlekByLocatie(Locatie locatie);
        int InsertReservering(Reservering reservering);
        bool InsertReserveringAccount(Reservering reservering, Account account);
    }
}
