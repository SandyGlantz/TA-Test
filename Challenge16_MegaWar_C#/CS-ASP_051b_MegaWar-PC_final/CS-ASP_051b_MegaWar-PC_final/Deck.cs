using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace CS_ASP_051b_MegaWar_PC_final
{
    public class Deck
    {
        // switch this to public to test the deck is accurate (see comments on Default)
        private List<Card> _deck;

        private Random _random;
        private StringBuilder _sb;



        public Deck()
        {
            _deck = new List<Card>();
            _random = new Random(); // why is this here?
            _sb = new StringBuilder(); // ditto - why not above, or 


            // if changing this to include PC symbol (no Mac)
            // ALSO CHANGE Card class in the parse part (CardValue())
            string[] suits = new string[] { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] kinds = new string[] 
                { "2","3","4","5","6","7","8","9","10","Jack","Queen","King","Ace" };

            foreach (var suit in suits)
            {
                foreach (var kind in kinds)
                {    _deck.Add(new Card() { Suit = suit, Kind = kind });    }
            }
        }



        public string Deal(Player player1, Player player2)
        {
            while (_deck.Count > 0)
            {
                dealCard(player1);
                dealCard(player2);
            }
            return _sb.ToString(); // would this work too:   return _sb;
        }


        private void dealCard(Player player)
        {
            // deal a random card (shuffled)
            Card card = _deck.ElementAt(_random.Next(_deck.Count));
            player.Cards.Add(card);
            _deck.Remove(card);

            // This is the formatting to show the rounds of the starting deal
            _sb.Append("<br/>");
            _sb.Append(player.Name);
            _sb.Append(" is dealt the ");
            _sb.Append(card.Kind);
            _sb.Append(" of ");
            _sb.Append(card.Suit);
        }







    }
}