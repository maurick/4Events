using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Events.Model;

namespace _4Events.Database
{
    /// <summary>
    /// Bevat alle databasecode voor het verhuur systeem.
    /// </summary>
    class VerhuurContext : IVerhuurRepository
    {
        public List<Verhuur> GetAllVerhuur()
        {
            throw new NotImplementedException();
        }
    }
}
