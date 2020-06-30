using Pluck.Enums;
using Pluck.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluck.Services
{
    public class PlayerService : IPlayerService
    {
        public void CollectBook(Player player, List<Card> ActiveCardPlay)
        {
            player.CollectedBooks.Add(ActiveCardPlay);
        }

        public void OrderHand(Player player)
        {
            var cards = player.Hand.PlayerHand
                .GroupBy(x => x.Suit)
                .OrderByDescending(x => x.Count())
                .SelectMany(x => x.OrderByDescending(y => y.Value));
        }

        public Card PlayCard(Player player, int cardToPlay)
        {
            Card playingCard = player.Hand.PlayerHand[cardToPlay];
            RemoveCardFromHand(player.Hand.PlayerHand, playingCard);
            return playingCard;
        }

        public void RemoveCardFromHand(IList<Card> cards, Card cardToRemove)
        {
            cards.Remove(cardToRemove);
        }

        public string TalkingPlayer(Player player, int quoteChoosen)
        {
            return player.Quotes[quoteChoosen];
        }

        public void TallyScore(IList<Player> players)
        {
            foreach(Player player in players)
            {
                player.Score += (player.Books * 10);
            }
        }

        public void WinBook(Player player)
        {
            player.Books++;
        }
    }
}
