using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace ChallengeDarts
{
    public class Score
    {
        public static void ScoreDart(Player player, Dart dart)
        {
            int score = 0;

            if (dart.IsDouble) score = dart.Points * 2;
            else if (dart.IsTriple) score = dart.Points * 3;
            else score = dart.Points;

            if (dart.IsTriple && dart.Points == 0) score = 50;
            else if (dart.Points == 0) score = 25;

            player.Score += score;
        }
    }
}