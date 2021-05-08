using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaulP_ClassesAssn03
{
    class DeckOfCards
    {
        public Cards[] deck;
        public Cards currentCard;

        public DeckOfCards()
        {
            currentCard = new Cards();
            deck = new Cards[52];
        }

        public string shuffle()
        {
            currentCard = Cards.
            return "";
        }

        public bool dealcard()
        {
            return true;
        }
    }
}
