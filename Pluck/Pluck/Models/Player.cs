using Pluck.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pluck.Models
{
    class Player
    {
        public Players CardPlayer { get; set; }
        public IEnumerable<Card> Hand { get; set; }
        public bool IsUser { get; set; }
        public int Book { get; set; }
        public int Score { get; set; }
    }
}
