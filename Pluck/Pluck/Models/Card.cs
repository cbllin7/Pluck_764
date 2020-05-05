using Pluck.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pluck.Models
{
    public class Card
    {
        public Card(Suits cardSuit, CardValues cardValue)
        {
            Suit.CardSuit = cardSuit;
            Value = cardValue;
        }
        public Suit Suit { get; set; }
        public CardValues Value { get; set; }
        public string CardName { get; set; }
    }
}
