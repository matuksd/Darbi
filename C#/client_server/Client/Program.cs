using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var socket = new
Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("localhost", 1234);
            string EnWord = ""; // angļu vārds - pieprasījums
            while (EnWord != "stop")   // sesija turpinās līdz "stop" ievadei
            {
                Console.Write("Enter: ");
                EnWord = Console.ReadLine();
                var request = Encoding.ASCII.GetBytes(EnWord);
                socket.Send(request);
                // saņemt atbildi
                var buffer = new byte[1024];
                int bytesReceived = socket.Receive(buffer);
                var response = Encoding.UTF8.GetString(buffer, 0, bytesReceived);
                Console.WriteLine("Received: {0}", response);
            }  // while (EnWord != "stop")
            socket.Close();


        }
    }
}
