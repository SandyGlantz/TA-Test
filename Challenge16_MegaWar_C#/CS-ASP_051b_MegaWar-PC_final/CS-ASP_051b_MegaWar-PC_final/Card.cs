using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_ASP_051b_MegaWar_PC_final
{
    public class Card
    {
        public string Suit { get; set; }
        public string Kind { get; set; }

        public int CardValue()  // change here to play with suit symbols/Pc (symbols don't work on Mac)
        {
            int value = 0;

            switch (this.Kind) 
            {
                case "Jack":
                    value = 11;
                    break;
                case "Queen":
                    value = 12;
                    break;
                case "King":
                    value = 13;
                    break;
                case "Ace":
                    value = 14;
                    break;
                default:
                    value = int.Parse(this.Kind);
                    break;
            }
            return value;
        }

    }
}