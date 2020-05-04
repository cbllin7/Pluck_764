using Pluck.Models;
using System.Collections.Generic;

namespace Pluck.Services
{
    public interface IPlayerService
    {
        Hand OrderHand(Player player);
        Card PlayCard(Player player, string cardToPlay);
        string TalkingPlayer(Player player, int quoteChoosen);
        IEnumerable<Card> CollectBook(Player player, IEnumerable<Card> ActiveCardPlay);
        int WinBook(Player player);
        void TallyScore(IList<Player> players);
        void RemoveCardFromHand(Player player, string cardToRemove);
    }
}
