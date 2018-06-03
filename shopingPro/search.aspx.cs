using DB.DBMange;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopingPro
{
    public partial class search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var cat = Request.QueryString["cat"];
                var name = Request.QueryString["name"];
                var from =Convert.ToDecimal( Request.QueryString["from"]);
                var to = Convert.ToDecimal(Request.QueryString["to"]);
                lv_products.DataSource = product.search(cat,name,from,to);
                lv_products.DataBind();
            }
        }

        protected void lv_products_SelectedIndexChanging(object sender, ListViewSelectEventArgs e)
        {

            int id = Convert.ToInt32(lv_products.DataKeys[e.NewSelectedIndex].Value);
            //add product to cart here

            lv_products.DataSource = product.SelectAllOffer();
            lv_products.DataBind();
        }
    }
}