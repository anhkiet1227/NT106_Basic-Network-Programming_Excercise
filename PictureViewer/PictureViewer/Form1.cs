using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel_Left_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
                currentFormChild.Close();
            label1.Text = "Võ Anh Kiệt";
        }
        private Form currentFormChild;
        private void openChildForm(Form childForm)
        {
            if (currentFormChild != null)
                currentFormChild.Close();
            
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Main.Controls.Add(childForm);
            panel_Main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            label1.Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            label1.Text = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4());
            label1.Text = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Form5());
            label1.Text = button4.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
                currentFormChild.Close();
            label1.Text = "Võ Anh Kiệt";
        }
    }
}
