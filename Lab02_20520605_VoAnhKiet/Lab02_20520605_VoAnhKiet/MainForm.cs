using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_20520605_VoAnhKiet
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var tmpForm = new Bai1();
            tmpForm.Closed += (s, args) => this.Close();
            tmpForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var tmpForm = new Bai2();
            tmpForm.Closed += (s, args) => this.Close();
            tmpForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var tmpForm = new Bai3();
            tmpForm.Closed += (s, args) => this.Close();
            tmpForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var tmpForm = new Bai4();
            tmpForm.Closed += (s, args) => this.Close();
            tmpForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var tmpForm = new Bai5();
            tmpForm.Closed += (s, args) => this.Close();
            tmpForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
