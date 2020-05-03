using System;
using System.Collections.Generic;
using System.Text;

namespace Pluck.Models
{
    public class CardTable
    {
        public IEnumerable<Player> ActivePlayers { get; set; }
        public IEnumerable<Card> ActiveCardPlay { get; set; }
    }
}
