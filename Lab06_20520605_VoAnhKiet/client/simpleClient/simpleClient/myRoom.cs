using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleClient
{
    public class myRoom
    {
        private string name;
        private string address;
        private int port;
        private bool connect;
        private myConnect myConnectRoom;

        public myRoom(string name, string address, int port)
        {
            this.name = name;
            this.address = address;
            this.port = port;
            this.connect = false;
            this.myConnectRoom = new myConnect();            
        }

        public string nameGetSet
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string addressGetSet
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public int portGetSet
        {
            get
            {
                return port;
            }
            set
            {
                port = value;
            }
        }

        public bool connectGetSet
        {
            get
            {
                return connect;
            }
            set
            {
                connect = value;
            }    
        }

        public myConnect myConnectRoomGetSet
        {  
            get
            {
                return myConnectRoom;
            }
            set
            {
                myConnectRoom = value;
            }
        }
    }
}
