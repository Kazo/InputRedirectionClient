using System;

namespace InputRedirectionNTR
{
    public class ScriptHelper
    {
        public Boolean connect(string host, int port)
        {
            Program.ntrClient.setServer(host, port);
            return Program.ntrClient.connectToServer();
        }

        public void disconnect()
        {
            Program.ntrClient.disconnect();
        }

        public void write(uint addr, byte[] buf, int pid = -1)
        {
            Program.ntrClient.sendWriteMemPacket(addr, (uint)pid, buf);
        }
    }
}