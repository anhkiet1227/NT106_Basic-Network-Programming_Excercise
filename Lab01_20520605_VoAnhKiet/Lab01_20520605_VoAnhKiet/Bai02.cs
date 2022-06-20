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
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }
        private static double Max(double x, double y)
        {
            return Math.Max(x, y);
        }

        private static double Max(double x, double y, double z)
        {           
            return Math.Max(x, Math.Max(y, z));
        }

        private static double Min(double x, double y)
        {
            return Math.Min(x, y);
        }

        private static double Min(double x, double y, double z)
        {
            return Math.Min(x, Math.Min(y, z));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double firstNumber, secondNumber, thirdNumber, maxNumber, minNumber;
            try
            {
                firstNumber = Double.Parse(textBox1.Text.Trim());
                secondNumber = Double.Parse(textBox2.Text.Trim());
                thirdNumber = Double.Parse(textBox3.Text.Trim());
                maxNumber = Max(firstNumber, secondNumber, thirdNumber);
                minNumber = Min(firstNumber, secondNumber, thirdNumber);
                textBox4.Text = maxNumber.ToString();
                textBox5.Text = minNumber.ToString();
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
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }        
    }
}
