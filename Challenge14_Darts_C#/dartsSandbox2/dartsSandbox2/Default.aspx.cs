using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dartsSandbox2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //access the outside classes
            Dart dart = new Dart();

            Game game = new Game();




            game.PlayGame();
            int roundTotal = game.DartLandingScore;
            int thrownTotal = game.GameScore;


            resultLabel.Text += string.Format(
                "game.GameScore is: {0}<br/>.game.DartLandingScore is {1}.<br/>"
                //+ "Throw 2 total is {2}<br/>"
                + "<br/><br/><br/>", 
                thrownTotal, roundTotal);


            dart.Throw(); // should this be in Game class?

            // this would be prefaced with a player1, player2, eventually ...
            int baseScore = dart.DartLocation;
            bool innerBullseye = dart.DartInnerBullseye;
            bool outerBullseye = dart.DartOuterBullseye;
            bool innerRing = dart.DartInnerRing;
            bool outerRing = dart.DartOuterRing;


            resultLabel.Text += string.Format("The board location of the dart thrown is {0}."
                 + "<br/>  Was the inner Bullseye hit?: {1}." 
                 + "<br/>  Was the outer Bullseye hit?: {2}." 
                 + "<br/>  Was the inner Ring hit?: {3}." 
                 + "<br/>  Was the outer Ring hit?: {4}." 
                 + "<br/><br/><br/>"
                , baseScore, innerBullseye, outerBullseye, innerRing, outerRing);
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
        {   //while (this.GameScore < 300)  //while (score.MaxGameScore)
            RunningTotal();
        }

        //int throw1score = ThrowTest();
        //int throwsscore;



        public int ThrowIt()
        {   dart.Throw();
            return this.DartLandingScore = dart.DartLocation;   }

        public int TrackThrow1()
        {   int testThrow1 = ThrowIt(); return testThrow1;}

        public int TrackThrow2()
        {   int testThrow2 = ThrowIt(); return testThrow2;  }

        public int TrackThrow3()
        {   int testThrow3 = ThrowIt(); return testThrow3;      }

        public int ThrowTotal()
        {
            int throw1 = TrackThrow1();
            int throw2 = TrackThrow2();
            int throw3 = TrackThrow3();
            int throwTotal = throw1 + throw2 + throw3;
            return throwTotal;
        }

        public void RunningTotal ()
        {
            int throwTotal = ThrowTotal();
            this.DartLandingScore = throwTotal;
            this.GameScore += this.DartLandingScore;
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
        {   return this.DartLocation = randomDart.Next(0, 21);  }

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