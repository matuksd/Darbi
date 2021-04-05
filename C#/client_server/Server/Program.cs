using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var listeningSocket = new
            Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            var localEndpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            listeningSocket.Bind(localEndpoint);
            listeningSocket.Listen(1); // neaizvērsim, lai varētu secīgi apkalpot vairākus klientus
            Console.WriteLine("Waiting for requests...\n");
            //var connectedSocket = listeningSocket.Accept();
            //listeningSocket.Close();
            string EnWord = "";


            while (EnWord != "quit")  // sesija beidzas, kad klients atsūtīs "stop"
            {
                var connectedSocket = listeningSocket.Accept();
                //listeningSocket.Close();
                var buffer = new byte[1024];   // saņemt vārdu angļu valodā EnWord
                int requestSize = connectedSocket.Receive(buffer);
                EnWord = Encoding.ASCII.GetString(buffer, 0, requestSize);
                string response = "";  // pārtulkot vārdu un nosūtīt klientam
                string GramNos = "";
                int vieta = 0;
                int punkts1 = 0;
                int pp = 0;
                string text = "";
                int punkts2 = 0;
                string teksts = "";
                if (EnWord == "Help") response = "Hi! I can translate En -> Lv ";
                else if (EnWord == "list")
                {
                    string[] filePaths = Directory.GetFiles(@"c:\githubs\");
                    response += "Gramatu saraksts: \n";
                    foreach (string dir in filePaths)
                    {
                        string gramata = "";
                        for (int f = 11; f < dir.Length; f++)
                        {
                            gramata += dir[f];
                        }
                        int s = 0;
                        while (s < 4)
                        {
                            gramata = gramata.Remove(gramata.Length - 1);
                            s++;
                        }
                        response += gramata + "\n";
                    }
                }
                else if (EnWord.Contains("lookup"))
                {
                    string vards = "";
                    string[] filePaths = Directory.GetFiles(@"c:\githubs\");

                    for (int i = 7; i < EnWord.Length; i++)
                    {
                        vards += EnWord[i];
                    }
                    response += "Gramatas kuras nosaukums iekļauj " + vards + " vardu: \n"; 
                    foreach (string dir in filePaths)
                    {
                        if (dir.Contains(vards))
                        {
                            
                            string gramata = "";
                            for (int f = 11; f < dir.Length; f++)
                            {
                                gramata += dir[f];
                            }
                            int s = 0;
                            while (s < 4)
                            {
                                gramata = gramata.Remove(gramata.Length - 1);
                                s++;
                            }
                            response += gramata + "\n";
                        }
                    }
                }
                else if (EnWord.Contains("query "))
                {
                    string vards = "";
                    int garums = 0;
                   
                    for (int i = 6; i < EnWord.Length; i++)
                    {
                        vards += EnWord[i];
                    }
                    response += "Gramata un teikums pēc vārda "+ vards+"\n";
                    string[] filePaths = Directory.GetFiles(@"c:\githubs\");

                    foreach (string dir in filePaths)
                    {
                        text = System.IO.File.ReadAllText(@"" + dir);
                        if (text.Contains(vards))
                        {


                            garums = text.Length;
                            Console.WriteLine(text.Length);
                            Console.WriteLine(text);
                            if (text.Contains(vards))
                            {
                                vieta = text.IndexOf(vards);
                                //response += dir + "  -  " + teksts;



                                for (int i = 0; i < garums; i++)
                                {
                                    if (text[i] == '.' && pp == 0)
                                    {
                                        punkts1 = i;
                                        pp++;

                                    }
                                    
                                    // response += punkts1 + "  -  "+ vieta + "  -  " + text.Length;
                                    else if (text[i] == '.' && pp == 1)
                                    {
                                        punkts2 = i;
                                        pp = 0;
                                    }
                                    
                                    /* else if (punkts1 > vieta && punkts2 == 0)
                                     {
                                          for (int k = 0; k < punkts1; k++)
                                          {
                                               teksts += text[k];
                                          }

                                     }*/

                                    /* else if (punkts2 > vieta && punkts1 < vieta)
                                     {
                                         for (int k = punkts1; k < punkts2; k++)
                                         {
                                             response += text[k];
                                         }
                                     }*/

                                }
                                string gramata = "";
                                for (int f = 11; f < dir.Length; f++)
                                {
                                    gramata += dir[f];
                                }
                                int s = 0;
                                while (s < 4)
                                {   gramata = gramata.Remove(gramata.Length - 1);
                                    s++;
                                }
                                response += gramata + "  -  ";
                                if (punkts1 > vieta && punkts2 == 0)
                                {
                                    for (int k = 0; k < punkts1; k++)
                                    {
                                        response += text[k];
                                    }
                                    response += ". \n";
                                }
                                else if (punkts1 < vieta && punkts2 > vieta)
                                {
                                    for (int k = punkts1; k < punkts2; k++)
                                    {
                                        response += text[k];
                                    }
                                    response += ". \n";
                                }
                                else if (punkts1 > vieta && punkts2 < vieta)
                                {
                                    for (int k = punkts2; k < punkts1; k++)
                                    {
                                        response += text[k];
                                    }
                                    response += ". \n";
                                }
                            }
                        }
                    }
                    
                }
                        
                    //response += "   " + punkts1 + "  -  " + vieta + "  -  " + garums+ "   " + vards + "  ";
                        //Console.WriteLine(teksts);
                    
                    /*string text = System.IO.File.ReadAllText(@"" + dir);
                    if (text.Contains(vards))
                    {
                        for(int i =0; i<text.Length;i++)
                        {
                            if(text[i] == '.')
                            {

                            }
                        }
                    }
                    */

                
                
                connectedSocket.Send(Encoding.UTF8.GetBytes(response));
                Console.Write(response);

                // while (EnWord != "stop") – viena klienta pieprasījumu apstrādes cikls
                connectedSocket.Close();
            }
        }

    }
}
