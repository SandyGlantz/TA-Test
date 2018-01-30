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
            Dart player1 = new Dart();
            player1.PlayerName = "Cute Kittens";
            player1.BaseScore = -1; // should this be -1 to avoid Bullseye issues?
            player1.InnerBullseye = false;
            player1.OuterBullseye = false;
            player1.InnerRing = false;
            player1.OuterRing = false;

            Dart player2 = new Dart();
            player2.PlayerName = "Crazy Puppies";
            player2.BaseScore = -1; // should this be -1 to avoid Bullseye issues?
            player2.InnerBullseye = false;
            player2.OuterBullseye = false;
            player2.InnerRing = false;
            player2.OuterRing = false;

            //int round1 = player1.Score();

            resultLabel.Text = String.Format("Name: {0}, Base Score: {1}, Bullseye?: {2}, {3}",
                player1, player1.BaseScore, player1.InnerBullseye, player1.OuterBullseye);



        }




    public class Dart
        {
            public string PlayerName { get; set; }
            public int BaseScore { get; set; }
            public bool InnerBullseye { get; set; }
            public bool OuterBullseye { get; set; }
            public bool InnerRing { get; set; }
            public bool OuterRing { get; set; }
            public bool NoRing { get; set; }

            Random randomDart = new Random();

            public int RunTheGame()
            {
                Throw();
                int a = 1;
                return a;
            }

            public int Throw()
            {  
                int boardLocation = randomDart.Next(0, 21);
                int baseScore = boardLocation;
                if (boardLocation != 0)     InOutRing(); 
                else                        InOutBullseye();
                return baseScore;
            }


            public bool InOutBullseye()
            {   // Req: 5% for inner Bullseye
                int bullseye = randomDart.Next(1, 21);

                bool innerBullseye = false;
                bool outerBullseye = false;
                
                if (bullseye == 7)  return innerBullseye = true;
                else                return outerBullseye = true;        }


            public bool InOutRing()
            {   // Req: 5% for each ring
                int rings = randomDart.Next(1, 21);

                bool innerRing = false;
                bool outerRing = false;
                bool noRing = false;

                if (rings == 7) return innerRing = true;
                if (rings == 14) return outerRing = true;
                else return noRing = true;
            }


            public void Game(int baseScore)
            {   // bringing in basescore means it can't be a static 
                int outerBullseyePts = 25;
                int innerBullseyePts = 50;
                int outerRingPts = baseScore * 2;
                int innerRingPts = baseScore * 3;

                

            }


            public void Score(int baseScore, bool innerBullseye, bool outerBullseye,
                bool innerRing, bool outerRing, int outerBullseyePts,
                int innerBullseyePts, int outerRingPts, int innerRingPts)
            {
                //Game game = new Game(); ... use this when Game is a class

                int totalScore = baseScore;

                if (baseScore == 0 && innerBullseye == true) totalScore = innerBullseyePts;
                else if (baseScore == 0 && outerBullseye == true) totalScore = outerBullseyePts;

                else if (outerRing == true) totalScore = baseScore * outerRingPts;
                else if (innerRing == true) totalScore = baseScore * innerRingPts;

                else totalScore = baseScore;

             

               






            }

        }
 




}
    
}