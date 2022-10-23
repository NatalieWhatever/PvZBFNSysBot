using System.Net;
using System.Net.Sockets;
using System.Text;
using System;
using System.Windows.Forms;

namespace PvZBFNSysBot.Network
{
    internal class ConnectionManager
    {
        private Socket? sysSocket;
        internal bool IsSwitchConnected => sysSocket != null && sysSocket.Connected;

        internal bool TryConnect(string ipAddress, int port, out string error)
        {
            IPEndPoint endPoint;
            if (!IPAddress.TryParse(ipAddress, out IPAddress? ip))
            {
                error = "Not a valid IP address.";
                return false;
            }

            sysSocket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sysSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            endPoint = new IPEndPoint(ip, port);
            IAsyncResult result = sysSocket.BeginConnect(endPoint, null, null);

            bool connectionSuccess = result.AsyncWaitHandle.WaitOne(3000, true);
            if (connectionSuccess)
            {
                try
                {
                    sysSocket.EndConnect(result);
                }
                catch (Exception ex)
                {
                    sysSocket.Close();
                    error = ex.ToString();
                    return false;
                }

                error = string.Empty;
                return true;
            }

            sysSocket.Close();
            error = "Time out. There was nothing at the specified IP address.";
            return false;
        }

        public byte[]? PeekAddress(string address, int size)
        {
            if (sysSocket == null || !IsSwitchConnected)
            {
                return null;
            }

            string message = $"peek 0x{address} {size}\r\n";
            byte[] messageBytes = Encoding.ASCII.GetBytes(message);
            sysSocket.Send(messageBytes);

            byte[] buffer = new byte[(size * 2) + 1];
            ReceiveBytes(buffer);

            return DecoderUtil.ConvertHexByteStringToBytes(buffer);
        }

        public byte[]? PeekMainAddress(string address, int size)
        {
            if (sysSocket == null || !IsSwitchConnected)
            {
                return null;
            }

            string message = $"peekMain 0x{address} {size}\r\n";
            byte[] messageBytes = Encoding.ASCII.GetBytes(message);
            sysSocket.Send(messageBytes);

            byte[] buffer = new byte[(size * 2) + 1];
            ReceiveBytes(buffer);
            return DecoderUtil.ConvertHexByteStringToBytes(buffer);
        }

        public byte[]? PeekMainAddress(long address, int size)
        {
            return PeekMainAddress($"{address:x8}", size);
        }

        public byte[]? PeekAbsoluteAddress(string address, int size)
        {
            if (sysSocket == null || !IsSwitchConnected)
            {
                return null;
            }

            string message = $"peekAbsolute 0x{address} {size}\r\n";
            byte[] messageBytes = Encoding.ASCII.GetBytes(message);
            sysSocket.Send(messageBytes);

            byte[] buffer = new byte[(size * 2) + 1];
            ReceiveBytes(buffer);
            return DecoderUtil.ConvertHexByteStringToBytes(buffer);
        }

        public byte[]? PeekAbsoluteAddress(long address, int size)
        {
            return PeekAbsoluteAddress($"{address:x8}", size);
        }

        public void PokeAddress(string address, string data)
        {
            SendMessage($"pokeMain 0x{address} 0x{data}\r\n");
        }

        public void PokeAddress(long address, string data)
        {
            PokeAddress($"{address:x8}", data);
        }

        public void PokeAbsoluteAddress(string address, string data)
        {
            SendMessage($"pokeAbsolute 0x{address} 0x{data}\r\n");
        }

        public void PokeAbsoluteAddress(long address, string data)
        {
            PokeAbsoluteAddress($"{address:x16}", data);
        }

        public void PokeMain(long offset, string data)
        {
            if (sysSocket == null || !IsSwitchConnected)
            {
                return;
            }

            string message = $"pokeMain 0x{offset:x16} 0x{data}\r\n";
            byte[] messageBytes = Encoding.ASCII.GetBytes(message);
            sysSocket.Send(messageBytes);
        }

        internal string SendCommandAsIs(string command, int bufferSize)
        {
            if (sysSocket == null || !IsSwitchConnected)
            {
                return string.Empty;
            }

            string message = $"{command}\r\n";
            byte[] messageBytes = Encoding.ASCII.GetBytes(message);
            sysSocket.Send(messageBytes);

            byte[] buffer = new byte[bufferSize];
            ReceiveBytes(buffer);
            return Encoding.ASCII.GetString(buffer).ToUpper();
        }

        public void SendMessage(string message)
        {
            if (sysSocket == null || !IsSwitchConnected)
            {
                return;
            }

            byte[] messageBytes = Encoding.ASCII.GetBytes(message);
            sysSocket.Send(messageBytes);
        }

        private void ReceiveBytes(byte[] buffer)
        {
            if (sysSocket == null)
            {
                return;
            }

            int bytesReceived = sysSocket.Receive(buffer, 0, 1, SocketFlags.None);
            try
            {
                while (buffer[bytesReceived - 1] != (byte)'\n')
                {
                    bytesReceived += sysSocket.Receive(buffer, bytesReceived, 1, SocketFlags.None);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error while receiving bytes:\r\n{ex}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void TryDisconnect()
        {
            if (sysSocket == null)
            {
                return;
            }

            try
            {
                IAsyncResult result = sysSocket.BeginDisconnect(true, null, null);

                bool disconnectionSuccess = result.AsyncWaitHandle.WaitOne(3000, true);
                if (disconnectionSuccess)
                {
                    sysSocket.EndDisconnect(result);
                }

                sysSocket.Close();
            }
            catch (Exception ex)
            {
                // TODO Program.GetLoggingInstance().LogException(ex, "(TryDisconnect)");
            }
        }
    }
}
