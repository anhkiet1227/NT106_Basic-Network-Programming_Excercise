using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    [Serializable]
    public class chatPacket : packet
    {
        public string message = String.Empty;
        public chatPacket(string message)
        {
            this.type = packetType.CHATMESSAGE;
            this.message = message;
        }
    }
}