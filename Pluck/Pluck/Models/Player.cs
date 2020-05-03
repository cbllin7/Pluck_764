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
        public Hand Hand { get; set; }
        public bool IsUser { get; set; }
        public int Books { get; set; }
        public int Score { get; set; }
        public IList<string> Quotes { get; set; }

    }
}
