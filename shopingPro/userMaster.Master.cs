using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopingPro
{
    public partial class userMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userName"] != null)
            {
                mv_loginStatus.ActiveViewIndex = 0;
                btn_userName.Text = Session["userName"].ToString();
                if (Session["isAdmin"]?.ToString() == "True")
                {
                    lbtn_admin.Visible = true;
                }
            }
            else if (Request.Cookies["local"] != null)
            {
                Session["userName"] = Request.Cookies["local"].Values["userName"];
                Session["id"] = Request.Cookies["local"].Values["id"];
                btn_userName.Text = $" {Session["userName"].ToString()} / ";
                if (Request.Cookies["local"].Values["isAdmin"] == "true")
                {
                    lbtn_admin.Visible = true;
                }
            }
            else
                mv_loginStatus.ActiveViewIndex = 1;
           
        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            HttpCookie c = new HttpCookie("local");
            c.Expires = DateTime.Now.AddDays(-1);

            Response.Cookies.Add(c);

            Session["userName"] = null;
            Session["id"] = null;

            Response.Redirect("~/login.aspx");


        }
    }
}