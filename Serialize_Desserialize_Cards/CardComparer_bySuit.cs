using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialize_Desserialize_Cards
{
    class CardComparer_bySuit : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.Suit.CompareTo(y.Suit) > 0)
                return 1;
            if (x.Suit.CompareTo(y.Suit) < 0)
                return -1;
            if (x.Value.CompareTo(y.Value) > 0)
                return 1;
            if (x.Value.CompareTo(y.Value) < 0)
                return -1;
            return 0;
        }
    }

    class CardComparer_byValue : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.Value > y.Value)
                return 1;
            if (x.Value < y.Value)
                return -1;
            return 0;
        }
    }
}
