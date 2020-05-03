using System;
using System.Collections.Generic;
using System.Text;

namespace Pluck.Models
{
    public class Card
    {
        public Card(Suit cardSuit, CardValue cardValue, string cardName)
        {
            Suit = cardSuit;
            Value = cardValue;
            CardName = cardName;
        }
        public Suit Suit { get; set; }
        public CardValue Value { get; set; }
        public string CardName { get; set; }
    }
}
