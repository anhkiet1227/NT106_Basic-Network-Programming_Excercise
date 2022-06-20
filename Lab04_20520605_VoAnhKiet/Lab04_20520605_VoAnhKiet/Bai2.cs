using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_20520605_VoAnhKiet
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        public string url = "";
        public Bai2(string url)
        {
            InitializeComponent();
            this.url = url;
            textBox1.Text = url;
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text != null)
                {
                    url = textBox1.Text;
                }   
                WebClient myClient = new WebClient();
                byte[] respone = myClient.DownloadData(url);
                richTextBox1.Text = Encoding.UTF8.GetString(respone);
                WebHeaderCollection whc = myClient.ResponseHeaders;

                string[] header = whc.AllKeys;


                listView1.View = View.Details;
                listView1.Columns.Add("STT");
                listView1.Columns.Add("Header");
                listView1.Columns.Add("Value");
                int number = 1;
                foreach (string file in header)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = number.ToString();
                    number++;
                    item.SubItems.Add(file);
                    item.SubItems.Add(whc.Get(file));
                    listView1.Items.Add(item);

                }
                for (int i = 0; i < listView1.Columns.Count; i++)
                {
                    listView1.Columns[i].Width = -2;
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new MainForm();
            newForm.Closed += (s, args) => this.Close();
            newForm.Show();
        }
    }
}
