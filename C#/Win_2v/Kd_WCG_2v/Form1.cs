using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kd_WCG_2v.ServiceReference1;

namespace Kd_WCG_2v
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Service1Client sc = new Service1Client();
        private void button1_Click(object sender, EventArgs e)
        {
            
            string s = "";
            try { s = textBox1.Text; }
            catch { }
            string[] kk = sc.Vardi();
            
            for (int k = 0; k < sc.Vardusk(); k++)
            {
                if (kk[k].Contains(s))
                {
                    label2.Text = sc.FindByName(kk[k]);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("Name      Run 100m    Lenght       Height\n");
            if (radioButton1.Checked && (!radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked))
                richTextBox1.AppendText(sc.SortedbyName());
            else if (radioButton2.Checked && (!radioButton1.Checked && !radioButton3.Checked && !radioButton4.Checked))
                richTextBox1.AppendText(sc.SortedbyRun100m());
            else if (radioButton3.Checked && (!radioButton1.Checked && !radioButton2.Checked && !radioButton4.Checked))
                richTextBox1.AppendText(sc.SortedbyHeight());
            else if (radioButton4.Checked && (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked))
                richTextBox1.AppendText(sc.SortedbyLeksana());
                

        }
    }
}
