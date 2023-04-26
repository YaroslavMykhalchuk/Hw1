using System.Configuration;
using System.Net.Sockets;
using System.Net;
using System.Text;

string serverIP = ConfigurationManager.AppSettings["ServerIP"];
string[] parts = serverIP.Split(":");
IPAddress address = IPAddress.Parse(parts[0]);
int port = Convert.ToInt32(parts[1]);

IPEndPoint endPoint = new IPEndPoint(address, port);

using (Socket server_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP))
{
    server_socket.Bind(endPoint);
    server_socket.Listen(10);

    Console.WriteLine($"Server was started on {port} port.");

    try
    {
        while (true)
        {
            Socket ns = server_socket.Accept();
            Console.WriteLine(ns.RemoteEndPoint.ToString());
            byte[] buffer = new byte[1024];
            ns.Receive(buffer);
            Console.WriteLine(Encoding.Default.GetString(buffer));
            ns.Send(Encoding.Default.GetBytes(DateTime.Now.ToString()));
            ns.Shutdown(SocketShutdown.Both);
            ns.Close();
        }
    }
    catch (SocketException ex)
    {
        Console.WriteLine(ex.Message);
    }
}