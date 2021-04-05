using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arhivators
{
    class Program
    {
        static void Main(string[] args)
        {   int SK=0;
            do { 
            Console.WriteLine("\nAutors: Dinars Matuks");
            Console.WriteLine("1. Arhivet failu WriteText");
            Console.WriteLine("2. Izarhivet failu WriteText");
            Console.WriteLine("3. Exit");

            
            string SK2 = Console.ReadLine();
            if (SK2 == "1")
            {
                SK = 1;
            }
            else if (SK2 == "2")
            {
                SK = 2;
            }
            else if (SK2 == "3")
            {
                SK = 3;
            }
            else Console.WriteLine("Entered wrong option");
                switch (SK)
                {
                    case 1:
                        string text = System.IO.File.ReadAllText(@"C:\Arhivators\WriteText.txt");
                        text += " ";
                        string text2 = "";
                        int sk = 1;
                        for (int i = 0; i < text.Length - 1; i++)
                        {

                            if (text[i] == text[i + 1])
                            {
                                sk++;

                            }
                            else if (text[i] != text[i + 1])
                            {

                                text2 += sk.ToString() + text[i];
                                sk = 1;
                            }
                        }
                        for (int i = text.Length; i < text.Length; i++)
                        {
                            text2 += text[i];
                        }
                        System.Console.WriteLine("Contents of WriteText.txt = {0}", text);
                        System.Console.WriteLine("Teksts: {0}", text2);
                        System.IO.File.WriteAllText(@"C:\Arhivators\WriteText2.txt", text2);

                        // Keep the console window open in debug mode.
                        Console.WriteLine("Press any key to exit.");
                        System.Console.ReadKey();
                        break;
                    case 2:
                        string text3 = System.IO.File.ReadAllText(@"C:\Arhivators\WriteText2.txt");
                        string text4 = "";
                        sk = 0;
                        for (int i = 0; i < text3.Length - 1; i++)
                        {
                            if (text3[i] == '1')
                            {
                                for (int k = 0; k < 1; k++)
                                {
                                    text4 += text3[i + 1];
                                }
                            }
                            else if (text3[i] == '2')
                            {
                                for (int k = 0; k < 2; k++)
                                {
                                    text4 += text3[i + 1];
                                }
                            }
                            else if (text3[i] == '3')
                            {
                                for (int k = 0; k < 3; k++)
                                {
                                    text4 += text3[i + 1];
                                }
                            }
                            else if (text3[i] == '4')
                            {
                                for (int k = 0; k < 4; k++)
                                {
                                    text4 += text3[i + 1];
                                }
                            }
                            else if (text3[i] == '5')
                            {
                                for (int k = 0; k < 5; k++)
                                {
                                    text4 += text3[i + 1];
                                }
                            }
                            else if (text3[i] == '6')
                            {
                                for (int k = 0; k < 6; k++)
                                {
                                    text4 += text3[i + 1];
                                }
                            }
                            else if (text3[i] == '7')
                            {
                                for (int k = 0; k < 7; k++)
                                {
                                    text4 += text3[i + 1];
                                }
                            }
                            else if (text3[i] == '8')
                            {
                                for (int k = 0; k < 8; k++)
                                {
                                    text4 += text3[i + 1];
                                }
                            }
                            else if (text3[i] == '9')
                            {
                                for (int k = 0; k < 9; k++)
                                {
                                    text4 += text3[i + 1];
                                }
                            }
                        }
                        System.Console.WriteLine("Teksts: {0}", text3);
                        System.Console.WriteLine("Teksts: {0}", text4);
                        System.IO.File.WriteAllText(@"C:\Arhivators\WriteText3.txt", text4);
                        Console.WriteLine("Press any key to exit.");
                        System.Console.ReadKey();
                        break;
                    case 3: Environment.Exit(3); break;
                    default: Console.WriteLine("Nepareiz cipars."); break;

                }
            }
            while (SK != 0);
        }
        
    }
}
