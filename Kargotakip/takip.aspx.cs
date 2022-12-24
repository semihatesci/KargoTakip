using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kargotakip
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
           

        }

     

        protected void Button1_Click(object sender, EventArgs e)
        {
        
           
        
            int f = Convert.ToInt32(TextBox1.Text);
            int ara = 0;
            ara = Kargotakip.kargo.kno.BinarySearch(f);
            ListBox1.Items.Add(Kargotakip.kargo.kargo1[ara]);


        }
    }
}