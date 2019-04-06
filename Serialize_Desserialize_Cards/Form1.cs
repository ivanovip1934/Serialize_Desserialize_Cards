using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialize_Deserialize_Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button_SerCard1_Click(object sender, EventArgs e)
        {
            Card _card1 = new Card(Suits.Clubs, Values.Three);
            
            using (FileStream output = File.Create("c:\\programs\\three-c.dat"))
            {
                BinaryFormatter _bf = new BinaryFormatter();
                _bf.Serialize(output, _card1);
            }
        }


        private void button_SerCard2_Click(object sender, EventArgs e)
        {
            Card _card1 = new Card(Suits.Hearts, Values.Six);
            using (FileStream output = File.Create("c:\\programs\\six-h.dat"))
            {
                BinaryFormatter _bf = new BinaryFormatter();
                _bf.Serialize(output, _card1);
            }
        }

        
private void button_CompareCard_Click(object sender, EventArgs e)
        {
            byte[] firstFile = File.ReadAllBytes("c:\\programs\\three-c.dat");
            byte[] secondFile = File.ReadAllBytes("c:\\programs\\six-h.dat");

            for (int i = 0; i < firstFile.Length; i++) {
                if (firstFile[i] != secondFile[i])
                    Console.WriteLine("Byte #{0}: {1} versus {2}",
                        i, firstFile[i], secondFile[i]);
            }


        }
    }
}
