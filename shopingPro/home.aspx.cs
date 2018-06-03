using DB.DBMange;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopingPro
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lv_products.DataSource= product.SelectAllOffer();
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