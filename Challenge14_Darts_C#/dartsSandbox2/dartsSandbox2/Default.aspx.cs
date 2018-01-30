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


class Dart // will need to be in library called "Darts"

    {
        public int DartLocation { get; set; }
        public bool DartOuterBullseye { get; set; }
        public bool DartInnerBullseye { get; set; }
        public bool DartOuterRing { get; set; }
        public bool DartInnerRing { get; set; }
        //public bool Bullseye { get; set; }


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
        }

            
    }


}