﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeakingChatbot.socket.IO {
    internal class PacketBuilder {
        MemoryStream ms;

        public PacketBuilder() {
            ms = new MemoryStream();
        }

        public void WriteOpCode(byte opCode) {
            ms.WriteByte(opCode);
        }

        public void WriteMsg(string msg) {

            int msgLength = msg.Length;

            ms.Write(BitConverter.GetBytes(msgLength));
            ms.Write(Encoding.ASCII.GetBytes(msg));

        }

        public byte[] GetPacketBytes() {
            return ms.ToArray();
        }
    }
}
