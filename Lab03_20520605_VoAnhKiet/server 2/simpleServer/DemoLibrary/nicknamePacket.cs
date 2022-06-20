using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    [Serializable]
    public class nicknamePacket : packet
    {
        public string nickName = String.Empty;
        public nicknamePacket (string nickname)
        {
            this.type = packetType.NICKNAME;
            this.nickName = nickname;
        }
    }
}
