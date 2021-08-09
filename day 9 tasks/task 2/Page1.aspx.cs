using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hiddenfile
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HiddenField1.Value = "4,843 for 24 carat gold and 44,390 for 22 carat gold";
            HiddenField2.Value = " 508.80 ";
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            TextBox1.Text = "the price of 1 gm of gold is :"+HiddenField1.Value;

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            TextBox1.Text = "the price of 1 gm of silver is :" + HiddenField2.Value;
        }
    }
}