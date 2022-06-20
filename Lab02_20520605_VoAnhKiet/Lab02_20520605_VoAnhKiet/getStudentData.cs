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
    public partial class getStudentData : Form
    {
        
        public getStudentData()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string str = textBox2.Text + ";" + textBox1.Text + ";" + textBox3.Text + ";" + textBox4.Text + ";" + textBox5.Text + "\n";
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "txt files (*.txt)|*.txt";
                saveFile.FileName = "input.txt";
                saveFile.ShowDialog();
                FileStream fs = new FileStream(saveFile.FileName, FileMode.Append, FileAccess.Write);
                StreamWriter sr = new StreamWriter(fs, Encoding.UTF8);
                sr.Write(str);
                sr.Close();
                fs.Close();
            }
            catch (Exception tmp)
            {
                MessageBox.Show("Caution: " + tmp.Message);
            }
        }

        
    }
}
