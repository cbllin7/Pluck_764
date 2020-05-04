using System;
using System.Collections.Generic;
using System.Text;

namespace Pluck.Models
{
    public class Hand
    {
        public IList<Card> PlayerHand { get; set; }
        public bool NeedPluck { get; set; }
        public bool GettingPluck { get; set; }
        public int BooksToPluck { get; set; }
        public int BooksToGive { get; set; }
    }
}
