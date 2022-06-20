using DemoLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace simpleServer
{
    class server
    {
        int portSimpleServer;
        TcpListener tcpListener;
        static List<client> clients = new List<client>();

        public server(string ipAddress, int port)
        {
            portSimpleServer = port;
            IPAddress ip = IPAddress.Parse(ipAddress);
            tcpListener = new TcpListener(ip, port);
        }

        public void start()
        {
            tcpListener.Start();

            Console.WriteLine("Port: " + Convert.ToString(portSimpleServer));

            while(true)
            {
                Socket socket = tcpListener.AcceptSocket();
                client client = new client(socket);
                clients.Add(client);
                client.start();
            }    
        }

        public void stop()
        {
            foreach (client element in clients)
            {
                element.stop();
            }
            tcpListener.Stop();
        }
        public static void socketMethod(client dataFromClient)
        {
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Socket socket = dataFromClient.Socket;
                NetworkStream stream = dataFromClient.Stream;
                BinaryReader binaryReader = dataFromClient.Reader;
                //dataFromClient.sendText(dataFromClient, "Successful Connection");

                int numberInputBytes;
                while((numberInputBytes = binaryReader.ReadInt32()) != 0 )
                {
                    byte[] bytes = binaryReader.ReadBytes(numberInputBytes);
                    MemoryStream memoryStream = new MemoryStream(bytes);
                    packet packet = binaryFormatter.Deserialize(memoryStream) as packet;

                    switch (packet.type)
                    {
                        case packetType.NICKNAME:
                            string nickName = ((nicknamePacket)packet).nickName;
                            dataFromClient.setupNickName(nickName);
                            break;

                        case packetType.CHATMESSAGE:
                            string message = ((chatPacket)packet).message;
                            Console.WriteLine("<" + dataFromClient.NickName + ">: " + message);
                            foreach(client element in clients)
                            {
                                element.sendText(dataFromClient, message);
                            }
                            break;
                    }    
                }    

            }
            catch (Exception exc)
            {
                Console.WriteLine("Caution: " + exc.Message);
            }
            finally
            {
                dataFromClient.stop();
            }
        }
    }
}
