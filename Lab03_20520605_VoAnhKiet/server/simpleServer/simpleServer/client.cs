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


namespace simpleServer
{
    public class client
    {
        public Socket Socket { get; private set; }
        public NetworkStream Stream { get; private set; }
        public BinaryReader Reader { get; private set; }
        public BinaryWriter Writer { get; private set; }
        public string NickName { get; private set; }

        private Thread thread;

        public client(Socket socket)
        {
            Socket = socket;
            Stream = new NetworkStream(Socket, true);
            Writer = new BinaryWriter(Stream, Encoding.UTF8);
            Reader = new BinaryReader(Stream, Encoding.UTF8);
        }

        public void sendFunc(packet data)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(memoryStream, data);
            byte[] buffer = memoryStream.GetBuffer();

            Writer.Write(buffer.Length);
            Writer.Write(buffer);
            Writer.Flush();
        }

        private void socketMethod()
        {
            server.socketMethod(this);
        }

        public void start()
        {
            thread = new Thread(new ThreadStart(socketMethod));
            thread.Start();
        }

        public void stop(bool aThread = false)
        {
            Socket.Close();
            if (thread.IsAlive)
                thread.Abort();
        }

        public void setupNickName(string nickName)
        {
            this.NickName = nickName;
        }        

        public void sendText(client dataFromClient, string text)
        {
            if(Socket.Connected == false)
            {
                return;
            }
            string message = "*" + text + "*";
            if (dataFromClient.NickName !=  null)
            {
                message = dataFromClient.NickName + ": " + text;
            }
            chatPacket chat = new chatPacket(message);
            sendFunc(chat);
        }

    }
}
