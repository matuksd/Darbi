using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Xml.Linq;
using System.IO;

namespace LINQ_KD2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("Student \t\t St_Card \t\t Subject \t\t Mark \t\t Teacher \n");
            using (ExamEntities context = new ExamEntities())
                foreach (Examenations k in context.Examenations)
                    richTextBox1.AppendText(k.Students.Student + " \t " + k.Students.St_Card+ " \t " + k.Subjects.Subject + " \t\t " + k.Mark + " \t\t" + k.Subjects.Teacher + "\n");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("Student \t\t Subject \t\t Mark\n");
            using (ExamEntities context = new ExamEntities())
                foreach (Examenations k in context.Examenations)
                    if(k.Mark > 7)
                    richTextBox1.AppendText(k.Students.Student + " \t " + k.Subjects.Subject + " \t\t " + k.Mark + "\n");
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (ExamEntities context = new ExamEntities())
            {
                context.Examenations.Add(new Examenations()
                {
                    Ref_Stud = 2,
                    Ref_Subj = 3,
                    Mark = 8
                });
                // sākot ar Visual Studio 2012: context.Klases.Add
                context.SaveChanges();
            } // esiet uzmanīgi
            using (ExamEntities context = new ExamEntities())
            {
                context.Examenations.Add(new Examenations()
                {
                    Ref_Stud = 3,
                    Ref_Subj = 1,
                    Mark = 4
                });
                // sākot ar Visual Studio 2012: context.Klases.Add
                context.SaveChanges();
            } // esiet uzmanīgi

        }

        private void button4_Click(object sender, EventArgs e)
        {
            XElement doc = new XElement("Exams",  // šeit XName="klases"
            new XElement("exam",  // XName="Klase"
            new XElement("Student", "ALiepa"),          // XName="Kl_nosaukums"
            new XElement("Subject", "C++"),
            new XElement("Mark", 7)
            ),
            new XElement("exam",
            new XElement("Student", "ALiepa"),          // XName="Kl_nosaukums"
            new XElement("Subject", "C#"),
            new XElement("Mark", 8)
            ),
            new XElement("exam",
            new XElement("Student", "ALiepa"),          // XName="Kl_nosaukums"
            new XElement("Subject", "Java"),
            new XElement("Mark", 9)
            ),
            new XElement("exam",
            new XElement("Student", "BOzols"),          // XName="Kl_nosaukums"
            new XElement("Subject", "C++"),
            new XElement("Mark", 5)
            ),
            new XElement("exam",
            new XElement("Student", "BOzols"),          // XName="Kl_nosaukums"
            new XElement("Subject", "C#"),
            new XElement("Mark", 8)
            ),
            new XElement("exam",
            new XElement("Student", "CBalbesenko"),          // XName="Kl_nosaukums"
            new XElement("Subject", "Java"),
            new XElement("Mark", 4)
            )
            );
            doc.Save("Exam.xml");
            richTextBox1.AppendText("Exam.xml created");




        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText(XDocument.Load("Exam.xml").ToString());

        }

        private void button6_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load("Exam.xml");
            using (ExamEntities context = new ExamEntities())
            {   var exam = from ex in context.Examenations select (ex as Examenations);
                richTextBox1.Clear();
                foreach (Examenations exx in exam)
                {
                    XElement xelem = new XElement("exam", new XElement("Student", exx.Students.Student), new XElement("Subject", exx.Subjects.Subject), new XElement("Mark", exx.Mark));
                    doc.Descendants("Exams").Last().Add(xelem);
                };
                doc.Save("Exam.xml");


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load("Exam.xml");
            for (int i = 0; i < 6; i++)
            {
                using (ExamEntities context = new ExamEntities())
                {
                    var exam = from ex in context.Examenations select (ex as Examenations);
                    doc.Descendants("exam").First().Remove();

                    doc.Save("Exam.xml");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double sum = 0;
            double av = 0;
            string avv = "";
            richTextBox1.Clear();
            richTextBox1.AppendText("Students        Subjekt        Mark\n");
            XDocument doc = XDocument.Load("Exam.xml");
            var a = from Examenations in doc.Descendants("exam") select (Examenations);
            foreach (var i in a)
            {
                sum += int.Parse(i.Element("Mark").Value);
                avv += i.Element("Mark").Value;
                richTextBox1.AppendText(i.Element("Student").Value + "  -  "
                + i.Element("Subject").Value + "      " + i.Element("Mark").Value + "\n");
            }
            //for(int k=0;k<av.Length;k++)
            //{
            //    avv += (int)av[k];

            //}
            av = sum / avv.Length;
            richTextBox1.AppendText("\nAtzīmju vidēja aritmētiskā Av= " + av.ToString());

        }

        private void button9_Click(object sender, EventArgs e)
        {
            double sum = 0;
            double av = 0;
            string avv = "";
            richTextBox1.Clear();
            XDocument doc = XDocument.Load("Exam.xml");
            var a1 = from Examenations in doc.Descendants("exam") where ((string)Examenations.Element("Subject")).Substring(0,2) == "C+" select (Examenations.Element("Subject").Value);
            var b1 = from Examenations in doc.Descendants("exam") where ((string)Examenations.Element("Subject")).Substring(0,2) == "C+" select (Examenations.Element("Mark").Value);
            richTextBox1.AppendText("Subject \t Mark \n");
            foreach (var o in b1.Distinct())
                foreach (var i in a1.Distinct())
                {
                    richTextBox1.AppendText(i.ToString() + "\t" + o.ToString() + "  \n");
                    sum += int.Parse(o);
                    avv += o;
                    av = sum / avv.Length;

                }
            richTextBox1.AppendText("\nAtzīmju vidēja aritmētiskā Av= " + av.ToString() +"\n");

            sum = 0;av = 0;avv = "";

            var a2 = from Examenations in doc.Descendants("exam") where ((string)Examenations.Element("Subject")).Substring(0, 2) == "C#" select (Examenations.Element("Subject").Value);
            var b2 = from Examenations in doc.Descendants("exam") where ((string)Examenations.Element("Subject")).Substring(0, 2) == "C#" select (Examenations.Element("Mark").Value);
            richTextBox1.AppendText("\n");
            foreach (var o in b2.Distinct())
                foreach (var i in a2.Distinct())
                {
                    richTextBox1.AppendText(i.ToString() + "\t" + o.ToString() + "  \n");
                    sum += int.Parse(o);
                    avv += o;
                    av = sum / avv.Length;
                }
            richTextBox1.AppendText("\nAtzīmju vidēja aritmētiskā Av= " + av.ToString() +"\n");
            sum = 0; av = 0; avv = "";
            var a3 = from Examenations in doc.Descendants("exam") where ((string)Examenations.Element("Subject")).Substring(0, 2) == "Ja" select (Examenations.Element("Subject").Value);
            var b3 = from Examenations in doc.Descendants("exam") where ((string)Examenations.Element("Subject")).Substring(0, 2) == "Ja" select (Examenations.Element("Mark").Value);
            richTextBox1.AppendText("\n");
            foreach (var o in b3.Distinct())

                foreach (var i in a3.Distinct())
                {
                    richTextBox1.AppendText(i.ToString() + "\t" + o.ToString() + "  \n");
                    sum += int.Parse(o);
                    avv += o;
                    av = sum / avv.Length;
                }
            richTextBox1.AppendText("\nAtzīmju vidēja aritmētiskā Av= " + av.ToString() + "\n");

            //av = sum / avv.Length;
            //richTextBox1.AppendText("\nAtzīmju vidēja aritmētiskā Av= " + av.ToString());
            //richTextBox1.AppendText("\nAtzīmju vidēja aritmētiskā Sum= " + sum.ToString());
            //richTextBox1.AppendText("\nAtzīmju vidēja aritmētiskā Sum= " + avv.ToString().Length);

            //var info = from klases in doc.Descendants("Klase")
            //           where ((string)klases.Element("Kl_nosaukums")).Substring(0, 2) == "10"
            //           select (klases.Element("Kl_nosaukums").Value);
            //richTextBox1.Clear();
            //richTextBox1.AppendText("Klases.xml: 10.classes: \n");
            //foreach (var i in info.Distinct()) richTextBox1.AppendText(i.ToString() + "  \n");

        }
    }
}
