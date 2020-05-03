using Pluck.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pluck.Models
{
    public class Player
    {
        public Player(Hand playerHand, bool isUser, int books, string speak, int score)
        {
            Hand = playerHand;
            IsUser = isUser;
            Books = books;
            Score = score;

        }
        protected Hand Hand { get; set; }
        protected bool IsUser { get; set; }
        protected int Books { get; set; }
        protected int Score { get; set; }
        protected IEnumerable<string> Quotes { get; set; }

    }
}
