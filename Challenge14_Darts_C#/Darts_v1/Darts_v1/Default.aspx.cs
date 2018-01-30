using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Darts_v1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        //events work different from a standard method for passing vars
        {
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            int player1score = 0;
            int player2score = 0;
            int totalScore = 0;

            player1score = player1score + totalScore;
            resultLabel.Text += string.Format("OK button totalScore: {0} <br /><br />", player1score);
        }




        Random randomScore = new Random();



        public void Score()
        {
            int totalScore;
            int dartThrow = randomScore.Next(0, 21);
            //resultLabel.Text += string.Format("Score() dartThrow is: {0} <br />", dartThrow);

            if (dartThrow != 0)
            {
                int rings = randomScore.Next(1, 21);
                //resultLabel.Text += string.Format("Score() rings is: {0} <br />", rings);
                if (rings == 7) totalScore = dartThrow * 3;
                if (rings == 14) totalScore = dartThrow * 2;
                else totalScore = dartThrow;
            }

            else
            {
                int bullseye = randomScore.Next(1, 21);
                //resultLabel.Text += string.Format("Score() bullseye is: {0} <br />", bullseye);
                if (bullseye == 16) totalScore = 50;
                else totalScore = 25;
            }
        }
            


        
    


        public int Bullseye(int dartThrow)
        {
            int inOrOutBullseye = randomScore.Next(1, 21);

            if (inOrOutBullseye == 14) dartThrow = 50;
            else dartThrow = 25;
            return dartThrow;
        }


        public int Rings(int dartThrow)
        {
            int inOrOutRing = randomScore.Next(1, 21);
            int ringPts = 0;

            if (inOrOutRing == 7) ringPts = dartThrow * 3;
            if (inOrOutRing == 16) ringPts = dartThrow * 2;
            else ringPts = dartThrow;
            return dartThrow;

        }



         public int Score1()
        {
            int dartThrow = randomScore.Next(0, 21);

            if (dartThrow != 0)
            {
                dartThrow = Rings(dartThrow);

            }
            else dartThrow = Bullseye(dartThrow);
            return dartThrow;

        }

}
}        
