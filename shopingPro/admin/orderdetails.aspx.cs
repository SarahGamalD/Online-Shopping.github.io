using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using static DB.DBMange.order;

namespace shopingPro.admin
{
    public partial class orderdetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                try
                {

                    if (Session["userName"] == null)
                    {
                        if (Request.Cookies["local"] != null && Request.Cookies["local"].Values["isAdmin"] == "True")
                        {
                            Session["userName"] = Request.Cookies["local"].Values["userName"];
                            Session["id"] = Request.Cookies["local"].Values["id"];
                            Session["isAdmin"] = Request.Cookies["local"].Values["isAdmin"];

                        }
                        else
                            Response.Redirect("~/default.aspx");
                    }
                    

                    string uid = Request.QueryString["orderId"];

                    DataTable dt = new DataTable();
                    dt = DB.DBMange.order.selectorderdetails(int.Parse(uid));

                    gv_orderdetails.DataSource = dt;
                    gv_orderdetails.DataBind();


                }

                catch (Exception ex)
                {

                    throw ex;



                }



            }


        }
    }
}