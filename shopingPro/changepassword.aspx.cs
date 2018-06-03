using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopingPro
{
    public partial class changepassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("~/default.aspx");


            }

        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                try
                {
                    int id = Convert.ToInt32(Session["id"]);
                    int output = DB.DBMange.user.changepassword(id, txt_oldpass.Text, txt_password.Text);

                    if (output > 0)
                    {
                        Response.Redirect("~/profile.aspx");


                    }
                    else
                        lbl_status.Text = "there is error";

                }
                catch(Exception ex)
                {
                    throw ex;

                }
            }
        }
    }
}