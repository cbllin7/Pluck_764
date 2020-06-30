using Pluck.Models;
using System.Collections.Generic;

namespace Pluck.Services
{
    public interface IDeckService
    {
        Deck GetDeck();
        void ShuffleDeck(Deck deck);
        void DealCards(Deck deck, List<Player> players);
    }
}
