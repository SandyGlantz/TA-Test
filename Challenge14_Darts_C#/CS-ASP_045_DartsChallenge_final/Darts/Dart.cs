using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Darts
{
    public class Dart

    {
        public int DartLocation { get; set; }
        public bool DartOuterBullseye { get; set; }
        public bool DartInnerBullseye { get; set; }
        public bool DartOuterRing { get; set; }
        public bool DartInnerRing { get; set; }
 
        Random randomDart = new Random();



        public void Throw()
        {   GetRandomDartLocation();
            IsBullseyeOrRing();     }


        public int GetRandomDartLocation()
        { return this.DartLocation = randomDart.Next(0,21); }




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
            // even when inner ring !7 or !14 set to true, overridden when true.
        }


    }
}
