using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
        // sg/ single job determine where dart lands

        // do I need a Player property?
        public string Player { get; set; }
        public int BaseScore { get; set; }

        //  -- use a Ternary??
        public bool InnerBullseye { get; set; }
        public bool OuterBullseye { get; set; }
        public bool InnerRing { get; set; }
        public bool OuterRing { get; set; }


        // constructor to instaniate with base value
        public Dart()
        {
            this.Player = "";
            this.BaseScore = -1;
            this.InnerBullseye = false;
            this.OuterBullseye = false;
            this.InnerRing = false;
            this.OuterRing = false;
           
        }

        Random randomDart = new Random();

        public int Throw(out int baseScore)
        {
            // add 1 into number to account for -1 instantiation
            baseScore = randomDart.Next(0, 21);

            if (baseScore == 0)
            {   InOutBullseye();  }
            else
            {   InOutRing();      }
            
            return baseScore+1;
        }


        public bool InOutBullseye()
        {
            int bullseye = randomDart.Next(1, 21);
            // Req: 5% for inner Bullseye
            if (bullseye == 7)
                return InnerBullseye = true;
            else
                return OuterBullseye = true;
        }

         
        public bool InOutRing()
        {
            int rings = randomDart.Next(1, 21);
            // Req: 5% for each ring
            if (rings == 7)
                return InnerRing = true;
            if (rings == 14)
                return OuterRing = true;
            else return false;
        }



        // need a way to return player score and keep going until sxore met.
    }
}
