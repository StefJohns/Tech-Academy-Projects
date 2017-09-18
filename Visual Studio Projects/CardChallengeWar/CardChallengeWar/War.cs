using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace CardChallengeWar
{
    public class War
    {
        private StringBuilder stringBuilder;
        private List<Card> rewards;

        public War()
        {
            stringBuilder = new StringBuilder();
            rewards = new List<Card>();
        }

        public string PlayRound(Player PlayerOne, Player PlayerTwo)
        {
            Card PlayerOneCard = cardFlip(PlayerOne);
            Card PlayerTwoCard = cardFlip(PlayerTwo);

            CheckCardValues(PlayerOne, PlayerTwo, PlayerOneCard, PlayerTwoCard);

            return stringBuilder.ToString();
        }

        private void CheckCardValues(Player playerOne, Player playerTwo, Card playerOneCard, Card playerTwoCard)
        {
            DisplayRoundCards(playerOneCard, playerTwoCard);

            if (playerOneCard.CardFace() > playerTwoCard.CardFace())
                LootCards(playerOne);
            else if (playerOneCard.CardFace() == playerTwoCard.CardFace())
                DeclareWar(playerOne, playerTwo);
            else
                LootCards(playerTwo);
        }

        private void DeclareWar(Player playerOne, Player playerTwo)
        {
            stringBuilder.Append("<br/><h3>*********** WAR ***************</h3><br/>");
            //war has 4 cards thrown down when a match is played. I DE- CLARE- WAR
            //the "WAR" is the card the is compared.
            cardFlip(playerOne);
            cardFlip(playerOne);
            cardFlip(playerOne);
            Card warPOne = cardFlip(playerOne);

            cardFlip(playerTwo);
            cardFlip(playerTwo);
            cardFlip(playerTwo);
            Card warPTwo = cardFlip(playerTwo);

            CheckCardValues(playerOne, playerTwo, warPOne, warPTwo);
        }

        private void LootCards(Player player)
        {
            if (rewards.Count == 0) return;

            DisplayRewardCards();
            player.PlayerHand.AddRange(rewards);
            rewards.Clear();

            stringBuilder.Append("<br/>" + player.PlayerName + " wins this war!<br/>");

        }

        private void DisplayRewardCards()
        {
            stringBuilder.Append("<br/>Reward ...");

            foreach (var card in rewards)
            {
                stringBuilder.Append("<br/>&nbsp;&nbsp;&nbsp;&nbsp;");
                stringBuilder.Append(card.Value + " of " + card.Suit);
            }
        }

        private void DisplayRoundCards(Card playerOneCard, Card playerTwoCard)
        {
            stringBuilder.Append("<br/>Round Cards: " + playerOneCard.Value + " of " + playerOneCard.Suit + " versus " + playerTwoCard.Value + " of " + playerTwoCard.Suit);
        }

        private Card cardFlip(Player player)
        {
            Card card = player.PlayerHand.ElementAt(0);
            player.PlayerHand.Remove(card);
            rewards.Add(card);

            return card;
        }
    }
}