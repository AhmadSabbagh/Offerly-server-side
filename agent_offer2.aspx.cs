using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace orgproject
{
    public partial class agent_offer2 : System.Web.UI.Page
    {
        dal.customer ss = new dal.customer();
        int id = 0;
        string name = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == 0 && name == null)
                    Label2.Text = "Please enter a number or name ";
                else
                {

                    id = int.Parse(TextBox1.Text);
                    name = TextBox2.Text;

                    GridView1.DataSource = ss.getData_agent(id, name);
                    GridView1.DataBind();
                }

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == 0 && name != null)
                {
                    DataTable y = new DataTable();
                    string sql = "select agent_id from agent where name='" + name + "'";
                    SqlDataAdapter x = new SqlDataAdapter(sql, dal.dbc.conn);
                    x.Fill(y);

                    string yy = (y.Rows[0]["agent_id"].ToString());
                    int xx = int.Parse(yy);
                    id = xx;
                }
                if (id != 0 && name == null)
                {
                    DataTable y = new DataTable();
                    string sql = "select name from agent where agent_id=" + id + "";
                    SqlDataAdapter x = new SqlDataAdapter(sql, dal.dbc.conn);
                    x.Fill(y);

                    name = (y.Rows[0]["name"].ToString());

                }

                string offname = TextBox3.Text;
                decimal discount = decimal.Parse(TextBox4.Text);//للتعديل معالة اسم بدون رقم 
                int date = int.Parse(TextBox5.Text);
             //   DateTime sdate = DateTime.Parse(TextBox6.Text);
             //   DateTime edate = DateTime.Parse(TextBox7.Text);

              //  ss.add_offer(id, offname, discount, date, sdate, edate);

                GridView1.DataSource = ss.getData_offer(id, name);
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        
    }
    }
}