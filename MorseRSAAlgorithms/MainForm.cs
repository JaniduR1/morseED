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

namespace MorseRSAAlgorithms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private static Dictionary<char, string> morseConverter = new Dictionary<char, string>
            {
                {'A', "1"},
                {'B', "2"},
                {'C', "3"},
                {'D', "4"},
                {'E', "5"},
                {'F', "6"},
                {'G', "7"},
                {'H', "8"},
                {'I', "9"},
                {'J', "10"},
                {'K', "11"},
                {'L', "12"},
                {'M', "13"},
                {'N', "14"},
                {'O', "15"},
                {'P', "16"},
                {'Q', "17"},
                {'R', "18"},
                {'S', "19"},
                {'T', "20"},
                {'U', "21"},
                {'V', "22"},
                {'W', "23"},
                {'X', "24"},
                {'Y', "25"},
                {'Z', "26"},
            };


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void dropDownEncryptorDecrypt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                //MessageBox.Show($"{fileName} opened");

                try
                {
                    inputBox.Text = File.ReadAllText(fileName);
                }
                catch
                {
                    MessageBox.Show("That file cannot be opened");
                }


            } 
            else 
            {
                MessageBox.Show("No File Chosen");
            }
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }


        private void openFileBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                //MessageBox.Show($"{fileName} opened");

                try
                {
                    inputBox.Text = File.ReadAllText(fileName);
                }
                catch
                {
                    MessageBox.Show("That file cannot be opened");
                }


            }
            else
            {
                MessageBox.Show("No File Chosen");
            }

        }

        private void saveAsBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                var path = saveFile.FileName;
                StreamWriter writer = new StreamWriter(path);
                writer.Write(outputBox.Text);
                writer.Close();
            }

        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void dropDownRsaOrMorse_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (dropDownRsaOrMorse.SelectedItem == "Morse" && dropDownEncryptorDecrypt.SelectedItem == "Encrypt")
            {
                //outputBox.Text = "It Works";

                String str;


                MorseEncoder morseE = new MorseEncoder();
                str = morseE.MEncoder(inputBox.Text);

                outputBox.Text = str;

                string text = inputBox.Text;
                string output = morseE.MEncoder(text);
            }

            else if (dropDownRsaOrMorse.SelectedItem == "Morse" && dropDownEncryptorDecrypt.SelectedItem == "Decrypt")
            {
                //outputBox.Text = "It Works";

                String str;

                MorseEncoder morseD = new MorseEncoder();
                str = morseD.MDecoder(inputBox.Text);

                outputBox.Text = str;

                string morseV = inputBox.Text;
                string output = morseD.MDecoder(morseV);

            }

            else if (dropDownRsaOrMorse.SelectedItem == "RSA" && dropDownEncryptorDecrypt.SelectedItem == "Encrypt")
            {
                //outputBox.Text = "It Works";
                String str;

                RSA rsaE = new RSA();
                str = rsaE.RSAEncrypt(inputBox.Text);

                outputBox.Text = str;

                string rsaV = inputBox.Text;
                string output = rsaE.RSAEncrypt(rsaV);
            }
        }

        public string InputBox
        {
            get { return inputBox.Text;  }
            set { inputBox.Text = value; }
        }


    }
}
