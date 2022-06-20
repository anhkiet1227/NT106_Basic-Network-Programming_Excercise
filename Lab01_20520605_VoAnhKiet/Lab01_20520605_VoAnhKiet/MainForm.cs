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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bai1_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var tmpForm = new Bai01();
            tmpForm.Closed += (s, args) => this.Close();
            tmpForm.Show();
        }

        private void bai2_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var tmpForm = new Bai02();
            tmpForm.Closed += (s, args) => this.Close();
            tmpForm.Show();
        }

        private void bai3_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var tmpForm = new Bai03();
            tmpForm.Closed += (s, args) => this.Close();
            tmpForm.Show();
        }

        private void bai4_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var tmpForm = new Bai04();
            tmpForm.Closed += (s, args) => this.Close();
            tmpForm.Show();
        }

        private void bai5_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var tmpForm = new Bai05();
            tmpForm.Closed += (s, args) => this.Close();
            tmpForm.Show();
        }

        private void thoat_button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
