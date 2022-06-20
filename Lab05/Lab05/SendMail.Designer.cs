namespace Lab05
{
    partial class SendMail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mailfrom = new System.Windows.Forms.TextBox();
            this.mailto = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.RichTextBox();
            this.send = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.bcccheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(555, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(23, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subject:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(23, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Body:";
            // 
            // mailfrom
            // 
            this.mailfrom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mailfrom.ForeColor = System.Drawing.Color.Navy;
            this.mailfrom.Location = new System.Drawing.Point(101, 31);
            this.mailfrom.Name = "mailfrom";
            this.mailfrom.Size = new System.Drawing.Size(429, 30);
            this.mailfrom.TabIndex = 5;
            // 
            // mailto
            // 
            this.mailto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mailto.ForeColor = System.Drawing.Color.Navy;
            this.mailto.Location = new System.Drawing.Point(101, 74);
            this.mailto.Name = "mailto";
            this.mailto.Size = new System.Drawing.Size(429, 30);
            this.mailto.TabIndex = 6;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.password.ForeColor = System.Drawing.Color.Navy;
            this.password.Location = new System.Drawing.Point(654, 31);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(250, 30);
            this.password.TabIndex = 7;
            this.password.UseSystemPasswordChar = true;
            // 
            // subject
            // 
            this.subject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.subject.ForeColor = System.Drawing.Color.Navy;
            this.subject.Location = new System.Drawing.Point(111, 191);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(793, 30);
            this.subject.TabIndex = 8;
            // 
            // mail
            // 
            this.mail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mail.ForeColor = System.Drawing.Color.Navy;
            this.mail.Location = new System.Drawing.Point(111, 236);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(793, 289);
            this.mail.TabIndex = 9;
            this.mail.Text = "";
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.Color.Navy;
            this.send.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.send.ForeColor = System.Drawing.Color.White;
            this.send.Location = new System.Drawing.Point(716, 123);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(188, 43);
            this.send.TabIndex = 10;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(555, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "BCC?";
            // 
            // bcccheck
            // 
            this.bcccheck.AutoSize = true;
            this.bcccheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bcccheck.Location = new System.Drawing.Point(654, 81);
            this.bcccheck.Name = "bcccheck";
            this.bcccheck.Size = new System.Drawing.Size(18, 17);
            this.bcccheck.TabIndex = 12;
            this.bcccheck.UseVisualStyleBackColor = true;
            // 
            // SendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 587);
            this.Controls.Add(this.bcccheck);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.send);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.password);
            this.Controls.Add(this.mailto);
            this.Controls.Add(this.mailfrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SendMail";
            this.Text = "SendMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mailfrom;
        private System.Windows.Forms.TextBox mailto;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.RichTextBox mail;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox bcccheck;
    }
}

