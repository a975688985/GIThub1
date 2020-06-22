using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 期末
{
    public partial class image_display : System.Web.UI.Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {

            String url = Request.QueryString["image"];
            Image1.ImageUrl = "/image/" + url;
        }

 
    }
}