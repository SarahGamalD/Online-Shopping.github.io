using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DB.DBMange;
using System.Data;


namespace shopingPro.admin
{
    public partial class AddNewCategory : System.Web.UI.Page
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
                else if ((string)Session["isAdmin"] != "True")
                    Response.Redirect("~/default.aspx");


                gv_category.DataSource = category.SelectAll();
                gv_category.DataBind();

            }
        }

        protected void gv_category_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

            gv_category.EditIndex = -1;
            gv_category.DataSource = category.SelectAll();
            gv_category.DataBind();
        }


        protected void gv_category_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            var dt = category.SelectAll();

            string name = ((TextBox)gv_category.Rows[e.RowIndex].FindControl("txt_categoryname")).Text;
            int id = (int)gv_category.DataKeys[e.RowIndex].Value;

            category.update(id, name);
            gv_category.EditIndex = -1;
            gv_category.DataSource = category.SelectAll();
            gv_category.DataBind();

        }

        protected void gv_category_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gv_category.EditIndex = e.NewEditIndex;
            DataTable dt = category.SelectAll();
            gv_category.DataSource = dt;
            gv_category.DataBind();


        }

        protected void btn_newcategory_Click(object sender, EventArgs e)
        {
            string name = (txt_newcategory.Text);
            category.insert(name);
            gv_category.DataSource = category.SelectAll();
            gv_category.DataBind();
            txt_newcategory.Text = "";




        }

        protected void gv_category_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int id = (int)gv_category.DataKeys[e.RowIndex].Value;

                category.delete(id);
                gv_category.DataSource = category.SelectAll();
                gv_category.DataBind();
            }
            catch (Exception ex)
            {
                lbl_cntDelete.Visible = true;
            }
           
        }
    }
}