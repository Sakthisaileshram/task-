using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace feedbackforum
{
    public partial class image_display : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton4.ImageUrl = "~/download.png";

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton4.ImageUrl = "~/rect.png";
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton4.ImageUrl = "~/tri.png";
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton4.ImageUrl = "null";
        }
    }
}