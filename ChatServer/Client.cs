using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;

namespace ChatServer {
    class Client {
        public string userName { get; set; }
        public Guid UID { get; set; }
        public int id { get; set; }
        public TcpClient clientSocket { get; set; }

        Net.IO.PacketReader packetReader;

        public Client(TcpClient client) {
            clientSocket = client;
            UID = Guid.NewGuid();

            packetReader = new Net.IO.PacketReader(clientSocket.GetStream());

            var opCode = packetReader.ReadByte();
            userName = packetReader.ReadMsg();


            Console.WriteLine($"[{DateTime.Now}]: {userName} has connected");

            Task.Run(() => Process());
        }

        void Process() {
            while(true) {
                try {
                    var opCode = packetReader.ReadByte();

                    switch(opCode) {
                        case 5:
                            var msg = packetReader.ReadMsg();
                            Console.WriteLine($"[{DateTime.Now}]: message received: {msg} from {UID}");
                            Server.BroadcastMsg(msg, UID.ToString());
                            break;
                        default:
                            break;

                    }
                } catch(Exception) {
                    Console.WriteLine($"[{UID.ToString()}]: Disconnected");
                    Server.BroadcastDisconnect(UID.ToString());
                    clientSocket.Close();
                    break;
                }
            }
        }


    }
}
