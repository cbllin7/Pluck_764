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
                if (!(suit == Suits.Joker))
                {
                    foreach (CardValues cardValue in Enum.GetValues(typeof(CardValues)))
                    {
                        if (cardValue != CardValues.LittleJoker || cardValue != CardValues.BigJoker)
                        cards.Add(new Card(suit, cardValue));
                    }
                }
            }
            cards.Add(new Card(Suits.Joker, CardValues.LittleJoker));
            cards.Add(new Card(Suits.Joker, CardValues.BigJoker));
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
        public void DealCards(Deck deck, List<Player> players)
        {
            var deckCount = 0;
            foreach(Player player in players)
            {
                for (var cardCount = 0; cardCount < 17; deckCount++)
                    player.Hand.PlayerHand.Add(deck.DeckOfCards[deckCount]);
            }
        }

    }
}
