using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Darts;


namespace CS_ASP_045_DartsChallenge_final
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //access the outside class
            Dart dart = new Dart();

            dart.Throw();

            // this would be prefaced with a player1, player2, eventually ...
            int baseScore = dart.DartLocation;
            bool innerBullseye = dart.DartInnerBullseye;
            bool outerBullseye = dart.DartOuterBullseye;
            bool innerRing = dart.DartInnerRing;
            bool outerRing = dart.DartOuterRing;


            //dart.DartBullseye == 1 ? true : false;


            resultLabel.Text += string.Format("The board location of the dart thrown is {0}."
                 + "<br/>  Was the inner Bullseye hit?: {1}."
                 + "<br/>  Was the outer Bullseye hit?: {2}."
                 + "<br/>  Was the inner Ring hit?: {3}."
                 + "<br/>  Was the outer Ring hit?: {4}."
                 + "<br/><br/><br/>"
                , baseScore, innerBullseye, outerBullseye, innerRing, outerRing);


        }
    }
}