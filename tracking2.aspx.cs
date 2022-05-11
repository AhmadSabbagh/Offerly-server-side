using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace orgproject
{
    public partial class tracking2 : System.Web.UI.Page
    {
        orgproject.dal.customer ctt = new orgproject.dal.customer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.DataSource = ctt.getData_customer();
                DropDownList1.DataTextField = "email";
                DropDownList1.DataValueField = "customer_id";
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int xx = int.Parse(DropDownList1.SelectedValue);
            DataTable y = new DataTable();
            string sql = "select email,name,time from customer,Tracking,agent where customertrac_id=" + xx + " and customer_id=customertrac_id and agent_id=agentt_id";
            SqlDataAdapter x = new SqlDataAdapter(sql, dal.dbc.conn);
            x.Fill(y);
            GridView1.DataSource = y;
            GridView1.DataBind();
        }
    }
}