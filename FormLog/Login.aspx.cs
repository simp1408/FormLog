using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormLog
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }
        protected void Login_click(object sender, EventArgs e)
        {
            //passo al costruttore il nome del coocki
            HttpCookie cookie = new HttpCookie("DatiUtente");
            cookie.Values["username"] = username.Text;

            //DURATA DEL COOCKI
            cookie.Expires = DateTime.Now.AddDays(20);
            //AGGIUNGO COOCKI
            Response.Cookies.Add(cookie);


            Response.Redirect("homepage.aspx");

        }
    }
}