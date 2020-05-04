using Pluck.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluck.Services
{
    public class PlayerService : IPlayerService
    {
        public IEnumerable<Card> CollectBook(Player player, IEnumerable<Card> ActiveCardPlay)
        {
            throw new NotImplementedException();
        }

        public Hand OrderHand(Player player)
        {
            throw new NotImplementedException();
        }

        public Card PlayCard(Player player, string cardToPlay)
        {
            Card playingCard = player.Hand.PlayerHand.Where(x => x.CardName == cardToPlay).FirstOrDefault();
            return playingCard;
        }

        public void RemoveCardFromHand(Player player, string cardToRemove)
        {
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

        public int WinBook(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
