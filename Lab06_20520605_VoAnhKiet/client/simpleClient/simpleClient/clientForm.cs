using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleClient
{
    public partial class clientForm : Form
    {
        private myRoom room1;
        private myRoom room2;
        private myRoom room3;
        private myRoom room4;
        private myRoom room5;
        private myRoom roomSelect = null;
        
        public clientForm()
        {
            InitializeComponent();
            room1 = new myRoom("Room 1", "127.0.0.1", 1111);
            room2 = new myRoom("Room 2", "127.0.0.1", 2222);
            room3 = new myRoom("Room 3", "127.0.0.1", 3333);
            room4 = new myRoom("Room 4", "127.0.0.1", 4444);
            room5 = new myRoom("Room 5", "127.0.0.1", 5555);
            
        }

        public void appendText(string str)
        {
            richTextBox1.Text += str + "\n";
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }
        string checkConnect(myRoom room)
        {
            bool value1 = room.connectGetSet;

            if (value1)
            {
                return " (connected)";
            }
            else
            {
                return "";
            }
        }
        void refreshTheList()
        {
            listBox1.Items.Clear();

            string[] myRoomsList = new string[5];

            myRoomsList[0] = room1.nameGetSet + checkConnect(room1);
            myRoomsList[1] = room2.nameGetSet + checkConnect(room2);
            myRoomsList[2] = room3.nameGetSet + checkConnect(room3);
            myRoomsList[3] = room4.nameGetSet + checkConnect(room4);
            myRoomsList[4] = room5.nameGetSet + checkConnect(room5);

            listBox1.Items.AddRange(myRoomsList);
        }
        void connectRoom(myRoom room, bool disconnect)
        {
            if(room.connectGetSet == false)
            {
                bool connect = room.myConnectRoomGetSet.makeConnect(this, room.addressGetSet, room.portGetSet, textBox2.Text);
                if(connect == true)
                {
                    button1.Text = "Disconnect";
                    room.connectGetSet = true;
                    //roomSelect.myConnectRoomGetSet.sendText("*join the room");
                }    
            }
            else if (disconnect == true)
            {
                //roomSelect.myConnectRoomGetSet.sendText("left the room");
                room.myConnectRoomGetSet.makeDisconnect();
                room.connectGetSet = false;
                button1.Text = "Connect";                
            }
            refreshTheList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connectRoom(roomSelect, true);
        }

        private void clientForm_Load(object sender, EventArgs e)
        {
            refreshTheList();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (roomSelect.connectGetSet == false)
            {
                return;
            }
            string enc = myTransformer1.Encrypt(textBox1.Text);
            roomSelect.myConnectRoomGetSet.sendText(enc);
            textBox1.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value1 = listBox1.SelectedIndex;
            switch(value1)
            {
                case 0:
                    roomSelect = room1;
                    break;
                case 1:
                    roomSelect = room2;
                    break;
                case 2:
                    roomSelect = room3;
                    break;
                case 3:
                    roomSelect = room4;
                    break;
                case 4:
                    roomSelect = room5;
                    break;
            }  
            
            if (roomSelect.connectGetSet == false)
            {
                button1.Text = "Connect";
            }    
            else
            {
                button1.Text = "Disconnect";
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login tmpForm = new login();
            tmpForm.Closed += (s, args) => this.Close();
            tmpForm.Show();
        }
    }
}
