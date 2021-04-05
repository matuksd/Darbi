using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Client2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var socket = new
            Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("localhost", 1234);
            string EnWord = ""; // angļu vārds - pieprasījums
            EnWord = textBox1.Text;
            var request = Encoding.ASCII.GetBytes(EnWord);
            socket.Send(request);
            var buffer = new byte[1024];
            int bytesReceived = socket.Receive(buffer);
            var response = Encoding.UTF8.GetString(buffer, 0, bytesReceived);
            richTextBox1.AppendText(response.ToString());
            socket.Close();

        }
    }
}
