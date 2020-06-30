using Pluck.Models;
using System.Collections.Generic;

namespace Pluck.Services
{
    public interface IPlayerService
    {
        void OrderHand(Player player);
        Card PlayCard(Player player, int cardToPlay);
        string TalkingPlayer(Player player, int quoteChoosen);
        void CollectBook(Player player, List<Card> ActiveCardPlay);
        void WinBook(Player player);
        void TallyScore(IList<Player> players);
        void RemoveCardFromHand(IList<Card> cards, Card cardToRemove);
    }
}
