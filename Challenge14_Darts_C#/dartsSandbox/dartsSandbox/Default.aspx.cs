using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dartsSandbox
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //access the outside classes
            Dart dart = new Dart();// do I need this - or just game needs it?
            Game game = new Game();
            Players player = new Players();


            player.Gamers();
            string whoWon = player.Winner;

            resultLabel.Text += whoWon + "<br/><br/>";
        }
    }

    public class Game
    {
        public string PlayerName { get; set; }
        public int DartLandingScore { get; set; }
        public int GameScore { get; set; }
        public int MaxGameScore { get; set; }// s/be bool? AND be in Score class?
        public int ThrowsPerTurn { get; set; } // should this go in Score class?

        //access the outside class
        Dart dart = new Dart();


        //starts the game
        public void PlayGame()
        { RunningTotal(); }

        public int ThrowIt()
        {
            dart.Throw();
            return this.DartLandingScore = dart.DartLocation;
        }

        public int IsBonus()// this should have parts from static class
        {
            if (dart.DartInnerBullseye) this.DartLandingScore += 50;
            if (dart.DartOuterBullseye) this.DartLandingScore += 25;
            if (dart.DartInnerRing) this.DartLandingScore += DartLandingScore * 3;
            if (dart.DartOuterRing) this.DartLandingScore += DartLandingScore * 2;
            else this.DartLandingScore += 0;
            return DartLandingScore;
        }

        public int TrackThrow1()
        {
            int testThrow1 = ThrowIt();
            testThrow1 += IsBonus();
            return testThrow1;
        }

        public int TrackThrow2()
        { int testThrow2 = ThrowIt(); return testThrow2; }

        public int TrackThrow3()
        { int testThrow3 = ThrowIt(); return testThrow3; }

        public int ThrowTotal()
        {
            int throw1 = TrackThrow1();
            int throw2 = TrackThrow2();
            int throw3 = TrackThrow3();
            int throwTotal = throw1 + throw2 + throw3;
            return throwTotal;
        }

        public void RunningTotal()
        {
            int throwTotal = ThrowTotal();
            this.DartLandingScore = throwTotal;
            this.GameScore += this.DartLandingScore;
        }
    }

    public class Players
    {
        public string Winner { get; set; }


        Random coinflip = new Random();
        // to get the class to carry over - must be inside a void
        public void Gamers()
        {
            Game player1 = new Game();
            player1.PlayerName = "The Cat";
            player1.DartLandingScore = 0;
            player1.GameScore = coinflip.Next(0,21); // hack to counter (not) random tie issue


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









    public class Dart // working perfectly as a library in _final

    {
        public int DartLocation { get; set; }
        public bool DartOuterBullseye { get; set; }
        public bool DartInnerBullseye { get; set; }
        public bool DartOuterRing { get; set; }
        public bool DartInnerRing { get; set; }

        Random randomDart = new Random();


        public void Throw()
        {
            GetRandomDartLocation();
            IsBullseyeOrRing();
            //IsInnerRing();
        }

        public int GetRandomDartLocation()
        { return this.DartLocation = randomDart.Next(0, 21); }

        public void IsBullseyeOrRing()
        {
            if (this.DartLocation == 0)
                IsInnerBullseye();
            else IsRing();
        }

        public bool IsInnerBullseye()
        {
            int bullseyeType = randomDart.Next(1, 21);

            if (bullseyeType == 14) return this.DartInnerBullseye = true;
            else return this.DartOuterBullseye = true;
        }

        public bool IsRing()
        {
            int ringsType = randomDart.Next(1, 21);

            if (ringsType == 7) return this.DartInnerRing = true;
            if (ringsType == 16) return this.DartOuterRing = true;
            if (ringsType != 7 || ringsType != 16)
                this.DartInnerRing = false;
            return this.DartOuterRing = false;   // tested w/true to make sure it was reached
            // this solution seems awkward. But works beautifully.
            // even when inner ring !7 or !14 set to true, overrided when true.
        }
    }

}