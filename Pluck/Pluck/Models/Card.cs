using System;
using System.Collections.Generic;
using System.Text;

namespace Pluck.Models
{
    public class Card
    {
        public Card(Suit cardSuit, CardValue cardValue)
        {
            Suit = cardSuit;
            Value = cardValue;
        }
        public Suit Suit { get; set; }
        public CardValue Value { get; set; }
    }
}
