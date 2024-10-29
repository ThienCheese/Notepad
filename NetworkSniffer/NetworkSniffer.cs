using System.Net.Sockets;
using System.Net;
using System.Text;
using System;
using PacketDotNet;
using ProtocolType = System.Net.Sockets.ProtocolType;


namespace NetworkSniffer
{
    public partial class NetworkSniffer : Form
    {
        private CancellationToken cancellationToken_1;
        private CancellationToken cancellationToken_2;
        IPAddress defaultgateway = IPAddress.Parse($"{192}.{168}.{1}.{0}");
        public NetworkSniffer()
        {
            InitializeComponent();
        }
        private async Task Sniff(IPAddress target)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.IP);
            socket.Bind(new IPEndPoint(target, 0));
            socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.HeaderIncluded, true);

            byte[] bytesin = new byte[4] { 1, 0, 0, 0 };
            byte[] bytesout = new byte[4];
            socket.IOControl(IOControlCode.ReceiveAll, bytesin, bytesout);

            Task Listen = new Task(() =>
            {
                while (!cancellationToken_2.IsCancellationRequested)
                {
                    int buffersize = socket.ReceiveBufferSize;
                    byte[] buffer = new byte[buffersize];
                    int bytesRead = socket.Receive(buffer, buffer.Length, SocketFlags.None);

                    if (bytesRead > 0)
                    {
                        IPv4Packet packet = new(target, defaultgateway);
                        string ptcl = packet.Protocol.ToString();
                        byte[] content = new byte[8192];

                        content = packet.PayloadData;
                        string decoded_content = BitConverter.ToString(content);
                        richTextBox1.Invoke(() =>
                        {
                            richTextBox1.AppendText(decoded_content);
                        });
                    }
                }

            }, cancellationToken_2);
            Listen.Start();
            await Listen;
            richTextBox1.AppendText("Finished");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPAddress target = IPAddress.Parse(textBox1.Text);
            _ = Sniff(target);
        }
    }

}

