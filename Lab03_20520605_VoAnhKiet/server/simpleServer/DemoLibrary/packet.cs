//using DotNetty.Codecs.Mqtt.Packets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    [Serializable]
    public class packet
    {
        public packetType type = packetType.EMPTY;
    }
}
