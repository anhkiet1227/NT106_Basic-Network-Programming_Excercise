using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncDec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string EncryptCaesar(string plaintext, int key)
        {
            string ciphertext = "";
            char charater;
            for (int i = 0; i < plaintext.Length; i++)
            {
                if (plaintext[i].ToString() == " ")
                {
                    ciphertext += " ";
                }                        
                else if (char.IsUpper(plaintext[i]))
                {
                    charater = (char)(((int)plaintext[i] + key - 65) % 26 + 65);
                    ciphertext += charater;
                }
                else
                {
                    charater = (char)(((int)plaintext[i] + key - 97) % 26 + 97);
                    ciphertext += charater;
                }
            }
            return ciphertext;

        }
        public string DecryptCaesar(string ciphertext, int key)
        {
            string recovertext = "";
            char character;
            for (int i = 0; i < ciphertext.Length; i++)
            {
                if (ciphertext[i].ToString() == " ")
                {
                    recovertext += " ";
                }
                else if (char.IsUpper(ciphertext[i]))
                {
                    character = (char)(((int)ciphertext[i] - key - 65 + 26) % 26 + 65);
                    recovertext += character;
                }
                else
                {
                    character = (char)(((int)ciphertext[i] - key - 97 + 26) % 26 + 97);
                    recovertext += character;
                }
            }
            return recovertext;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int key = int.Parse(textBox1.Text);
                string plaintext = richTextBox1.Text;
                string ciphertext = EncryptCaesar(plaintext, key);
                richTextBox2.Text = "";
                richTextBox2.Text = ciphertext;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int key = int.Parse(textBox1.Text);
                string ciphertext = richTextBox2.Text;
                string plaintext = DecryptCaesar(ciphertext, key);
                richTextBox1.Text = "";
                richTextBox1.Text = plaintext;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
