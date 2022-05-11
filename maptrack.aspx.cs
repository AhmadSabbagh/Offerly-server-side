using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace orgproject
{//"title": '<%# Eval("email") %>',
    public partial class maptrack : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!this.IsPostBack)
            {
                DataTable dt = this.GetData("select * from customer");
                rptMarkers.DataSource = dt;
                rptMarkers.DataBind();
              
            }
        }

        private DataTable GetData(string query)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query);
            SqlDataAdapter adapter = new SqlDataAdapter(query, dal.dbc.conn);
            adapter.Fill(dt);
            return dt;


         /*   string conString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            SqlCommand cmd = new SqlCommand(query);
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;

                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        return dt;
                    }
                }
            }*/
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("offermap.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}