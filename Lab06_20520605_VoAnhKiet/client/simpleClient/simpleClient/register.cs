using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleClient
{
    public partial class register : Form
    {
        OleDbConnection dbConnect = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\excerciseCsharp\Lab03_20520605_VoAnhKiet\client\simpleClient\simpleClient\bin\Debug\db_user.mdb");
        OleDbCommand dbCommand = new OleDbCommand();
        OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter();
        public register()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login tmpForm = new login();
            tmpForm.Closed += (s, args) => this.Close();
            tmpForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (enterUser.Text == "" && enterPass.Text == "" && confirmPass.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty");
            }
            else if (enterPass.Text == confirmPass.Text)
            {
                dbConnect.Open();
                string register = "INSERT INTO Table1 VALUES ('" + enterUser.Text + "','" + enterPass.Text + "')";
                dbCommand = new OleDbCommand(register, dbConnect);
                dbCommand.ExecuteNonQuery();
                dbConnect.Close();

                enterUser.Text = "";
                enterPass.Text = "";
                confirmPass.Text = "";
                MessageBox.Show("Successfully Regist!");
            }
            else
            {
                MessageBox.Show("Password does not match!");
                enterPass.Text = "";
                confirmPass.Text = "";
                enterPass.Focus();
            }    

        }
    }
}
