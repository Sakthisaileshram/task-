using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace forms
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (DropDownList1.SelectedValue == "Tamil Nadu")
            //{
            //    ListBox1.Items.Clear();
            //    ListBox1.Items.Add("chennai");
            //    ListBox1.Items.Add("Madhurai");
            //    ListBox1.Items.Add("Trichy");
            //}
            //if (DropDownList1.SelectedValue == "andhra")
            //{
            //    ListBox1.Items.Clear();
            //    ListBox1.Items.Add("kaakinaada");
            //    ListBox1.Items.Add("paavadanaada");
            //    ListBox1.Items.Add("hyderbad");
            //}


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "Tamil Nadu")
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("chennai");
                ListBox1.Items.Add("Madhurai");
                ListBox1.Items.Add("Trichy");
            }
            if (DropDownList1.SelectedValue == "andhra")
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("kaakinaada");
                ListBox1.Items.Add("vizag");
                ListBox1.Items.Add("hyderbad");
            }

        }

        
    }
}