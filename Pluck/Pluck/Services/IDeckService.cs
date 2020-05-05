using Pluck.Models;

namespace Pluck.Services
{
    public interface IDeckService
    {
        Deck GetDeck();
        void ShuffleDeck(Deck deck);
        void DealCards(Deck deck);
    }
}
