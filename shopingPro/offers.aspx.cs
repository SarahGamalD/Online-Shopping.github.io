using DB.DBMange;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopingPro
{
    public partial class offers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lv_products.DataSource = product.SelectAllOffer();
                lv_products.DataBind();
            }
        }

        protected void lv_products_SelectedIndexChanging(object sender, ListViewSelectEventArgs e)
        {

            int id = Convert.ToInt32(lv_products.DataKeys[e.NewSelectedIndex].Value);

            DataTable datastatus = new DataTable();
            DataTable dataorder = new DataTable();

            try
            {
                if ((order.Selectstatus(order.OrderStatus.Saved, (int)Session["id"])).Rows.Count > 0)
                {

                    datastatus = order.Selectstatus(order.OrderStatus.Saved, (int)Session["id"]);
                    int ordid = (int)datastatus.Rows[0]["id"];

                    if (orderDetails.Selectbyprodandorder(id, ordid).Rows.Count == 0)
                    {
                        DataTable dtt2 = new DataTable();

                        dtt2 = DB.DBMange.product.SelectById(id);

                        orderDetails.insert(ordid,Convert.ToDecimal(dtt2.Rows[0]["price"]), 1,id);
                    }
                    dataorder = orderDetails.Selectbyprodandorder(id, ordid);
                    int orderdetailid = (int)dataorder.Rows[0]["id"];
                    int quantity = (int)dataorder.Rows[0]["quantity"];
                    int upquantity = quantity + 1;
                    orderDetails.count(orderdetailid, upquantity);
                }
                else
                {
                    DataTable dt2 = new DataTable();
                    //int id = Convert.ToInt32(lv_products.DataKeys[e.NewSelectedIndex].Value);
                    dt2 = DB.DBMange.product.SelectById(id);
                    //add product to cart here
                    DataTable dt = new DataTable();
                    dt = DB.DBMange.order.insertandreturn((int)Session["id"], order.OrderStatus.Saved, DateTime.Now);
                    DB.DBMange.orderDetails.insert(Convert.ToInt32(dt.Rows[0]["id"]), Convert.ToDecimal(dt2.Rows[0]["price"]),1, id);
                    lv_products.DataSource = product.SelectAllOffer();
                    lv_products.DataBind();
                }
            }
            catch (Exception ex )
            {
                Response.Redirect("~/login.aspx",false);


            }

        }

    }
}