using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Globalization;
using System.Net;
//using System.Text;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;

namespace orgproject
{
    public partial class agent_offer : System.Web.UI.Page
    {
        dal.customer ss = new dal.customer();
        int id = 0;
        string name = null;
        protected void Page_Load(object sender, EventArgs e)
        {
          
           
            if (Session["t"] != null || Session["tt"] != null)
            {
                if (!IsPostBack)
                {
                    DropDownList1.DataSource = ss.getData_agent();
                    DropDownList1.DataTextField = "name";
                    DropDownList1.DataValueField = "agent_id";
                    DropDownList1.DataBind();
                    DropDownList4.DataSource = ss.getData_agent();
                    DropDownList4.DataTextField = "name";
                    DropDownList4.DataValueField = "agent_id";
                    DropDownList4.DataBind();
                   
                    DropDownList5.DataSource = ss.getData_offer();
                    DropDownList5.DataTextField = "offer_name";
                    DropDownList5.DataValueField = "offer_id";
                    DropDownList5.DataBind();
                    DataTable Dt = new DataTable();
                    SqlDataAdapter Da = new SqlDataAdapter("select * from news", dal.dbc.conn);
                    Da.Fill(Dt);
                    DropDownList6.DataSource = Dt;
                    DropDownList6.DataTextField = "news_name";
                    DropDownList6.DataValueField = "new_id";
                    DropDownList6.DataBind();

                }
                if (Session["t"] != null)
                {
                    bool o = false;
                    int h = (int)Session["t"];
                    SqlCommand cmd2 = new SqlCommand("select state from admin_permissions where admin_id=" + h + "and per_name='add offers' ", dal.dbc.conn);
                    SqlDataReader reader;
                    dal.dbc.conn.Open();
                    reader = cmd2.ExecuteReader();
                    while (reader.Read())
                    {
                        o = reader.GetBoolean(0);
                    }
                    reader.Close();
                    dal.dbc.conn.Close();

                    if (o == false)
                    {
                        //Button3.Enabled = false;
                        Button2.Enabled = false;
                        Button4.Enabled = false;
                        Button5.Enabled = false;
                    }


                    bool oo = false;
                    // int h = (int)Session["t"];
                    SqlCommand cmd3 = new SqlCommand("select state from admin_permissions where admin_id=" + h + "and per_name='add offers' ", dal.dbc.conn);
                    SqlDataReader reader3;
                    dal.dbc.conn.Open();
                    reader3 = cmd3.ExecuteReader();
                    while (reader3.Read())
                    {
                        oo = reader3.GetBoolean(0);
                    }
                    reader3.Close();
                    dal.dbc.conn.Close();

                    if (oo == false)
                    {
                        //Button3.Enabled = false;
                        Button1.Enabled = false;
                        Button4.Enabled = false;
                        Button5.Enabled = false;
                    }
                }

                if (Session["tt"] != null)
                {
                    int h11 = (int)Session["tt"];
                    bool o1 = false;

                    SqlCommand cmd4 = new SqlCommand("select state from agent_permissions where agent_id=" + h11 + "and per_name='add offer' ", dal.dbc.conn);
                    SqlDataReader reader4;
                    dal.dbc.conn.Open();
                    reader4 = cmd4.ExecuteReader();
                    while (reader4.Read())
                    {
                        o1 = reader4.GetBoolean(0);
                    }
                    reader4.Close();
                    dal.dbc.conn.Close();

                    if (o1 == false)
                    {
                        //Button3.Enabled = false;
                        Button2.Enabled = false;
                     //   Button4.Enabled = false;
                      //  Button5.Enabled = false;
                    }


                    bool oo1 = false;
                    // int h = (int)Session["t"];
                    SqlCommand cmd5 = new SqlCommand("select state from agent_permissions where agent_id=" + h11 + "and per_name='add news' ", dal.dbc.conn);
                    SqlDataReader reader5;
                    dal.dbc.conn.Open();
                    reader5 = cmd5.ExecuteReader();
                    while (reader5.Read())
                    {
                        oo1 = reader5.GetBoolean(0);
                    }
                    reader5.Close();
                    dal.dbc.conn.Close();

                    if (oo1 == false)
                    {
                        //Button3.Enabled = false;
                        Button1.Enabled = false;
                      //  Button4.Enabled = false;
                      //  Button5.Enabled = false;
                    }

                    bool y = false;
                    // int h = (int)Session["t"];
                    SqlCommand cmd7 = new SqlCommand("select state from agent_permissions where agent_id=" + h11 + "and per_name='delete offer' ", dal.dbc.conn);
                    SqlDataReader reader7;
                    dal.dbc.conn.Open();
                    reader7 = cmd7.ExecuteReader();
                    while (reader7.Read())
                    {
                        y = reader7.GetBoolean(0);
                    }
                    reader7.Close();
                    dal.dbc.conn.Close();

                    if (y == false)
                    {
                      //  Button3.Enabled = false;
                       // Button1.Enabled = false;
                          Button4.Enabled = false;
                          Button5.Enabled = false;
                    }

                    bool yy = false;
                    // int h = (int)Session["t"];
                    SqlCommand cmd9 = new SqlCommand("select state from agent_permissions where agent_id=" + h11 + "and per_name='edit offer' ", dal.dbc.conn);
                    SqlDataReader reader9;
                    dal.dbc.conn.Open();
                    reader9 = cmd9.ExecuteReader();
                    while (reader9.Read())
                    {
                        yy = reader9.GetBoolean(0);
                    }
                    reader9.Close();
                    dal.dbc.conn.Close();

                    if (yy == false)
                    {
                        //  Button3.Enabled = false;
                         Button6.Enabled = false;
                        Button7.Enabled = false;
                        Button8.Enabled = false;
                    }
                }
            }
            else
                Response.Redirect("Login.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(DropDownList1.SelectedValue);
                string news = TextBox1.Text;
                string d = TextBox8.Text;
                int l = ss.add_news(x, news,d);

                //ss.add_notification(x, 0, 1, news);
                if (l > 0)
                {
                    Label2.Text = "تمت اضافة الخبر للزبون";
                

                    
                    Response.Redirect("picture.aspx");
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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(DropDownList4.SelectedValue);
                string name = TextBox3.Text;
                string descr = TextBox4.Text;
               // int date = int.Parse(TextBox5.Text);
              DateTime  sd =DateTime.Parse(TextBox6.Text);
                string xx = sd.ToString("yyyy-MM-dd hh:mm");

                DateTime ed = DateTime.Parse(TextBox7.Text);
                string yy = ed.ToString("yyyy-MM-dd hh:mm");

                int n = ss.add_offer(id, name, descr, xx, yy);
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
                  //  TextBox5.Text = "";
                    TextBox6.Text = "";
                    TextBox7.Text = "";
                    Response.Redirect("picture.aspx");
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

        protected void Timer1_Tick(object sender, EventArgs e)
        {


        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            



        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int x = int.Parse(DropDownList5.SelectedValue);
            try
            {
                SqlCommand cmd = new SqlCommand("delete from offers where offer_id=" + x + "", dal.dbc.conn);
                dal.dbc.conn.Open();
                int result = cmd.ExecuteNonQuery();
                dal.dbc.conn.Close();
                if (result != 0)
                    Label3.Text = "تم حذف العرض بنجاح ";
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);

            }

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            int x = int.Parse(DropDownList6.SelectedValue);
            try
            {
                SqlCommand cmd = new SqlCommand("delete from news where new_id=" + x + "", dal.dbc.conn);
                dal.dbc.conn.Open();
                int result = cmd.ExecuteNonQuery();
                dal.dbc.conn.Close();
                if (result != 0)
                    Label3.Text = "تم حذف الخبر بنجاح ";
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);

            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            string o = null;
            string d = null;
            int t = 0;
            DateTime s = default(DateTime);
            DateTime end = default(DateTime);
            int y = int.Parse(DropDownList7.SelectedValue);
            try
            {
                SqlCommand cmd2 = new SqlCommand("select offer_name,descr,start_time,end_time from offers where offer_id=" + y + " ", dal.dbc.conn);
                SqlDataReader reader;
                dal.dbc.conn.Open();
                reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    o = reader.GetString(0);
                    d = reader.GetString(1);
                    t = reader.GetInt32(2);
                    s = reader.GetDateTime(3);
                    end = reader.GetDateTime(4);
                }
                reader.Close();
                dal.dbc.conn.Close();

                TextBox3.Text = o;
                TextBox4.Text = d + "";
              //  TextBox5.Text = t + "";
                TextBox6.Text = s + "";
                TextBox7.Text = end + "";
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);

            }

        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            int x = int.Parse(DropDownList4.SelectedValue);
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select * from offers where agentoff_id="+x+"", dal.dbc.conn);
            Da.Fill(Dt);
            DropDownList7.DataSource = Dt;
            DropDownList7.DataTextField = "offer_name";
            DropDownList7.DataValueField = "offer_id";
            DropDownList7.DataBind();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
           string o= TextBox3.Text ;
          string d=TextBox4.Text;
        //  int t=int.Parse(TextBox5.Text);
            DateTime sdate = DateTime.Parse(TextBox6.Text);
            DateTime edate = DateTime.Parse(TextBox7.Text);
            string yy = sdate.ToString("yyyy-MM-dd hh:mm");
            string xx = edate.ToString("yyyy-MM-dd hh:mm");
            int x = int.Parse(DropDownList7.SelectedValue);
            try
            {
                SqlCommand cmd5 = new SqlCommand("update offers  set offer_name ='" + o + "',descr=" + d + ",start_time='" + yy + "',end_time='" + xx + "' where offer_id=" + x + "", dal.dbc.conn);
                dal.dbc.conn.Open();
                cmd5.ExecuteNonQuery();
                dal.dbc.conn.Close();
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);

            }
        }
    }
}