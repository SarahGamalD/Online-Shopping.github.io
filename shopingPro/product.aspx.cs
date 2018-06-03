using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DB.DBMange;

namespace shopingPro
{
    public partial class readmore : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    int id = int.Parse(Request.QueryString["id"]);
                    DV_Product.DataSource = DB.DBMange.product.selectproduct(id);
                    DV_Product.DataBind();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }

        protected void btn_cart_Click(object sender, EventArgs e)
        {
            {
                int id = int.Parse(Request.QueryString["id"]);
                DataTable datastatus = new DataTable();
                DataTable dataorder = new DataTable();
                try
                {
                    if ((order.Selectstatus(order.OrderStatus.Saved, id)).Rows.Count > 0)
                    {

                        datastatus = order.Selectstatus(order.OrderStatus.Saved, id);
                        int ordid = (int)datastatus.Rows[0]["id"];

                        if (orderDetails.Selectbyprodandorder(id, ordid).Rows.Count == 0)
                        {
                            DataTable dtt2 = new DataTable();

                            dtt2 = DB.DBMange.product.SelectById(id);

                            orderDetails.insert(ordid, Convert.ToDecimal(dtt2.Rows[0]["price"]), int.Parse(txt_cart.Text), id);
                        }
                        dataorder = orderDetails.Selectbyprodandorder(id, ordid);
                        int orderdetailid = (int)dataorder.Rows[0]["id"];
                        int quantity = (int)dataorder.Rows[0]["quantity"];
                        int upquantity = quantity + 1;
                        orderDetails.count(orderdetailid, upquantity);
                        txt_cart.Text = "";
                    }
                    else
                    {
                        DataTable dt2 = new DataTable();
                        dt2 = DB.DBMange.product.SelectById(id);
                        DataTable dt = new DataTable();
                        dt = DB.DBMange.order.insertandreturn((int)Session["id"], order.OrderStatus.Saved, DateTime.Now);
                        DB.DBMange.orderDetails.insert(Convert.ToInt32(dt.Rows[0]["id"]), Convert.ToDecimal(dt2.Rows[0]["price"]),int.Parse( txt_cart.Text), id);
                        DV_Product.DataSource = product.selectproduct(id);
                        DV_Product.DataBind();
                        txt_cart.Text = "";
                    }
                }
                catch (Exception ex)
                {
                   Response.Redirect("~/login.aspx", false);


                }

            }

        }
    }
}