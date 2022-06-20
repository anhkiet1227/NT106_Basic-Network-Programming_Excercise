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
    public partial class Bai2 : Form
    {
        public Bai2()
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
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);

                string content = sr.ReadToEnd();
                richTextBox1.Text = content;

                textBox1.Text = ofd.SafeFileName.ToString();

                textBox2.Text = ofd.FileName;

                content = content.Replace("\r\n", "\r");
                int lineCount = richTextBox1.Lines.Count();
                content = content.Replace('\r', ' ');

                textBox3.Text = lineCount.ToString();

                string[] source = content.Split(new char[] { '.', '?', '!', ' ', ';',':', ',' }, StringSplitOptions.RemoveEmptyEntries);
                int wordCount = source.Count();

                textBox4.Text = wordCount.ToString();

                int charCount = content.Length;
                textBox5.Text = charCount.ToString();
                

                
                fs.Close();
            }
            catch (Exception tmp)
            {
                MessageBox.Show("Caution: " + tmp.Message);
            }
        }
    }
}
