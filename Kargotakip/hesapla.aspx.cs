using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kargotakip
{
    public partial class hesapla : System.Web.UI.Page
    {
        public int hesap(int a,int b,int d)
        {
            return  (4 * a) + b + d;
        }
             
        static public int a;
        static public int b;
        static public int c;
        static public int d;
        static public int e;
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
              

            TextBox1.Text = hesap(a,b,d).ToString();

           
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (DropDownList1.SelectedValue== "300km")
            {
                a = 10;
            }
            if (DropDownList1.SelectedValue == "450km")
            {
                a = 12;
            }
            if (DropDownList1.SelectedValue == "600km")
            {
                a = 15;
            }
            if  (DropDownList1.SelectedValue == "900km")
            {
                a = 20;
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (DropDownList2.SelectedValue == "0-1")
            {
                b = 10;
            }
            if (DropDownList2.SelectedValue == "1-3")
            {
                b = 15;
            }
            if (DropDownList2.SelectedValue == "3-7")
            {
                b = 20;
            }
         
            if (DropDownList2.SelectedValue == "7-15")
            {
                b = 25;
            }
            if (DropDownList2.SelectedValue == "15-50")
            {
                b = 30;
            }

        }

        protected void Alıcı_CheckedChanged(object sender, EventArgs e)
        {
            
            if (Alıcı.Checked == true)
            {
                c = 0;
            }
            
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            
            if (CheckBox2.Checked == true)
            {
                d = 11;
            }
            else
            {
                d = 0;
            }

        }
    }
}