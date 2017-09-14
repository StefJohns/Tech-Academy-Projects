using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace ChallengeDarts
{
    public class Game
    {
        private Player playerOne;
        private Player playerTwo;
        private Random _random;

        public Game(string plyrOneName, string plyrTwoName)
        {
            playerOne = new Player();
            playerTwo = new Player();

            playerOne.PlayerName = plyrOneName;
            playerTwo.PlayerName = plyrTwoName;
            _random = new Random();
        }

        //now we need to make a match where each player has a round.
        public string PlayMatch()
        {
            while (playerOne.Score < 300 && playerTwo.Score < 300)
            {
                PlayerRound(playerOne);
                PlayerRound(playerTwo);
            }
            return RoundResults();
        }

        private string RoundResults()
        {
            string result = String.Format("{0} Score: {1}<br/>{2} Score: {3}", playerOne.PlayerName, playerOne.Score, playerTwo.PlayerName, playerTwo.Score);
            return result += "<br/>The Winner: " + (playerOne.Score > playerTwo.Score ? playerOne.PlayerName : playerTwo.PlayerName);
        }

        //further defining the PlayerRound
        private void PlayerRound(Player player)
        {
            int i;
            for (i = 0; i< 3; i++)
            {
                Dart dart = new Dart(_random);
                dart.Throw();
                Score.ScoreDart(player, dart);
            }
        }


        

    }
}