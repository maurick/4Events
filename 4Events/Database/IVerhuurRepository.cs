using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Events.Model;

namespace _4Events.Database
{
    interface IVerhuurRepository
    {
        List<Verhuur> GetAllVerhuur();
        List<Exemplaar> GetExemplaren(int amount);
        bool InsertVerhuur(Verhuur verhuur);
    }
}
