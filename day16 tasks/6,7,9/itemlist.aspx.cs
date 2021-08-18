using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace feedbackforum
{
    public partial class itemlist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedValue == "brush")
            {
                Image1.ImageUrl = "~/brush.jpg";
                Label2.Text = " 10";
            }
            if (ListBox1.SelectedValue == "toothpaste")
            {
                Image1.ImageUrl = "~/pepsodent-toothpaste-500x500.jpg";
                Label2.Text = "20";
            }
            if (ListBox1.SelectedValue == "headphones")
            {
                Image1.ImageUrl = "~/headphone.jpg";
                Label2.Text = " 500";
            }
            if (ListBox1.SelectedValue == "bread")
            {
                Image1.ImageUrl = "~/breadd.jpg";
                Label2.Text = "35";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int cost = Convert.ToInt32(Label2.Text);
            int qtn = Convert.ToInt32(TextBox1.Text);
            int total = cost * qtn;
            Label4.Text = "total cost is" + total.ToString();
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("https://www.fabmart.com/");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("https://www.amazon.in/");      
        }
    }
}