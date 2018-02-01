using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace CS_ASP_045_DartsChallenge_final
{
    public class Game
    {

        public string PlayerName { get; set; }
        public int DartLandingScore { get; set; }
        public int GameScore { get; set; }
        //public int MaxGameScore { get; set; }// s/be bool? AND be in Score class?
        //public int ThrowsPerTurn { get; set; } // should this go in Score class?


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


        public int TrackThrow1()
        {
            int testThrow1 = ThrowIt();
            testThrow1 += Score.IsBonus();
            return testThrow1;
        }


        public int TrackThrow2()
        {
            int testThrow2 = ThrowIt();
            testThrow2 += Score.IsBonus();
            return testThrow2;
        }


        public int TrackThrow3()
        {
            int testThrow3 = ThrowIt();
            testThrow3 += Score.IsBonus();
            return testThrow3;
        }


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
}