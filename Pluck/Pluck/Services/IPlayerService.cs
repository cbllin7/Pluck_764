using Pluck.Models;
using System.Collections.Generic;

namespace Pluck.Services
{
    public interface IPlayerService
    {
        IEnumerable<Card> OrderHand(Player player);
        Card PlayCard(Player player);
        string TalkingPlayer(Player player);
        IEnumerable<Card> CollectBook(Player player);
        int WinBook(Player player);
        int TallyScore(Player player);
    }
}
