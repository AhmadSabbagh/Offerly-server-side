using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace orgproject
{
    public partial class addofferagent : System.Web.UI.Page
    {
        dal.customer ss = new dal.customer();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)Session["tt"];
                string name = TextBox3.Text;
                string descr =TextBox4.Text;
               // int date = int.Parse(TextBox5.Text);
                string sdate = TextBox6.Text;
                string edate = TextBox7.Text;
                int n = ss.add_offer(id, name, descr, sdate, edate);
                //   ss.add_notification(id, 1, 0, name);
                /*if (id==0 && name !=null)
                {
                    DataTable y = new DataTable();
                    string sql = "select agent_id from agent where name='" + name + "'";
                    SqlDataAdapter x = new SqlDataAdapter(sql, dal.dbc.conn);
                    x.Fill(y);
                    
                    string yy = (y.Rows[0]["agent_id"].ToString());
                    int xx = int.Parse(yy);
                    id=xx;
                }
                if (id != 0 && name == null)
                {
                    DataTable y = new DataTable();
                    string sql = "select name from agent where agent_id=" + id + "";
                    SqlDataAdapter x = new SqlDataAdapter(sql, dal.dbc.conn);
                    x.Fill(y);

                     name = (y.Rows[0]["name"].ToString());
                    
                }*/


                if (n > 0)
                {
                    Label1.Text = "تمت اضافة العرض بنجاح";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                 //   TextBox5.Text = "";
                    TextBox6.Text = "";
                    TextBox7.Text = "";
                    Response.Redirect("pictureagent.aspx");
                }
                else
                    Label1.Text = "لم يتم اضافة العرض ";


                // GridView1.DataSource = ss.getData_offer(id, name);                   
                // GridView1.DataBind();

            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = (int)Session["tt"];
                string news = TextBox1.Text;
                string d = TextBox8.Text;
                int l = ss.add_news(x, news, d);

                //ss.add_notification(x, 0, 1, news);
                if (l > 0)
                {
                    Label2.Text = "تمت اضافة الخبر للزبون";
                    Response.Redirect("pictureagent.aspx");
                }
                else
                    Label2.Text = "لم تتم اضافة الخبر ";
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                dal.dbc.conn.Close();
            }
        }
    }
}