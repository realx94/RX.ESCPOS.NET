using SimpleTCP;
using System.IO;

namespace RX.ESCPOS.NET.Utils
{
    public class TCPConnection
    {
        public Stream ReadStream { get; private set; } = new EchoStream();
        public Stream WriteStream { get; private set; }

        private SimpleTcpClient _client;
        //public event EventHandler<DataReceivedEventArgs> DataReceived;
        public TCPConnection(string ip, int port)
        {
            _client = new SimpleTcpClient();
            _client.DataReceived += DataReceivedEventHandler;
            ReadStream.ReadTimeout = 1500;
            _client.Connect(ip, port);
            WriteStream = new InterceptableWriteMemoryStream(bytes => _client.Write(bytes));
        }

        private void DataReceivedEventHandler(object sender, Message e)
        {
            ReadStream.Write(e.Data, 0, e.Data.Length);
        }

        ~TCPConnection()
        {
            try
            {
                _client.DataReceived -= DataReceivedEventHandler;
                _client?.Dispose();
            }
            catch { }
        }

    }
}
