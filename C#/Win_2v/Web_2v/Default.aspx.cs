using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string a = "";
        // vajadzētu pārbaudīt ievaddatus, vismaz try-catch
        try { a = TextBox1.Text; }
        catch { }
        ServiceReference1.Service1Client sc =
        new ServiceReference1.Service1Client();

        string[] kk = sc.Vardi();

        for (int k = 0; k < sc.Vardusk(); k++)
        {
            if (kk[k].Contains(a))
            {
                Label1.Text = sc.FindByName(kk[k]);
            }

        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

        ServiceReference1.Service1Client sc =
           new ServiceReference1.Service1Client();
        Label3.Text = "Name      Run 100m    Lenght Height";
        if (radioButton1.Checked && (!radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked))
            Label2.Text = sc.SortedbyNameBR();
        else if (radioButton2.Checked && (!radioButton1.Checked && !radioButton3.Checked && !radioButton4.Checked))
            Label2.Text = sc.SortedbyRun100mBR();
        else if (radioButton3.Checked && (!radioButton1.Checked && !radioButton2.Checked && !radioButton4.Checked))
            Label2.Text = sc.SortedbyLeksanaBR();
        else if (radioButton4.Checked && (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked))
            Label2.Text = sc.SortedbyHeightBR();
    }
}