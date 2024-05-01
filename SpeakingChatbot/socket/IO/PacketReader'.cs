using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Net.Sockets;


namespace SpeakingChatbot.socket.IO {
    internal class PacketReader : BinaryReader {

        private NetworkStream ns;

        public PacketReader(NetworkStream _ns) : base(_ns) {
            ns = _ns;
        }

        // read the msg
        public string ReadMsg() {
            byte[] msgBuffer;
            var length = ReadInt32();

            msgBuffer = new byte[length];
            ns.Read(msgBuffer, 0, length);

            var msg = Encoding.ASCII.GetString(msgBuffer);

            return msg;
        }
    }
}
