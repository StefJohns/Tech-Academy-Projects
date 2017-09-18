using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CardChallengeWar
{
    public class Card
    {
        public string Value { get; set; }
        public string Suit { get; set; }

        public int CardFace()
        {
            int value = 0;

            switch (this.Value)
            {
                //Ace is low
            
                case "Ace":
                    value = 1;
                    break;
                case "Jack":
                    value = 11;
                    break;
                case "Queen":
                    value = 12;
                    break;
                case "King":
                    value = 13;
                    break;
                default:
                    value = int.Parse(this.Value);
                    break;
            }
            return value;
        }
    }
}