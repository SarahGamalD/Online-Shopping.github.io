using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DB;
using DB.DBMange;
using static DB.DBMange.order;

namespace shopingPro.admin
{
    public partial class order : System.Web.UI.Page
    {




        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Add("uid", 1);
                try
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


                    adminorder_view.ActiveViewIndex = 0;
                    DataTable dt = new DataTable();

                    dt = DB.DBMange.order.selectorder();
                    dt.Columns.Add("OrderStatus", typeof(String));
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dt.Rows[i]["OrderStatus"] = ((OrderStatus)(int)dt.Rows[i]["status"]).ToString();
                    }
                    gv_order.DataSource = dt;
                    gv_order.DataBind();







                }

                catch (Exception ex)
                {

                    throw ex;



                }
                //try
                //{
                //    adminorder_view.ActiveViewIndex = 0;
                //    Session.Add("id", 1);
                //    //if (Session["userName"] == null)
                //    //{
                //    //    if (Request.Cookies["local"] != null && Request.Cookies["local"].Values["isAdmin"] == "true")
                //    //    {
                //    //        Session["userName"] = Request.Cookies["local"].Values["userName"];
                //    //        Session["id"] = Request.Cookies["local"].Values["id"];
                //    //        Session["isAdmin"] = Request.Cookies["local"].Values["isAdmin"];

                //    //    }
                //    //    else
                //    //        Response.Redirect("~/home.aspx");
                //    //}

                //    DataTable dt = new DataTable();
                //    dt = DB.DBMange.order.SelectAll();
                //    //gv_all.DataSource = dt;
                //    //gv_all.DataBind();

                //    DataTable dt1 = new DataTable();
                //    dt1 = DB.DBMange.order.selectordersadmin();
                //    dt1.Columns.Add("OrderStatus", typeof(String));
                //    for (int i = 0; i < dt.Rows.Count; i++)
                //    {
                //        dt1.Rows[i]["OrderStatus"] = ((OrderStatus)(int)dt1.Rows[i]["status"]).ToString();
                //    }
                //    gv_order.DataSource = dt1;
                //    gv_order.DataBind();


                //}
                //catch (Exception ex)
                //{

                //   // throw ex;

                //}


            }

        }

        protected void gv_order_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            try
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow selectedRow = gv_order.Rows[index];

                GridViewRow row = gv_order.Rows[index];


                TableCell cell1 = selectedRow.Cells[3];

                if (e.CommandName == "Delete Order")
                {

                    int id = (int)gv_order.DataKeys[index].Value;
                    int roweffect = DB.DBMange.order.delete(id);
                    if (roweffect > 0)
                    {

                        cell1.Text = "Deleted";
                        row.Enabled = false;

                    }
                    else
                        cell1.Text = "Not Deleted";

                }
                DataTable dt1 = DB.DBMange.order.selectorder();
                string s = dt1.Rows[0]["status"].ToString();


                TableCell cell = selectedRow.Cells[3];
                if (e.CommandName == "1")
                {
                    cell.Text = "Saved";
                    row.Enabled = false;
                    int roweffect = DB.DBMange.order.updatestatus(DB.DBMange.order.OrderStatus.Saved, (int)Session["uid"]);
                    if (roweffect > 0)
                    {

                        cell.Text = "Order Saved";


                    }
                    else
                        cell.Text = "Order Not Saved";



                }
                else if (e.CommandName == "2")
                {


                    cell.Text = s;


                    int roweffect = DB.DBMange.order.updatestatus(DB.DBMange.order.OrderStatus.Confirmed, (int)Session["uid"]);
                    if (roweffect > 0)
                    {
                        row.Enabled = false;
                        cell.Text = "Order Confirmed";


                    }
                    else
                        cell.Text = "Order Not Confirmed";


                }

                else if (e.CommandName == "3")
                {


                    cell.Text = s;

                    int roweffect = DB.DBMange.order.updatestatus(DB.DBMange.order.OrderStatus.Approved, (int)Session["uid"]);
                    if (roweffect > 0)
                    {
                        row.Enabled = false;
                        cell.Text = "Order Approved";


                    }
                    else
                        cell.Text = "Order Not Approved";



                }
                else
                {
                   
                    int roweffect = DB.DBMange.order.updatestatus(DB.DBMange.order.OrderStatus.Canceled, (int)Session["uid"]);
                    if (roweffect > 0)
                    {
                        row.Enabled = false;
                        cell.Text = "Order Canceled";


                    }
                    else
                        cell.Text = "Order Not Canceled";




                }
            }
            catch (Exception ex)
            {

                throw ex;

            }
        }

        protected void btn_allorders_Click(object sender, EventArgs e)
        {
            try
            {
                adminorder_view.ActiveViewIndex = 2;
                DataTable dt = new DataTable();

                dt = DB.DBMange.order.selectorder();
                dt.Columns.Add("OrderStatus", typeof(String));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["OrderStatus"] = ((OrderStatus)(int)dt.Rows[i]["status"]).ToString();
                }
                gv_order.DataSource = dt;
                gv_order.DataBind();
            }
          
                 catch (Exception ex)
            {

                throw ex;

            

        }
         
        }

        protected void btn_confirmorder_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    adminorder_view.ActiveViewIndex = 1;
            //    DataTable dt = new DataTable();
            //    dt = DB.DBMange.order.Selectingconfirmd();
            //    dt.Columns.Add("OrderStatus", typeof(String));
            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        dt.Rows[i]["OrderStatus"] = ((OrderStatus)(int)dt.Rows[i]["status"]).ToString();
            //    }
            //    gv_order.DataSource = dt;
            //    gv_order.DataBind();
            //    gv_order.DataBind();
            //}
            //catch (Exception ex)
            //{

            //    throw ex;

            //}

        }

       
    }
}