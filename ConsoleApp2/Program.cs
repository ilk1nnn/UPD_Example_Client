using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var socket = new Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);
            var ip = IPAddress.Loopback;


            var port = 27001;


            EndPoint endpoint = new IPEndPoint(ip, port);


            try
            {
                while (true)
                {
                    var text = Console.ReadLine();
                    var bytes = Encoding.UTF8.GetBytes(text);
                    socket.SendTo(bytes, endpoint);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("can not connect to server");
            }








        }
    }
}
