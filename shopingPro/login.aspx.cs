using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DB;
using DB.DBMange;

namespace shopingPro
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["userName"] != null)
                {
                    Response.Redirect("~/default.aspx");
                }
                else if (Request.Cookies["local"] != null)
                {
                    Session["userName"] = Request.Cookies["local"].Values["userName"];
                    Session["id"] = Request.Cookies["local"].Values["id"];
                    Session["isAdmin"] = Request.Cookies["local"].Values["isAdmin"];

                    Response.Redirect("~/default.aspx");
                }
            }
            
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            var dt = DB.DBMange.user.login(txt_name.Text, txt_password.Text);
            try
            {
                if (dt.Rows.Count > 0)
                {
                    Session.Add("userName", dt.Rows[0]["userName"]);
                    Session.Add("id", dt.Rows[0]["id"]);
                    Session.Add("isAdmin", dt.Rows[0]["isAdmin"].ToString() );
                    //Session.Add("image", dt.Rows[0]["img"]);

                    if (ck_rember.Checked == true)
                    {
                        HttpCookie co = new HttpCookie("local");
                        co.Values.Add("userName", txt_name.Text);
                        co.Values.Add("id", dt.Rows[0]["id"].ToString());
                        co.Expires = DateTime.Now.AddDays(20);
                        Response.Cookies.Add(co);

                    }
                    Response.Redirect("~/default.aspx",false);
                }
                else
                {
                    lbl_status.Text = "invalid userName or password or You Are Blocked By Admin";
                    lbl_status.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lbl_status.Visible = true;
                lbl_status.Text = "invalid userName or password or You Are Blocked By Admin";
            }


        }
    }
}