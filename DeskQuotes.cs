using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Roper
{
    class DeskQuotes
    {
        public List<DeskQuote> quotes;

        public DeskQuotes()
        {
            quotes = new List<DeskQuote>();
        }

        public void Add(DeskQuote quote)
        {
            quotes.Add(quote);
        }

        public int GetCount()
        {
            return quotes.Count;
        }

        public DeskQuote GetLatest()
        {
            return quotes[quotes.Count - 1];
        }
    }
}
