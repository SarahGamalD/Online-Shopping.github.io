using DB.DBMange;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopingPro
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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

        protected void btn_register_Click(object sender, EventArgs e)
        {
            var result = user.checkUserNameAndEmail(txt_email.Text, txt_userName.Text);
            if (result == 0)
            {
                var image = "";
                if (fu_img.FileName != "")
                {
                    image = "~/images/users/" + fu_img.FileName;
                    fu_img.SaveAs(Server.MapPath(image));
                }
                else
                    image = "~/images/users/avatar.gif";

                var id = user.insert(txt_fname.Text, txt_lname.Text, txt_address.Text, txt_email.Text,
                                     txt_userName.Text, Convert.ToDateTime(txt_date.Text), false, txt_password.Text,
                                     image, txt_phone.Text, user.UserStatus.Blocked);

                if (id > 0)
                {
                    Session.Add("userName", txt_userName.Text);
                    Session.Add("id", id);
                    Session.Add("isAdmin", "false");
                    Response.Redirect("~/profile.aspx");
                }
                else
                    lbl_status.Text = "something went wrong";

            }
            else if (result == 1)
            {
                lbl_userNameStatus.Text = "existed userName";
                lbl_emailState.Text = "";
            }
            else
            {
                lbl_userNameStatus.Text = "";
                lbl_emailState.Text = "existed email";
            }
        }
    }
}