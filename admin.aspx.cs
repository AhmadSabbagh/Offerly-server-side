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
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable y = new DataTable();
                string sql = "select admin_name  from admin";
                SqlDataAdapter x = new SqlDataAdapter(sql, dal.dbc.conn);
                x.Fill(y);
                GridView1.DataSource = y;
                GridView1.DataBind();
            }
        }
    }
}