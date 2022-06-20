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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string strName = textBox1.Text;
                string[] files = Directory.GetFiles(strName);
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox4.Items.Clear();
                foreach (string file in files)
                {
                    FileInfo fi = new FileInfo(file);
                    listBox1.Items.Add(fi.Name);
                    listBox2.Items.Add(fi.Length);
                    listBox3.Items.Add(fi.LastWriteTime);
                    listBox4.Items.Add(fi.Extension);
                    listBox1.Items.Add("\n");
                    listBox2.Items.Add("\n");
                    listBox3.Items.Add("\n");
                    listBox4.Items.Add("\n");
                }
            }
            catch(Exception tmp)
            {
                MessageBox.Show("Caution: " + tmp.Message);
            }
            
            
        }
    }
}
