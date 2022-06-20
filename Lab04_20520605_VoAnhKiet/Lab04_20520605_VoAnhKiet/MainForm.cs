using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_20520605_VoAnhKiet
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
            var newForm = new Bai1();
            newForm.Closed += (s, args) => this.Close();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Bai2();
            newForm.Closed += (s, args) => this.Close();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Bai3();
            newForm.Closed += (s, args) => this.Close();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Bai4();
            newForm.Closed += (s, args) => this.Close();
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
