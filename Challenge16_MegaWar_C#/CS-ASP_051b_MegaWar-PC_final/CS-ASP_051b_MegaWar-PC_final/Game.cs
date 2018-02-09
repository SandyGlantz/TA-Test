using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_ASP_051b_MegaWar_PC_final
{
    public class Game
    {
        private Player _player1;
        private Player _player2;
        //private List<Card> _bounty; // version 2

        public Game(string player1Name, string player2Name)
        {
            _player1 = new Player() { Name = player1Name };
            _player2 = new Player() { Name = player2Name };
            //_bounty = new List<Card>(); // version 2
        }

        public string Play()
        {
            Deck deck = new Deck();
            string result = "<br/>";
            //string result = "<br/><strong>Dealing cards ... from Game class Play()</strong>";
            result += deck.Deal(_player1, _player2);
            result += "<br/><br/><br/>_______________________________________________<br/><br/>";
            result += "<br/><br/><strong>With the cards dealt - it's time for the Battle Rounds:</strong><br/>";


            int round = 0;
            while (_player1.Cards.Count != 0 && _player2.Cards.Count != 0)
            {
                //Card player1Card = _player1.Cards.ElementAt(0);  //version1
                //Card player2Card = _player2.Cards.ElementAt(0);  //version1
                //Card player1Card = getCard(_player1);  // version2
                //Card player2Card = getCard(_player2);  // version2

                Battle battle = new Battle();
                result += battle.PerformBattle(_player1, _player2);

                // performEvaluation(_player1, _player2, player1Card, player2Card);//version2

                round++;
                if (round > 20)  // shorten for testing, final req is 20
                    break;


            }

            // Determine the winner
            result += determineWinner();
            return result;
        }

// Version 2
/*
        private Card getCard(Player player)
        {
            Card card = player.Cards.ElementAt(0);
            player.Cards.Remove(card);
            _bounty.Add(card);
            return card;
        }



        private void performEvaluation(Player player1, Player player2, Card card1, Card card2)
        {
            if (card1.CardValue() > card2.CardValue())
                player1.Cards.AddRange(_bounty);  // AddRange allows the passing in of the cards (vs. Add)
            else
                player2.Cards.AddRange(_bounty);

            _bounty.Clear();
        }

*/

        private string determineWinner()
        {
            string result = "";
            result += "<br/><br/>_______________________________________________<br/><br/>";
            result += "<br/><br><strong>And the result after a short 20 rounds:</strong>";

            if (_player1.Cards.Count > _player2.Cards.Count)
            { result += "<br/>Kitten wins!"; }

            else if (_player1.Cards.Count < _player2.Cards.Count)
            { result += "<br/>Puppy wins!"; }

            else result += "<br/>Kitten and Puppy decide to take naps and leave the game a draw.";

            result += "<br/></br><strong>Our game's final score:</strong>";
            result += "<br/>Kitten: " + _player1.Cards.Count 
                + " &nbsp&nbsp --vs-- &nbsp&nbsp Puppy: " + _player2.Cards.Count;
            result += "<br/><br/>";
            return result;
        }





    }  // class
} // namespace
