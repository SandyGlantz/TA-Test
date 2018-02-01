using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace CS_ASP_045_DartsChallenge_final
{
    public class Players
    {
        public string Winner { get; set; }



        // hack for getting random results
        Random coinflip = new Random();


        public void Gamers()
        {
            Game player1 = new Game();
            player1.PlayerName = "The Cat";
            player1.DartLandingScore = 0;
            player1.GameScore = coinflip.Next(0, 21); // hack to counter (not) random tie issue


            Game player2 = new Game();
            player2.PlayerName = "The Dog";
            player2.DartLandingScore = 0;
            player2.GameScore = coinflip.Next(0, 21); // hack to counter (not) random tie issue



            while (player1.GameScore < 301 || player2.GameScore < 301)
            {
                player1.RunningTotal();
                player2.RunningTotal();
            }

            FinalScore(player1, player2);

        }


        public string FinalScore(Game gamerA, Game gamerB)
        {
            if (gamerA.GameScore > gamerB.GameScore)
            {
                string Winner = string.Format("{0} wins with {1} points.<br/>" +
                  "{2} lost with {3} points.<br/><br/><br/>"
                  , gamerA.PlayerName, gamerA.GameScore, gamerB.PlayerName, gamerB.GameScore);
                return this.Winner = Winner;
            }

            if (gamerA.GameScore < gamerB.GameScore)
            {
                string Winner = string.Format("{0} wins with {1} points.<br/>" +
                  "{2} lost with {3} points.<br/><br/><br/>"
                  , gamerB.PlayerName, gamerB.GameScore, gamerA.PlayerName, gamerA.GameScore);
                return this.Winner = Winner;
            }
            else
            {
                string Winner = string.Format("It's a tie ... or something went wrong ...<br>" +
                  "{0} comes in with {1} points.<br/>" +
                    "{2} comes in with {3} points.<br/><br/><br/>"
                    , gamerA.PlayerName, gamerA.GameScore, gamerB.PlayerName, gamerB.GameScore);
                return this.Winner = Winner;
            }

        }
    }
}

