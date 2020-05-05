using Pluck.Enums;
using Pluck.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pluck.Services
{
    public class DeckService : IDeckService
    {
        public Deck GetDeck()
        {
            var deck = new Deck();
            var cards = new List<Card>();
            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach (CardValues cardValue in Enum.GetValues(typeof(CardValues)))
                {
                    cards.Add(new Card(suit, cardValue));
                }
            }
            deck.DeckOfCards = cards;
            return deck;
        }

        public void ShuffleDeck(Deck deck)
        {
            Random random = new Random();
            for (var i = deck.DeckOfCards.Count - 1; i > 0; i--)
            {
                var temp = deck.DeckOfCards[i];
                var index = random.Next(0, i + 1);
                deck.DeckOfCards[i] = deck.DeckOfCards[index];
                deck.DeckOfCards[index] = temp;
            }
        }
        public void DealCards(Deck deck)
        {
            throw new NotImplementedException();
        }

    }
}
