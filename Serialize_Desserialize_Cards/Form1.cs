using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialize_Deserialize_Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();

        //Создается пустая колода,
        //в которую случайным образом добавляются карты из класса Card,
        //созданного в предыдущей главе.
        private Deck RandomDeck(int _number) {
            Deck _myDeck = new Deck(new Card[] { });
            for (int i = 0; i < _number; i++) {
                _myDeck.Add(new Card(
                    (Suits)random.Next(4),
                    (Values)random.Next(1,14)));
            }
            return _myDeck;
        }

        private void DealCards(Deck _deckToDeal, string _title) {
            Console.WriteLine(_title);
            while (_deckToDeal.Count > 0) {
                Card _nextCard = _deckToDeal.Deal(0);
                Console.WriteLine(_nextCard.Name);
            }
            Console.WriteLine("----------------------------");
        }
    }
}
