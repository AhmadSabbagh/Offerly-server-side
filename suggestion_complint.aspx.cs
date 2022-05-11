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
    public partial class suggestion_complint : System.Web.UI.Page
    {

        orgproject.dal.customer cs = new orgproject.dal.customer();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {
                GridView1.DataSource = cs.getData_suggest();
                GridView1.DataBind();

                GridView2.DataSource = cs.getData_complaint();
                GridView2.DataBind();

                DataTable table = new DataTable();
                string sql = "select email,text as improve from improve where improve.customer_id=customer.customer_id ";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, dal.dbc.conn);
                adapter.Fill(table);
                GridView3.DataSource = table;
                GridView3.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = cs.remove_suggest();
                if (n > 0)
                    Label1.Text = "تم المسح بنجاح";
                GridView1.DataSource = cs.getData_suggest();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            try
            {
                int n = cs.remove_complaint();
                if (n > 0)
                    Label2.Text = "تم المسح بنجاح";
                GridView2.DataSource = cs.getData_complaint();
                GridView2.DataBind();
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int result = 0;
            string sql = "delete from improve ";



            SqlCommand cmd = new SqlCommand(sql, dal.dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            if (result != 0)
                Label3.Text = "تم المسح بنجاح ";
            
        }
    }
}