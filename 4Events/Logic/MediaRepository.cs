using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Events.Model;
using _4Events.Database;
namespace _4Events.Logic
{
    public class MediaRepository
    {
        private IMediaContext context;

        public MediaRepository(IMediaContext context)
        {
            this.context = context;
        }

        public List<Bericht> GetBerichten(int aantal)
        {
            return context.GetBerichten(aantal);
        }

        public bool InsertBericht(Bericht bericht)
        {
            return context.InsertBericht(bericht);
        }
    }
}
