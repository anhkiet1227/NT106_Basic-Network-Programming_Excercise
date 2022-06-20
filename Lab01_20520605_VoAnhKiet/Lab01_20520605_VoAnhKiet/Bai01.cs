using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_20520605_VoAnhKiet
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int firstNumber, secondNumber;
            long sumNumber = 0;
            try
            {
                firstNumber = Int32.Parse(textBox1.Text.Trim());
                secondNumber = Int32.Parse(textBox2.Text.Trim());
                sumNumber = firstNumber + secondNumber;
                textBox3.Text = sumNumber.ToString();
            }
            catch (Exception tmp)
            {
                MessageBox.Show("Caution: ERROR! Check your input again");
            }
        }        

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }
        
    }
}
