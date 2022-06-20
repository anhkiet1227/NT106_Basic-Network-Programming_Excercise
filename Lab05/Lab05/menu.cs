using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new SendMail();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new MailServer();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new SendMailViaGmail();
            frm.Show();
        }
    }
}
