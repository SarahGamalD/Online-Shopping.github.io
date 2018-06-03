using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DB.DBMange;
using System.Data;

namespace shopingPro
{
    public partial class insertproductPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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

            ddl_category.DataSource = category.SelectAll();
            ddl_category.DataTextField = "name";
            ddl_category.DataValueField = "id";
            ddl_category.DataBind();

        }

        protected void btn_add_click(object sender, EventArgs e)
        {
            string path = "images/products/" + fu_productimage.FileName;
            fu_productimage.SaveAs(Server.MapPath("../" + path));

            string name = (txt_productname.Text);
            string image = path;
            decimal price = decimal.Parse(txt_productprice.Text);
            int offer = int.Parse(txt_productoffer.Text);
            int categoryId = int.Parse(ddl_category.SelectedValue);
            string description = (txt_productdescription.Text);

            product.insert(name, image, price, offer, categoryId, description);


            Response.Redirect("~/admin/productsPage.aspx");
        }
    }
}