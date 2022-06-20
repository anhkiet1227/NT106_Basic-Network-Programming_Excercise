using System;
using System.Windows.Forms;
using System.Net.Mail;
using MimeKit;
using MimeKit.Text;
using MailKit.Security;
using MailKit.Net.Smtp;

namespace Lab05
{
    public partial class SendMailViaGmail : Form
    {

        public SendMailViaGmail()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Khai báo email
            var email = new MimeMessage();

            //Thực hiện build phần body của email trước.
            var builder = new BodyBuilder();
            builder.TextBody = mail.Text;
            string[] attachments = attach.Text.Split(';');
            foreach (string attachment in attachments)
                if (attachment != "")
                    builder.Attachments.Add(attachment);
            email.Body = builder.ToMessageBody();

            //Set up gửi BCC hay CC
            string[] mailto = this.mailto.Text.Split(';');
            foreach (string mailtos in mailto)
            {
                if (bcccheck.Checked)
                    email.Bcc.Add(MailboxAddress.Parse(mailtos));
                else email.To.Add(MailboxAddress.Parse(mailtos));
            }
            
            //Thực hiện build các phần còn lại của email.
            email.From.Add(MailboxAddress.Parse(mailfrom.Text));
            email.Subject = subject.Text;
                
            // send email
            using (var smtp = new MailKit.Net.Smtp.SmtpClient())
            {
                smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                smtp.Authenticate(mailfrom.Text, password.Text);
                smtp.Send(email);
                smtp.Disconnect(true);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                attach.Text += file + ";";
            }
        }
    }
}
