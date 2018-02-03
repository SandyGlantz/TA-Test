using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace CS_ASP_045_DartsChallenge_final
{
    public static class Score
    {

        public static int IsBonus()
        {
            Game game = new Game();
            Dart dart = new Dart();

            if (dart.DartInnerBullseye) game.DartLandingScore += 50;
            if (dart.DartOuterBullseye) game.DartLandingScore += 25;
            if (dart.DartInnerRing) game.DartLandingScore += game.DartLandingScore * 3;
            if (dart.DartOuterRing) game.DartLandingScore += game.DartLandingScore * 2;
            else game.DartLandingScore += 0;
            return game.DartLandingScore;
        }

    }
}