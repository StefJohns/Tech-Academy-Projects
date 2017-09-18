using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CardChallengeWar
{
    public class Player
    {
        public string PlayerName { get; set; }
        public List<Card> PlayerHand { get; set; }

        public Player()
        {
            PlayerHand = new List<Card>();
        }
    }
}