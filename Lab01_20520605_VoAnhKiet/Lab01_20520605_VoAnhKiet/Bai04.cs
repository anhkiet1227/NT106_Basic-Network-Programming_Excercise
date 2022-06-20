using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace Lab01_20520605_VoAnhKiet
{
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
            comboBox1.Items.Add("DEC");
            comboBox1.Items.Add("HEX");
            comboBox1.Items.Add("BIN");
            comboBox2.Items.Add("DEC");
            comboBox2.Items.Add("HEX");
            comboBox2.Items.Add("BIN");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }        

        private void button3_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Caution: ERROR! Check your box again");
            }
            if(comboBox1.SelectedItem == "DEC" && comboBox2.SelectedItem == "DEC")
            {
                MessageBox.Show("Caution: ERROR! Check your box again");
            }
            if (comboBox1.SelectedItem == "HEX" && comboBox2.SelectedItem == "HEX")
            {
                MessageBox.Show("Caution: ERROR! Check your box again");
            }
            if (comboBox1.SelectedItem == "BIN" && comboBox2.SelectedItem == "BIN")
            {
                MessageBox.Show("Caution: ERROR! Check your box again");
            }
            
            if (comboBox1.SelectedItem == "DEC")
            {
                int inputDecNumber;
                try
                {
                    inputDecNumber = Int32.Parse(textBox1.Text.Trim());
                    if (comboBox1.SelectedItem == "DEC" && comboBox2.SelectedItem == "HEX")
                    {
                        string outHex = Convert.ToString(inputDecNumber, 16);
                        textBox2.Text = outHex;
                    }
                    if (comboBox1.SelectedItem == "DEC" && comboBox2.SelectedItem == "BIN")
                    {
                        string outBin = Convert.ToString(inputDecNumber, 2);
                        textBox2.Text = outBin;
                    }
                }
                catch (Exception tmp)
                {
                    MessageBox.Show("Caution: ERROR! Check your input again");
                }
            }
            
            if (comboBox1.SelectedItem == "HEX")
            {
                string inputHexNumber;
                try
                {
                    inputHexNumber = textBox1.Text.Trim();
                    //check Hex number
                    if (comboBox1.SelectedItem == "HEX" && comboBox2.SelectedItem == "DEC")
                    {
                        int outDec = Convert.ToInt32(inputHexNumber, 16);
                        textBox2.Text = outDec.ToString();
                    }
                    if(comboBox1.SelectedItem == "HEX" && comboBox2.SelectedItem == "BIN")
                    {
                        int outDec = Convert.ToInt32(inputHexNumber, 16);
                        string outBin = Convert.ToString(outDec, 2);
                        textBox2.Text = outBin;
                    }    
                }
                catch (Exception tmp)
                {
                    MessageBox.Show("Caution: ERROR! Check your input again");
                }
            }

            if (comboBox1.SelectedItem == "BIN")
            {
                string inputBinNumber;
                try
                {
                    inputBinNumber = textBox1.Text.Trim();
                    if (comboBox1.SelectedItem == "BIN" && comboBox2.SelectedItem == "DEC")
                    {
                        string outDec = Convert.ToInt64(inputBinNumber, 2).ToString();
                        textBox2.Text = outDec;
                    }
                    if (comboBox1.SelectedItem == "BIN" && comboBox2.SelectedItem == "HEX")
                    {
                        long outDec = Convert.ToInt64(inputBinNumber, 2);
                        string outHex = Convert.ToString(outDec, 16);
                        textBox2.Text = outHex;
                    }    
                }
                catch
                {
                    MessageBox.Show("Caution: ERROR! Check your input again");
                }
            }    
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        
    }
}
