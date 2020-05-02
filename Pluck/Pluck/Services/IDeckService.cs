using Pluck.Models;

namespace Pluck.Services
{
    public interface IDeckService
    {
        Deck GetDeck();
        Deck ShuffleDeck(Deck deck);
        void DealCards(Deck deck);
    }
}
