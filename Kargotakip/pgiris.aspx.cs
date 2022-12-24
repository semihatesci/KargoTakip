using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Kargotakip
{
    public partial class deneme : System.Web.UI.Page
    {
       static List<string> a = new List<string>();
     
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        Classyapisi.personel p =new  Classyapisi.personel();
      

        protected void Button1_Click(object sender, EventArgs e)
        {
           
           
          
            a.Add(TextBox1.Text);
           ListBox1.Items.Add("tc "+TextBox1.Text+"Ad soyadı "+ TextBox2.Text+"görev "+ TextBox3.Text+ "maaş"+TextBox4.Text);
          
        }

      

        protected void Button3_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string f =TextBox5.Text;
            int ara = 0;
             ara = a.BinarySearch(f);

            ListBox1.Items.RemoveAt(ara);
            

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}