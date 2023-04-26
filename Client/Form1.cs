using System.Diagnostics;
using System.Configuration;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Client
{
    public partial class Form1 : Form
    {
        private readonly string connectionIP;
        private readonly string[] parts;
        public Form1()
        {
            InitializeComponent();

            connectionIP = ConfigurationManager.AppSettings["ServerIP"];
            parts = connectionIP.Split(":");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process.Start("Server.exe");
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            IPAddress address = IPAddress.Parse(parts[0]);
            IPEndPoint endPoint = new IPEndPoint(address, Convert.ToInt32(parts[1]));
            
            using(Socket client_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP))
            {
                try
                {
                    client_socket.Connect(endPoint);

                    if (client_socket.Connected)
                    {
                        string query = textBoxSend.Text;
                        client_socket.Send(Encoding.Default.GetBytes(query));
                        byte[] buffer = new byte[1024];
                        int len;
                        do
                        {
                            len = client_socket.Receive(buffer);
                            textBoxReceivingData.Text += $"Answer from server {client_socket.RemoteEndPoint} :: data from client was received at {Encoding.Default.GetString(buffer, 0, len)}{Environment.NewLine}";
                            
                        } while (client_socket.Available > 0);
                    }
                    else
                    {
                        MessageBox.Show("Error connection!");
                    }
                }
                catch (SocketException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    client_socket.Close();
                }
            }
            textBoxSend.Text = string.Empty;
        }
    }
}