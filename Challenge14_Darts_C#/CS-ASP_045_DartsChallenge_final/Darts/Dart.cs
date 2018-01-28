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
        

        // start with properties
        // ?? would this be dart1, dart2, dart3  ?? -Nope- different game could have 2 dart
        // or --->  throw int
        //          bool bullInner  -- use a Ternary??
        //          bool bullOuter
        //          bool ringInner
        //          bool ringOuter
        //
        // example is public int Year (get/set)


        // constructor to instaniate
        public Dart()
        {
            // example is this.Make = 1980/ undefined
            // set defaults to false and 0
        }


        //then the methods ...

        //  Req: needs random generator outside Throw() method
        Random dartRandom = new Random();

        //  Req:  needs Throw() method
        //  random 0,21
        // if zero return bullseye
             // sgIdea/ use -1, 21 ... -1 = innerBullseye, 0 = outerBullseye
             // Nope ...  :-(
             // Req: 5% for inner Bullseye ... needs its own random


        // bool bullseye(inner, outer)
        //random 1,21 ... 14 = innner


        // bool rings (outer ring, inner ring)
        // this needs to exempt someone who hit 0/bullseye
        // 5% = random 1,21 ...  7 = inner True ...  14=outer True

    }
}
