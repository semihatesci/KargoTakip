﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kargotakip
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_kullanıcı_Click(object sender, EventArgs e)
        {
            Response.Redirect("kullanıcı.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("personel.aspx");
        }
    }
}