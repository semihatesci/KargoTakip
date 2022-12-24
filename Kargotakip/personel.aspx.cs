using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kargotakip
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "admin") { 
            
                if (TextBox2.Text == "123456") 
                { 
                Response.Redirect("pgiris.aspx");

            }
            }
            
           
            
            
            
        }
    }
}