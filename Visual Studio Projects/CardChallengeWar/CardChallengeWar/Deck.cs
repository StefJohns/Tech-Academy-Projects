using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace CardChallengeWar
{
    public class Deck
    {
        private List<Card> CardDeck;
        private StringBuilder strBldr;
        private Random deckRandom;

        public Deck()
        {
            CardDeck = new List<Card>();
            strBldr = new StringBuilder();
            deckRandom = new Random();

            string[] faces = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            string[] suits = new string[] { "Clubs", "Hearts", "Diamonds", "Spades" };

            foreach (var suit in suits)
            {
                foreach (var face in faces)
                {
                    CardDeck.Add(new Card() { Suit = suit, Value = face });
                }
            }
        }

        public string DealDeck(Player player1, Player player2)
        {
            while (CardDeck.Count > 0)
            {
                DealCard(player1);
                DealCard(player2);
            }
            return strBldr.ToString();
        }

        private void DealCard(Player player)
        {
            Card card = CardDeck.ElementAt(deckRandom.Next(CardDeck.Count));
            player.PlayerHand.Add(card);
            CardDeck.Remove(card);

            strBldr.Append(player.PlayerName);
            strBldr.Append(" is dealt the ");
            strBldr.Append(card.Value + " of " + card.Suit);
            strBldr.Append("<br/>");
        }
    }
}