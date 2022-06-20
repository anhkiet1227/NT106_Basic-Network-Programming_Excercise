using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace MultiThreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }     

        private void button1_Click(object sender, EventArgs e)
        {
            int inputValue;
            try
            {
                inputValue = Convert.ToInt32(textBox1.Text);
                ThreadStart startFirstThread = new ThreadStart(runThread1);
                Thread firstThread = new Thread(startFirstThread);
                firstThread.Start();
            }
            catch (Exception tmp)
            {
                MessageBox.Show("Caution: ERROR! Check your input again");
            }

        }
        void runThread1()
        {
            button1.Enabled = false;
            for (int i = 0; i <= Convert.ToInt32(textBox1.Text); i++)
            {
                label4.Text = i.ToString();
            }
            button1.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int inputValue;
            try
            {
                inputValue = Convert.ToInt32(textBox1.Text);
                ThreadStart startSecondThread = new ThreadStart(runThread2);
                Thread secondThread = new Thread(startSecondThread);
                secondThread.Start();
            }
            catch (Exception tmp)
            {
                MessageBox.Show("Caution: ERROR! Check your input again");
            }
        }
        void runThread2()
        {
            button2.Enabled = false;
            for (int i = 0; i <= Convert.ToInt32(textBox1.Text); ++i)
            {
                label5.Text = i.ToString();
            }
            button2.Enabled = true;
        }
    }
}
