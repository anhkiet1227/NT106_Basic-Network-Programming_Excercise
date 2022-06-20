using HtmlAgilityPack;
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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new MainForm();
            newForm.Closed += (s, args) => this.Close();
            newForm.Show();
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            textBox1.Text = webBrowser1.Url.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.Navigate(textBox1.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var newForm = new Bai2(textBox1.Text);
            newForm.Show();
        }

        private void getDataFromWeb(string url, string localfile)
        {
            WebClient myclient = new WebClient();
            myclient.DownloadFile(url, localfile);

        }

        private void downloadImg(string url, string despath)
        {
            using (var client = new WebClient())
            {
                try
                {
                    client.DownloadFile(new Uri(url), despath);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);

                }
            }
        }

        private void getFile(string url, string local)
        {
            WebClient myclient = new WebClient();
            myclient.DownloadFile(url, local);
        }

        private void createWeb(string htmlpath, string htmldespath, string despath)
        {
            string geturl = textBox1.Text;
            geturl = geturl.Remove(geturl.Length - 1, 1);
            string[] position = new string[100];
            int tmpValue = 0;
            
            HtmlAgilityPack.HtmlDocument dataDoc = new HtmlAgilityPack.HtmlDocument();
            dataDoc.OptionReadEncoding = true;

            StreamReader streamReader = new StreamReader(htmlpath, Encoding.UTF8, true);
            dataDoc.Load(streamReader.BaseStream, Encoding.UTF8);
            
            foreach (HtmlNode linkFromHTML in dataDoc.DocumentNode.SelectNodes("//img"))
            {
                ++tmpValue;
                string data = linkFromHTML.GetAttributeValue("src", "") + "\n";

                if (!data.StartsWith("http") || !data.StartsWith("https"))
                    data = geturl + data;
                position[tmpValue] = "";

                if (data.Contains(".png")) 
                    position[tmpValue] = despath + @"getweb\img\picture" + tmpValue.ToString() + ".png";

                else if (data.Contains(".jpg")) 
                    position[tmpValue] = despath + @"getweb\img\picture" + tmpValue.ToString() + ".jpg";

                else if (data.Contains(".gif")) 
                    position[tmpValue] = despath + @"getweb\img\picture" + tmpValue.ToString() + ".gif";

                downloadImg(data, position[tmpValue]);
            }

            tmpValue = 0;

            foreach (HtmlNode nodeFromHTML in dataDoc.DocumentNode.SelectNodes("//img[@src]"))
            {
                ++tmpValue;
                nodeFromHTML.SetAttributeValue("src", position[tmpValue]);
            }
            dataDoc.Save(htmldespath, Encoding.UTF8);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                button3.Enabled = false;

                getDataFromWeb(textBox1.Text, 
                    System.AppDomain.CurrentDomain.BaseDirectory + @"getweb\webget.html");

                createWeb(
                    System.AppDomain.CurrentDomain.BaseDirectory + @"getweb\webget.html", 
                    System.AppDomain.CurrentDomain.BaseDirectory + @"webcreate.html", 
                    System.AppDomain.CurrentDomain.BaseDirectory);

                button3.Enabled = true;

                MessageBox.Show("Successful download!");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
