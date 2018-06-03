using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using static DB.DBMange.order;

namespace shopingPro
{
    public partial class cart : System.Web.UI.Page
    {
        public string CommandName { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                int id = Convert.ToInt32(Session["id"]);

                DataTable dt = new DataTable();

                dt = DB.DBMange.orderDetails.Selectstatus(OrderStatus.Saved, id);
                if (dt.Rows.Count > 0)
                {
                    Session.Add("orderid", dt.Rows[0]["orderid"]);
                    gv_cart.DataSource = dt;
                    gv_cart.DataBind();

                    foreach (GridViewRow row in gv_cart.Rows)
                    {
                        foreach (TableCell cell in row.Cells)
                        {
                            cell.Attributes.CssStyle["text-align"] = "center";
                        }
                        int price = Convert.ToInt32((row.FindControl("Label3") as Label).Text);
                        int quantity = Convert.ToInt32((row.FindControl("txt_name") as TextBox).Text);
                        (row.FindControl("lbl_sub") as Label).Text = (price * quantity).ToString();
                    }
                }
                else
                {

                    lbl_empty.Text = "the cart is empty";
                    btn_confirm.Visible = false;
                    txt_address.Visible = false;

                }
            }

        }

        protected void gv_cart_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {


            int id = (int)gv_cart.DataKeys[e.RowIndex].Value;
            DB.DBMange.orderDetails.deletebyid(id);

            int sessionid = Convert.ToInt32(Session["id"]);
            DataTable dt = new DataTable();

            dt = DB.DBMange.orderDetails.Selectstatus(OrderStatus.Saved, sessionid);
            gv_cart.DataSource = dt;
            gv_cart.DataBind();
            foreach (GridViewRow row in gv_cart.Rows)
            {
                foreach (TableCell cell in row.Cells)
                {
                    cell.Attributes.CssStyle["text-align"] = "center";
                }
                int price = Convert.ToInt32((row.FindControl("Label3") as Label).Text);
                int quantity = Convert.ToInt32((row.FindControl("txt_name") as TextBox).Text);
                (row.FindControl("lbl_sub") as Label).Text = (price * quantity).ToString();
            }
        }







        protected void gv_cart_RowCommand(object sender, GridViewCommandEventArgs e)
        {


            if (e.CommandName == "Select")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                int id = Convert.ToInt32(gv_cart.DataKeys[rowIndex].Value);

                GridViewRow row = gv_cart.Rows[rowIndex];

                int quantity = Convert.ToInt32((row.FindControl("txt_name") as TextBox).Text);
                if (quantity <= 0)
                {
                    quantity = 1;
                    (row.FindControl("txt_name") as TextBox).Text = 1.ToString();
                    DB.DBMange.orderDetails.count(id, quantity);

                }
                else
                    DB.DBMange.orderDetails.count(id, quantity);
                int price = Convert.ToInt32((row.FindControl("Label3") as Label).Text);
                (row.FindControl("lbl_sub") as Label).Text = (price * quantity).ToString();




            }
        }



        protected void btn_confirm_Click(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(Session["orderid"]);
            DB.DBMange.order.updatestatus(DB.DBMange.order.OrderStatus.Confirmed, orderId,txt_address.Text);
            int id = Convert.ToInt32(Session["id"]);

            DataTable dt = new DataTable();

            dt = DB.DBMange.orderDetails.Selectstatus(OrderStatus.Saved, id);
            gv_cart.DataSource = dt;
            gv_cart.DataBind();
            if (dt.Rows.Count == 0)
            {

                lbl_empty.Text = "the cart is empty";
                btn_confirm.Visible = false;
                Session.Remove("orderid");


            }

            //Response.Redirect("~/submitaddress.aspx");
        }
    }
}