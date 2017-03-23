using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Events.Model;

namespace _4Events.Database
{
    public interface IMediaContext
    {
        List<Bericht> GetBerichten(int aantal);
        List<Bericht> GetReacties();
        bool InsertBericht(Bericht bericht);
        bool DeleteBericht(int id);
    }
}
