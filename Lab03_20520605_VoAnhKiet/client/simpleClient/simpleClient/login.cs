using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleClient
{
    public partial class login : Form
    {
        OleDbConnection dbConnect = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\excerciseCsharp\Lab03_20520605_VoAnhKiet\client\simpleClient\simpleClient\bin\Debug\db_user.mdb");
        OleDbCommand dbCommand = new OleDbCommand();
        OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter();
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbConnect.Open();
            string login = "SELECT * FROM Table1 WHERE username= '" + enterUser.Text + "' and password= '" + enterPass.Text + "'";
            dbCommand = new OleDbCommand(login, dbConnect);
            OleDbDataReader dbDataReader = dbCommand.ExecuteReader();

            if (dbDataReader.Read() == true)
            {
                this.Hide();
                var tmpForm = new clientForm();
                tmpForm.Closed += (s, args) => this.Close();
                tmpForm.Show();
                dbConnect.Close();
            }    
            else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again");
                enterUser.Text = "";
                enterPass.Text = "";
                enterUser.Focus();
                dbConnect.Close();
            }    
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            register tmpForm = new register();
            tmpForm.Closed += (s, args) => this.Close();
            tmpForm.Show();
        }
    }
}
