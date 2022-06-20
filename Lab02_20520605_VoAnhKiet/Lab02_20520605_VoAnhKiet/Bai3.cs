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

namespace Lab02_20520605_VoAnhKiet
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                richTextBox1.Text = sr.ReadToEnd();
                fs.Close();
            }
            catch (Exception tmp)
            {
                MessageBox.Show("Caution: " + tmp.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string str = richTextBox2.Text;
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "txt files (*.txt)|*.txt";
                saveFile.ShowDialog();
                FileStream fs = new FileStream(saveFile.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                sw.WriteLine(str);
                sw.Close();
                fs.Close();
            }
            catch (Exception tmp)
            {
                MessageBox.Show("Caution: " + tmp.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string str = richTextBox1.Text;
                string str2 = "";
                string[] substr = str.Split('\n');          
                
                foreach (string element in substr)
                {
                    double result = Convert.ToDouble(new DataTable().Compute(element, null));
                    str2 += element + " = " + result + "\n";
                }
                
                richTextBox2.Text = str2;

            }
            catch (Exception tmp)
            {
                MessageBox.Show("Caution: " + tmp.Message);
            }
        }
    }
}
