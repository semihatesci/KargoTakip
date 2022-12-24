using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kargotakip
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        Classyapisi.personelkalitim k3 = new Classyapisi.personelkalitim();
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            
        }
     
        protected void Button1_Click(object sender, EventArgs e)
        {
            int c=Convert.ToInt32(TextBox2.Text);
            string d = TextBox1.Text;
            string g = "kurye";
            int m = Convert.ToInt32(TextBox3);
            DateTime t = Calendar1.SelectedDate.Date;
            k3.personelekle(c, d, g, m, t);


        }

    }
}