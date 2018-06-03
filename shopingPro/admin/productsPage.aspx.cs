using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using DB.DBMange;


namespace shopingPro
{
    public partial class productsPage : System.Web.UI.Page
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

                gv_product.DataSource = product.SelectAll();
                gv_product.DataBind();

            }



        }

       


        protected void gv_product_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gv_product.EditIndex = e.NewEditIndex;
            DataTable dt = product.SelectAll();
            gv_product.DataSource = dt;
            gv_product.DataBind();
            DropDownList ddl = (DropDownList)gv_product.Rows[e.NewEditIndex].FindControl("ddl_category");

            ddl.DataSource = category.SelectAll();
            ddl.DataTextField = "name";
            ddl.DataValueField = "id";
            ddl.DataBind();

            ddl.SelectedValue = dt.Rows[e.NewEditIndex]["id"].ToString();




        }

        protected void gv_product_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            var dt = product.SelectAll();
            string name = ((TextBox)gv_product.Rows[e.RowIndex].FindControl("txt_name")).Text;
            decimal price = decimal.Parse(((TextBox)gv_product.Rows[e.RowIndex].FindControl("txt_price")).Text);
            int offer = int.Parse(((TextBox)gv_product.Rows[e.RowIndex].FindControl("txt_offer")).Text);
            int categoryId = int.Parse(((DropDownList)gv_product.Rows[e.RowIndex].FindControl("ddl_category")).Text);
            string description = ((TextBox)gv_product.Rows[e.RowIndex].FindControl("txt_description")).Text;

            FileUpload fu_image = ((FileUpload)gv_product.Rows[e.RowIndex].FindControl("fu_image"));
            string fileName = "";
            if (fu_image.FileName != "")
            {
                fu_image.SaveAs(Server.MapPath("image" + fu_image.FileName));
                fileName = "images" + fu_image.FileName;
            }
            else
            {
                fileName = dt.Rows[e.RowIndex]["image"].ToString();
            }
            //string dept = ((DropDownList)gv_stu.Rows[e.RowIndex].FindControl("ddl_dept")).SelectedValue.ToString();
            //DropDownList deptd = ((DropDownList)gv_stu.Rows[e.RowIndex].FindControl("ddl_dept"));
            int id = (int)gv_product.DataKeys[e.RowIndex].Value;

            product.update(id, name, fileName, price, offer, categoryId, description);


            gv_product.EditIndex = -1;

            gv_product.DataSource = product.SelectAll();
            gv_product.DataBind();
        }

        protected void gv_product_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv_product.EditIndex = -1;
            gv_product.DataSource = product.SelectAll();
            gv_product.DataBind();
        }

        protected void gv_product_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = (int)gv_product.DataKeys[e.RowIndex].Value;

            product.delete(id);
            gv_product.DataSource = product.SelectAll();
            gv_product.DataBind();
        }

        protected void lb_search_Click(object sender, EventArgs e)
        {
            string name = (txt_search.Text);
            gv_product.DataSource = product.SelectByName(name);
            gv_product.DataBind();
            //txt_search.Text = "";
        }
    }
}