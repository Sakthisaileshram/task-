using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
namespace RegForm
{
    public partial class page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //protected void WriteFyle()
        //{
        //    FileStream fs = new FileStream("c:\\c#\\day 8 tasks\\registration deets.cs", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        //    StreamWriter sw = new StreamWriter(fs);
        //    sw.BaseStream.Seek(0, SeekOrigin.End);
        //    sw.Write(txt_Fname);
        //    sw.Write(txt_Lname);
        //    sw.Write(txt_Age);
        //    sw.Write(txt_email);
        //    sw.Write(txt_pin);
        //    sw.Write(txt_pword);
        //    sw.Flush();
        //    sw.Close();
        //    fs.Close();

        //}       
        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string fname = txt_Fname.Text;
           
           
            FileStream fs = new FileStream("C:\\c#\\filename.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.BaseStream.Seek(0, SeekOrigin.End);
            sw.Write(fname+"" + txt_Lname.Text+"" + txt_Age.Text);
           // sw.Write(txt_Lname.Text);
            //sw.Write(txt_Age.Text);
            sw.Write(txt_email.Text);
            sw.Write(txt_pin.Text);
            sw.Write(txt_pword.Text);
            sw.Flush();
            sw.Close();
            fs.Close();
            Response.Redirect("page2.aspx?&" + fname);
        }
    }
}