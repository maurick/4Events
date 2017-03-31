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
        List<Locatie> GetAllLocaties();
    }
}
