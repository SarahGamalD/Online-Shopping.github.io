using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using static DB.DBMange.order;

namespace shopingPro
{
    public partial class userorders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

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



                    DataTable dt = DB.DBMange.order.selectorderuser(int.Parse(Session["id"].ToString()));
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
        }



        protected void gv_confirm_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {


                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow selectedRow = gv_confirm.Rows[index];
                GridViewRow row = gv_confirm.Rows[index];


                if (e.CommandName == "cancle Order")
                {

                    int id = (int)gv_confirm.DataKeys[index].Value;

                    DataTable dt = new DataTable();
                    dt = DB.DBMange.order.Selectingconfirmduser(int.Parse(Session["id"].ToString()));
                    dt.Columns.Add("OrderStatus", typeof(String));
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dt.Rows[i]["OrderStatus"] = ((OrderStatus)(int)dt.Rows[i]["status"]).ToString();
                    }
                    int rowe_efect = DB.DBMange.order.updatestatus(OrderStatus.Canceled, id);
                    if (rowe_efect > 0)
                    {

                        gv_confirm.DataSource = dt;
                        gv_confirm.DataBind();
                    }

                    else
                    {
                        gv_confirm.DataSource = dt;
                        gv_confirm.DataBind();

                    }


                }


                if (e.CommandName == "Confirm Order")
                {
                    int id = (int)gv_confirm.DataKeys[index].Value;
                    int rowe_efect = DB.DBMange.order.updatestatus(OrderStatus.Confirmed, id);
                    if (rowe_efect > 0)
                    {
                        DataTable dt = new DataTable();
                        dt = DB.DBMange.order.SelectingSaved(int.Parse(Session["id"].ToString()));
                        dt.Columns.Add("OrderStatus", typeof(String));
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dt.Rows[i]["OrderStatus"] = ((OrderStatus)(int)dt.Rows[i]["status"]).ToString();
                        }
                        gv_confirm.DataSource = dt;
                        gv_confirm.DataBind();
                    }

                    else
                    {
                        DataTable dt = new DataTable();
                        dt = DB.DBMange.order.SelectingSaved(int.Parse(Session["id"].ToString()));
                        dt.Columns.Add("OrderStatus", typeof(String));
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dt.Rows[i]["OrderStatus"] = ((OrderStatus)(int)dt.Rows[i]["status"]).ToString();
                        }
                        gv_confirm.DataSource = dt;
                        gv_confirm.DataBind();

                    }


                }

            }
            catch (Exception ex)
            {

                throw ex;

            }
        }

        protected void btn_all_Click(object sender, EventArgs e)
        {
            mv_show.ActiveViewIndex = 0;
            try
            {

                DataTable dt = DB.DBMange.order.selectorderuser(int.Parse(Session["id"].ToString()));

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

        protected void btn_confirm_Click(object sender, EventArgs e)
        {
            mv_show.ActiveViewIndex = 1;

            try
            {
                DataTable dt = new DataTable();
                dt = DB.DBMange.order.SelectingSaved(int.Parse(Session["id"].ToString()));
                dt.Columns.Add("OrderStatus", typeof(String));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["OrderStatus"] = ((OrderStatus)(int)dt.Rows[i]["status"]).ToString();
                }
                gv_confirm.DataSource = dt;
                gv_confirm.DataBind();


            }


            catch (Exception ex)
            {

                throw ex;

            }
        }

        protected void gv_confirmd_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {


                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow selectedRow = gv_confirmd.Rows[index];
                GridViewRow row = gv_confirmd.Rows[index];


                if (e.CommandName == "cancle Order")
                {

                    int id = (int)gv_confirmd.DataKeys[index].Value;

                    DataTable dt = new DataTable();
                    dt = DB.DBMange.order.Selectingconfirmduser(15);
                    dt.Columns.Add("OrderStatus", typeof(String));
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dt.Rows[i]["OrderStatus"] = ((OrderStatus)(int)dt.Rows[i]["status"]).ToString();
                    }
                    int rowe_efect = DB.DBMange.order.updatestatus(OrderStatus.Canceled, id);
                    if (rowe_efect > 0)
                    {

                        gv_confirmd.DataSource = dt;
                        gv_confirmd.DataBind();
                    }

                    else
                    {
                        gv_confirm.DataSource = dt;
                        gv_confirm.DataBind();

                    }


                }




            }
            catch (Exception ex)
            {

                throw ex;

            }
        }


        protected void btn_con_Click(object sender, EventArgs e)
        {
            mv_show.ActiveViewIndex = 2;

            try
            {
                DataTable dt = new DataTable();
                dt = DB.DBMange.order.Selectingconfirmduser(int.Parse(Session["id"].ToString()));
                dt.Columns.Add("OrderStatus", typeof(String));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["OrderStatus"] = ((OrderStatus)(int)dt.Rows[i]["status"]).ToString();
                }
                gv_confirmd.DataSource = dt;
                gv_confirmd.DataBind();


            }


            catch (Exception ex)
            {

                throw ex;

            }
        }

        protected void btn_all2_Click(object sender, EventArgs e)
        {
            mv_show.ActiveViewIndex = 0;
            try
            {

                DataTable dt = DB.DBMange.order.selectorderuser(int.Parse(Session["id"].ToString()));

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
    }
}