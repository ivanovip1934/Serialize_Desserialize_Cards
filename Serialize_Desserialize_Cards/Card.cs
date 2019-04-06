using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialize_Deserialize_Cards
{
    [Serializable]
    class Card
    {
        public Suits Suit { get; private set; }
        public Values Value { get; private set; }

        public Card(Suits _suit, Values _value)
        {
            this.Suit = _suit;
            this.Value = _value;
        }

        public string Name
        {
            get
            {
                return Value.ToString() + " of " + Suit.ToString();
            }
        }

        public static string Plural(Values _value)
        {
            if (_value == Values.Six)
                return "Sixes";
            else
                return _value.ToString() + "s";
        }

    }
}
