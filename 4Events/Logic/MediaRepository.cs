using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public List<Bericht> SearchBerichten(string keyword)
        {
            List<Bericht> listBericht = context.GetBerichten(999);
            List<Bericht> output = new List<Bericht>();

            foreach (var bericht in listBericht)
            {
                if(Search(bericht.Tekst, keyword))
                {
                    output.Add(bericht);
                }
            }

            return output;
        }

        public bool InsertBericht(Bericht bericht)
        {
            if(Search(bericht.Tekst, "bad words")) // TODO bad word list
            {
                return false;
            }

            return context.InsertBericht(bericht);
        }

        private bool Search(string input, string keyword)
        {
            string pattern = keyword;
            bool isMatched;

            isMatched = Regex.IsMatch(input, pattern);

            return isMatched;
        }
    }
}
