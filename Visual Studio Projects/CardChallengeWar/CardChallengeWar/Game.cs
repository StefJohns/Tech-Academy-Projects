using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CardChallengeWar
{
    public class Game
    {
        private Player PlayerOne;
        private Player PlayerTwo;

        public Game(string _plyr1Name, string _plyr2Name)
        {
            PlayerOne = new Player() { PlayerName = _plyr1Name };
            PlayerTwo = new Player() { PlayerName = _plyr2Name };
        }
        public string PlayGame()
        {
            Deck cardDeck = new Deck();
            string result = "<h2>Dealing Cards ...</h2><br />" + cardDeck.DealDeck(PlayerOne, PlayerTwo);

            var turn = 0;
            result += "<br /><h2>Begin Battle ...</h2>";

            while (PlayerOne.PlayerHand.Count != 0 && PlayerTwo.PlayerHand.Count != 0)
            {
                War war = new War();
                result += war.PlayRound(PlayerOne, PlayerTwo);

                turn++;
                if (turn > 20)
                    break;
            }
            result += GetWarWinner();
            return result;
        }

        private string GetWarWinner()
        {
            string result = "";
            if (PlayerOne.PlayerHand.Count > PlayerTwo.PlayerHand.Count)
                result += "<br/>Player 1 wins";
            else
                result += "<br/>Player 2 wins";

            result += "<br/>Card Count:<br/> Player One:" + PlayerOne.PlayerHand.Count + "<br/>Player Two:" + PlayerTwo.PlayerHand.Count;
            return result;
        }
    }
}