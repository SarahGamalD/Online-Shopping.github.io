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
    public partial class profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["id"] != null)
                {
                    int id = Convert.ToInt32(Session["id"]);
                    // int id = 1;
                    DataTable dt = new DataTable();
                    dt = DB.DBMange.user.selById(id);

                    if (dt.Rows.Count > 0)
                    {
                        lbl_fname.Text = dt.Rows[0]["fName"].ToString();
                        lbl_lname.Text = dt.Rows[0]["lName"].ToString();
                        lbl_uname.Text = dt.Rows[0]["userName"].ToString();
                        lbl_mail.Text = dt.Rows[0]["email"].ToString();
                        lbl_address.Text = dt.Rows[0]["address"].ToString();
                        lbl_phone.Text = dt.Rows[0]["phone"].ToString();
                        lbl_birthdate.Text =Convert.ToDateTime( dt.Rows[0]["birthDate"].ToString()).ToShortDateString();
                        img_profile.ImageUrl = dt.Rows[0]["img"].ToString();

                    }

                }
                else
                {
                    Response.Redirect("~/default.aspx");

                }

            }
        }

        
    }
}