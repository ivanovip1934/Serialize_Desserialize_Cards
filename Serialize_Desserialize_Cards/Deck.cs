using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialize_Desserialize_Cards
{
    class Deck
    {
        private List<Card> list_card;
        private Random random = new Random();

        public Deck()
        {
            list_card = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
                for (int value = 0; value < 13; value++)
                {
                    list_card.Add(new Card((Suits)suit, (Values)value));
                }
        }

        public Deck(IEnumerable<Card> _inintialCard)
        {
            list_card = new List<Card>(_inintialCard);
        }

        public int Count { get { return list_card.Count; } }

        public void Add(Card _cardToAdd)
        {
            list_card.Add(_cardToAdd);            
        }

        public Card Deal()
        {
            return Deal(0);
        }


        public Card Deal(int _index)
        {
            Card cardtoDeal = list_card[_index];
            this.list_card.RemoveAt(_index);
            return cardtoDeal;
        }



        public Card Peek(int _cardNumber)
        {
            return list_card[_cardNumber];
        }



        public bool ContainsValue(Values _value)
        {
            foreach (Card _card in list_card)
            {
                if (_card.Value == _value)
                    return true;
            }
            return false;
        }

        public Deck PullOutValues(Values _value)
        {
            Deck _deckToReturn = new Deck(new Card[] { });
            for (int i = list_card.Count - 1; i >= 0; i--)
            {
                if (list_card[i].Value == _value)
                    _deckToReturn.Add(this.Deal(i));
            }
            return _deckToReturn;
        }

        public bool HasBook(Values _value)
        {
            int _numberOfCards = 0;
            foreach (Card _card in list_card)
            {
                if (_card.Value == _value)
                    _numberOfCards++;
            }
            if (_numberOfCards == 4)
                return true;
            else
                return false;
        }

        public void SordByValue()
        {
            list_card.Sort(new CardComparer_byValue());
        }

        public IEnumerable<string> GetCardNames()
        {
            List<string> list_name = new List<string>();
            foreach (Card _name in list_card)
            {
                list_name.Add(_name.Name);
            }
            IEnumerable<string> ienum_name = list_name;

            return ienum_name;
        }

        public void Shuffle()
        {
            int cardToMove;
            List<Card> new_list_card = new List<Card>();
            while (list_card.Count > 0)
            {
                cardToMove = random.Next(list_card.Count);
                new_list_card.Add(list_card[cardToMove]);
                list_card.RemoveAt(cardToMove);
            }
            list_card = new_list_card;
        }

        public void Sort()
        {
            list_card.Sort(new CardComparer_bySuit());
        }
    }
}
