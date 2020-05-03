using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Pluck.Models
{
    public class Deck
    {
        public Deck(IEnumerable<Card> deckOfCards)
        {
            Cards = deckOfCards;
        }
        protected IEnumerable<Card> Cards { get; set; }
    }
}
