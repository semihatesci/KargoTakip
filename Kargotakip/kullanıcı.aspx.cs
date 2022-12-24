using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kargotakip
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_kargo_Click(object sender, EventArgs e)
        {

            Response.Redirect("hesapla.aspx");
        }

        protected void btn_takip_Click(object sender, EventArgs e)
        {
            Response.Redirect("takip.aspx");
            Classyapisi.kargo k = new Classyapisi.kargo();
            k.kargotakip(Convert.ToInt32(TextBox1.Text));

        }
        
       
    }
}