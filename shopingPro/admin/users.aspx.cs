using DB.DBMange;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static DB.DBMange.user;

namespace shopingPro.admin
{
    public partial class users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["userName"] == null)
                {
                    if (Request.Cookies["local"] != null && Request.Cookies["local"].Values["isAdmin"] == "true")
                    {
                        Session["userName"] = Request.Cookies["local"].Values["userName"];
                        Session["id"] = Request.Cookies["local"].Values["id"];
                        Session["isAdmin"] = Request.Cookies["local"].Values["isAdmin"];

                    }
                    else
                        Response.Redirect("~/default.aspx");
                }
                else if((string)Session["isAdmin"] != "True")
                    Response.Redirect("~/default.aspx");


                var users = user.selectAll();
                users.Columns.Add("userStaus", typeof(String));
                for (int i = 0; i < users.Rows.Count; i++)
                {
                    users.Rows[i]["userStaus"] = ((UserStatus)(int)users.Rows[i]["status"]).ToString();

                }
                gv_users.DataSource = users;
                gv_users.DataBind();

            }
        }

        protected void gv_users_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gv_users.EditIndex = e.NewEditIndex;
            var users = user.selectAll();
            users.Columns.Add("userStaus", typeof(String));
            for (int i = 0; i < users.Rows.Count; i++)
            {
                users.Rows[i]["userStaus"] = ((UserStatus)(int)users.Rows[i]["status"]).ToString();

            }
            gv_users.DataSource = users;
            gv_users.DataBind();

        }

        protected void gv_users_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            bool isAdmin = ((CheckBox)gv_users.Rows[e.RowIndex].FindControl("chk_isAdmin")).Checked;
            int userStatus = Convert.ToInt32( ((DropDownList)gv_users.Rows[e.RowIndex].FindControl("ddl_status")).SelectedValue.ToString());
            int id =Convert.ToInt32( gv_users.DataKeys[e.RowIndex].Value);
            user.updateByAdmin( id, isAdmin, (UserStatus) userStatus);


            gv_users.EditIndex = -1;

            var users = user.selectAll();
            users.Columns.Add("userStaus", typeof(String));
            for (int i = 0; i < users.Rows.Count; i++)
            {
                users.Rows[i]["userStaus"] = ((UserStatus)(int)users.Rows[i]["status"]).ToString();

            }
            gv_users.DataSource = users;
            gv_users.DataBind();

        }

        protected void gv_users_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv_users.EditIndex = -1;

            var users = user.selectAll();
            users.Columns.Add("userStaus", typeof(String));
            for (int i = 0; i < users.Rows.Count; i++)
            {
                users.Rows[i]["userStaus"] = ((UserStatus)(int)users.Rows[i]["status"]).ToString();

            }
            gv_users.DataSource = users;
            gv_users.DataBind();
        }
    }
}