using System;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit;
using MailKit.Security;
using MailKit.Search;

namespace Lab05
{
    public partial class MailServer : Form
    {
        public MailServer()
        {
            InitializeComponent();
        }
        void DownloadMessages()
        {
            listmail.Columns.Add("Email", 200);
            listmail.Columns.Add("From", 300);
            listmail.Columns.Add("Thời gian", 200);
            listmail.View = View.Details;
            using (var client = new ImapClient(new ProtocolLogger("imap.log")))
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                client.Connect("127.0.0.1", 143, SecureSocketOptions.Auto);

                client.Authenticate(usermail.Text, password.Text);

                client.Inbox.Open(FolderAccess.ReadOnly);

                var uids = client.Inbox.Search(SearchQuery.NotSeen);
                recent.Text = uids.Count.ToString();
                uids = client.Inbox.Search(SearchQuery.All);
                total.Text = uids.Count.ToString();
                

                foreach (var uid in uids)
                {
                    var message = client.Inbox.GetMessage(uid);

                    ListViewItem name = new ListViewItem(message.Subject);
                    ListViewItem.ListViewSubItem from = new
                    ListViewItem.ListViewSubItem(name, message.From.ToString());
                    name.SubItems.Add(from);
                    ListViewItem.ListViewSubItem date = new
                    ListViewItem.ListViewSubItem(name, message.Date.DateTime.ToString());
                    name.SubItems.Add(date);
                    listmail.Items.Add(name);
                }

                client.Disconnect(true);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DownloadMessages();
        }
        
    }
}
