using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using _4Events.Model;
using _4Events.Database;
using System.Drawing;

namespace _4Events.Logic
{
    public class Media
    {
        private IMediaRepository repository = new MediaContext();

        public Media(IMediaRepository repository)
        {
            this.repository = repository;
        }

        public List<Bericht> GetBerichten(int aantal)
        {
            return repository.GetBerichten(aantal);
        }

        public List<Bericht> SearchBerichten(string keyword)
        {
            List<Bericht> listBericht = repository.GetBerichten(999);
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

        public bool LikeBericht(Bericht bericht, Account account)
        {
            return repository.InsertLike(bericht, account);
        }

        public bool RaporteerBericht(Bericht bericht, Account account)
        {
            // Als er te veel reports zijn delete/hide bericht

            return repository.InsertReport(bericht, account);
        }

        public bool InsertBericht(Bericht bericht)
        {
            if(Search(bericht.Tekst, "bad words")) // TODO bad word list
            {
                return false;
            }

            return repository.InsertBericht(bericht);
        }

        private bool Search(string input, string keyword)
        {
            string pattern = keyword;
            bool isMatched;

            isMatched = Regex.IsMatch(input, pattern);

            return isMatched;
        }

        public Image ConvertByteArrayToImage(byte[] bytes)
        {
            Image result;

            try
            {
                result = (Bitmap)((new ImageConverter()).ConvertFrom(bytes));
            }
            catch (NotSupportedException)
            {
                throw;
            }


            return result;
        }
    }
}
