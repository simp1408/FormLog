using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormLog
{
    public partial class homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //se esiste il coocki
            if (Request.Cookies["DatiUtente"] != null) 
            {
                ReadCoocki.Text = Request.Cookies["DatiUtente"]["username"];
            }
            else
            {
                Response.Redirect("login.aspx");
            }

        }

        protected void LogOut_click(object sender, EventArgs e)
        {
            //cancello coocki
            HttpCookie c = new HttpCookie("DatiUtente");
            c.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(c);

            Response.Redirect("login.aspx");


        }
    }
}