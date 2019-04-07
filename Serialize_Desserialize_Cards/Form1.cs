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

            firstFile[333] = (byte)Suits.Spades;
            firstFile[395] = (byte)Values.King;
            File.WriteAllBytes("c:\\programs\\king-s.dat", firstFile);

            using (FileStream input = File.OpenRead("c:\\programs\\king-s.dat"))
            {
                BinaryFormatter _bf = new BinaryFormatter();
                Card _card = (Card)_bf.Deserialize(input);
                Console.WriteLine("Suit =  {0},Value = {1}", _card.Suit, _card.Value);
                
            }

        }

        private void button_CreateHexDump_Click(object sender, EventArgs e)
        {
            string pathToFileCard = "c:\\programs\\king-s.dat";
            string pathtoFileHexDump = "c:\\programs\\king-s_hexdump.txt";
            using (StreamReader reader = new StreamReader(pathToFileCard)) {
                using (StreamWriter writer = new StreamWriter(pathtoFileHexDump, false)) {
                    int position = 0;

                    while (!reader.EndOfStream) {
                        char[] buffer = new char[16];
                        int charactersRead = reader.ReadBlock(buffer, 0, 16);
                        writer.Write("{0}: ", String.Format("{0:x4}", position));
                        position += charactersRead;

                        for (int i = 0; i < 16; i++){
                            if (i < charactersRead)
                            {
                                string hex = String.Format("{0:x2}", (byte)buffer[i]);
                                writer.Write(hex + " ");
                            }
                            else
                                writer.Write("  ");

                            if (i == 7) { writer.Write("-- "); }
                            if (buffer[i] < 32 || buffer[i] > 250) { buffer[i] = '.'; }
                        }

                        string bufferContents = new string(buffer);
                        writer.WriteLine("   " + bufferContents.Substring(0, charactersRead));

                    }

                }
            }

        }
    }
}
