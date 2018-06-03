using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace shopingPro
{
    public partial class editprofile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["id"] != null)
                {
                    DataTable dt = new DataTable();
                    int id = (int)Session["id"];
                    dt = DB.DBMange.user.selById(id);
                    if (dt.Rows.Count > 0)
                    {
                        txt_fname.Text = dt.Rows[0]["fName"].ToString();
                        txt_lname.Text = dt.Rows[0]["lName"].ToString();
                        txt_userName.Text = dt.Rows[0]["userName"].ToString();
                        txt_email.Text = dt.Rows[0]["email"].ToString();
                        txt_address.Text = dt.Rows[0]["address"].ToString();


                        txt_phone.Text = dt.Rows[0]["phone"].ToString();

                        //txt_date.Text = (DateTime.Parse(dt.Rows[0]["birthDate"].ToString()).ToString("dd.MM.yyyy"));


                    }
                }
                else
                    Response.Redirect("~/default.aspx");

            }

        }

        protected void btn_edit_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                string path = string.Empty;
                int id = (int)Session["id"];
                // int id = 1;
                int output = DB.DBMange.user.editUserNameAndEmail(id, txt_email.Text, txt_userName.Text);

                try {
                    if (output == 0)
                    {
                        if (fu_img.HasFile)
                        {

                            path = "~/images/users/" + fu_img.FileName;

                            fu_img.SaveAs(Server.MapPath(path));


                        }
                        else
                        {
                            path = Session["image"].ToString();

                        }
                        DB.DBMange.user.updatebyid(id, txt_fname.Text, txt_lname.Text, txt_address.Text, txt_email.Text, txt_userName.Text, path, txt_phone.Text);

                    }

                    else if (output == 1)
                    {
                        lbl_userNameStatus.Text = "username is used before";

                    }
                    else if (output == 2)
                    {
                        lbl_emailState.Text = "email is used before";

                    }
                    else
                        lbl_status.Text = "there is error";
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
    }
}