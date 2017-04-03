using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Configuration;
using _4Events.Model;
using _4Events.Database;
using System.Drawing;

namespace _4Events.Logic
{
    /// <summary>
    /// Het media sharing systeem.
    /// </summary>
    public class Media
    {
        private IMediaRepository repository = new MediaContext();

        public Media(IMediaRepository repository)
        {
            this.repository = repository;
        }

        public List<Bericht> GetBerichten(int aantal)
        {
            return repository.GetBerichten(aantal); // Beter om een bepaalde range te implementeren (bericht 5 tot 10).
        }

        /// <summary>
        /// Zoekt alle berichten in de database of een bepaalde string erin voorkomt.
        /// </summary>
        /// <param name="keyword">De te zoeken string</param>
        /// <param name="amount">Het totaal aantal berichten</param>
        /// <returns>Een list berichten</returns>
        public List<Bericht> SearchBerichten(string keyword, int amount)
        {
            List<Bericht> listBericht = repository.GetBerichten(amount); 
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
            if (repository.GetReportAmount(bericht) > 5)
            {
                repository.DeleteBericht(bericht.ID); // Beter om het bericht onzichtbaar te maken.
            }

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
