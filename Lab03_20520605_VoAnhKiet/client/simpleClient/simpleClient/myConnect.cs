using DemoLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleClient
{
    public class myConnect
    {
        private clientForm form;
        private TcpClient tcpClient;
        private NetworkStream stream;
        private BinaryWriter writer;
        private BinaryReader reader;
        private Thread thread;

        public void sendFunc(packet data)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(memoryStream, data);
            byte[] buffer = memoryStream.GetBuffer();

            writer.Write(buffer.Length);
            writer.Write(buffer);
            writer.Flush();
        }
        public void sendText(string str)
        {
            if (tcpClient.Connected == false)
            {
                return;
            }
            chatPacket chat = new chatPacket(str);
            sendFunc(chat);
        }
        private void setUpNickName(string nickname)
        {
            nicknamePacket chatPac = new nicknamePacket(nickname);
            sendFunc(chatPac);
        }
        private delegate void AppendTextDelegate(string str);
        private void outputText(string text)
        {
            form.Invoke(new AppendTextDelegate(form.appendText), new object[] { text });
        }

        private void processSeverRespone()
        {
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                int numberInputByte;
                while ((numberInputByte = reader.ReadInt32()) != 0)
                {
                    byte[] bytes = reader.ReadBytes(numberInputByte);
                    MemoryStream memoryStream = new MemoryStream(bytes);
                    packet packet = binaryFormatter.Deserialize(memoryStream) as packet;

                    switch(packet.type)
                    {
                        case packetType.CHATMESSAGE:
                            string message = ((chatPacket)packet).message;
                            outputText(message);
                            break;
                    }    
                }    
            }
            catch (Exception exc)
            {
                outputText("Caution: " + exc.Message);
            }
        }
        
        public bool makeConnect(clientForm cform, string hostname, int port, string nickname)
        {
            try
            { 

                form = cform;
                tcpClient = new TcpClient();
                tcpClient.Connect(hostname, port);
                stream = tcpClient.GetStream();
                writer = new BinaryWriter(stream, Encoding.UTF8);
                reader = new BinaryReader(stream, Encoding.UTF8);
                
                setUpNickName(nickname);

                thread = new Thread(new ThreadStart(processSeverRespone));
                thread.Start();
            }
            catch (Exception exc)
            {
                outputText("Exception: " + exc.Message);
                return false;
            }

            return true;
        }

        public void makeDisconnect()
        {
            try
            {
                reader.Close();
                writer.Close();
                tcpClient.Close();
                thread.Abort();
            }
            catch (Exception exc)
            {
                outputText("Caution: " + exc.Message);
            }
            outputText("Disconnect");
        }
    }
}
