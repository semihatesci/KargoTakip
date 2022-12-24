using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kargotakip
{
    public partial class kargo : System.Web.UI.Page
    {
        public static List<string> kargo1 = new List<string>();
        public static List<int> kno = new List<int>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        Classyapisi.kargo k = new Classyapisi.kargo();

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            n = kargo1.Count;
            int knoo = 1000 + n;

            kno.Add(knoo);
            kargo1.Add("kargono" + knoo.ToString() + "ad soyad" + TextBox1.Text + "adres " + TextBox2.Text + "il " + DropDownList2.SelectedValue + "tel" + TextBox4.Text);
            TextBox6.Text = knoo.ToString();

            Classyapisi.kargo k = new Classyapisi.kargo(knoo, TextBox2.Text, TextBox1.Text, TextBox4.Text, DropDownList2.SelectedValue, "");



            protected void Button2_Click(object sender, EventArgs e)
            {
                int f = Convert.ToInt32(TextBox3.Text);
                int ara = 0;
                ara = kno.BinarySearch(f);

                kargo1.RemoveAt(ara);
            }


            protected void Button3_Click(object sender, EventArgs e)
            {
                int f = Convert.ToInt32(TextBox5.Text);
                int ara = 0;
                ara = kno.BinarySearch(f);
                ListBox1.Items.Add(kargo1[ara]);


            }

            protected void TextBox5_TextChanged(object sender, EventArgs e)
            {

            }
        }
    } }

        
    