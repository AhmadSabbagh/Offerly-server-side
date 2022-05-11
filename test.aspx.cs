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
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
         //   string x = 
         //   Label1.Text = x;
            /*  try
              {
                  DataTable y = new DataTable();
                  string sql = "select advert_id from advert where name='mohmmed'";
                  SqlDataAdapter x = new SqlDataAdapter(sql, dal.dbc.conn);
                  x.Fill(y);
                  // Session["fn"] = y.Rows[0]["Name"].ToString();
                  string yy = (y.Rows[0]["advert_id"].ToString());
                  int xx = int.Parse(yy);
                  Label1.Text = xx + "";


              }
              catch (Exception ex)
              {
                  Response.Write(ex.Message);
              }
          }

          protected void Button3_Click(object sender, EventArgs e)
          {
              dal.customer ccc = new dal.customer();
              int x = int.Parse(TextBox1.Text);
              int h = ccc.remove_childbrith(x);
              if (h > 0)
              {
                  Label1.Text = "save succ";
                  GridView1.DataSource = ccc.getData_childbrith();
                  GridView1.DataBind();
              }

          }*/
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Label2.Text = DateTime.Now.ToString();
        }
    }
}