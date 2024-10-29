using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
namespace Client
{
    public partial class Client : Form
    {
        private string Ten;
        private int SoGhe;
        private TcpClient client;
        private Thread clientThread;
        private NetworkStream clientStream;
        private byte[] buffer = new byte[1024];
        public Client()
        {
            InitializeComponent();
        }

        private void connect_Btt_Click(object sender, EventArgs e)
        {
            client = new TcpClient(textBoxIP.Text, int.Parse(textBoxPort.Text));
            clientStream = client.GetStream();

            string username = textBoxUsername.Text;
            byte[] usernameBytes = Encoding.UTF8.GetBytes(username);
            clientStream.Write(usernameBytes, 0, usernameBytes.Length);
            clientStream.Flush();

            clientThread = new Thread(new ThreadStart(ClientListen));
            clientThread.Start();
        }
        private void ClientListen()
        {
            byte[] message = new byte[4096];
            int bytesRead;

            while (true)
            {
                bytesRead = clientStream.Read(message, 0, message.Length);

                if (bytesRead == 0)
                {
                    break;
                }

                string decodedMessage = Encoding.UTF8.GetString(message, 0, bytesRead);
                if (decodedMessage.Contains(":"))
                {
                    Ten = decodedMessage.Split(":")[0];
                    SoGhe = int.Parse(decodedMessage.Split(":")[1]);
                }
                UpdateTable(Ten, SoGhe);
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
                    else
                    {
                        MessageBox.Show("Ghe da duoc dat truoc");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nhap sai so ghe quy dinh");
            }
        }

        private void Booking(object sender, EventArgs e)
        {

        }
    }
}
