using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace Lab3_bai5
{
    public partial class Server : Form
    {
        private int count = 0;
        private TcpListener server;
        private Thread serverThread;
        private Dictionary<string, TcpClient> connectedClients = new Dictionary<string, TcpClient>();
        private bool shouldStop = false;
        private byte[] buffer = new byte[1024];
        public Server()
        {
            InitializeComponent();
        }
        private void listenBtt_Click(object sender, EventArgs e)
        {
            server = new TcpListener(IPAddress.Loopback, 8080);
            server.Start();
            serverThread = new Thread(new ThreadStart(ListenForClients));
            serverThread.Start();
            emptySeatsLabel.Text = "Server Started";
        }
        private void ListenForClients()
        {
            while (!shouldStop) 
            {
                TcpClient client = server.AcceptTcpClient();
                Thread clientThread = new Thread(() => Booking(client));
            }
            serverThread.Abort();
        }
        private void Booking(TcpClient client)
        {
            int bytesRead = client.GetStream().Read(buffer, 0, buffer.Length);
            string username = "";
            int SoGhe = -1;
            string Ten = "";
            if (bytesRead > 0)
            {
                username = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                connectedClients.Add(username, client);
                count++;
                connectedClientLabel.Text = count.ToString();
                selectedSeatsLabel.Text = username + "connected";
            }
            while (!shouldStop && username != null)
            {
                bytesRead = client.GetStream().Read(buffer, 0, buffer.Length);
                if (bytesRead == 0)
                {
                    break; 
                }

                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                if (message.Contains(":"))
                {
                    Ten = message.Split(":")[0];
                    SoGhe = int.Parse(message.Split(":")[1]);
                    SendMessageToClients(Ten, SoGhe);
                    UpdateTable(Ten, SoGhe);
                }             
            }
            if (username != null)
            {
                connectedClients.Remove(username);
                count--;
                connectedClientLabel.Text = count.ToString();
            }

            client.Close();
        }
        private void SendMessageToClients(string Ten, int SoGhe)
        {
            foreach (var client in connectedClients)
            {
                client.Value.GetStream().Flush();
                client.Value.GetStream().Write(buffer,0,);
            }
        }
        private void UpdateTable(string Ten, int SoGhe)
        {
            if (SoGhe >= 1 && SoGhe <= 30)
            {
                CheckBox checkBox = (CheckBox)this.Controls.Find("checkBox" + SoGhe, true).FirstOrDefault();
                if (checkBox != null)
                {
                    if (!checkBox.Checked)
                    {
                        checkBox.Checked = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Nhap sai so ghe quy dinh");
            }

        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            shouldStop = true;
            server.Stop();
            emptySeatsLabel.Text = "Stopped";
        }
    }
}
