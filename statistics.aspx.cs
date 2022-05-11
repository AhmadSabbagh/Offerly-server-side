using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace orgproject
{
    public partial class statistics : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["t"] != null || Session["tt"] != null)
            {
                try
                {
                    int month = DateTime.Now.Month;
                    int year = DateTime.Now.Year;
                    int day = DateTime.Now.Day;
                    int o = 0;
                    int d = 0;
                    int m = 0;
                    int y = 0;
                    SqlDataReader reader, reader2, reader3, reader4;
                    string sql = " select count(customer_id) from online  ";
                    string sql2 = "select count(customer_id) from trace_login where date.Month =" + month + "   ";
                    string sql3 = "select count(customer_id) from trace_login where date.Year =" + year + "   ";
                    string sql4 = "select count(customer_id) from trace_login where date.Day =" + day + "   ";

                    SqlCommand cmd = new SqlCommand(sql, dal.dbc.conn);
                    SqlCommand cmd2 = new SqlCommand(sql2, dal.dbc.conn);
                    SqlCommand cmd3 = new SqlCommand(sql3, dal.dbc.conn);
                    SqlCommand cmd4 = new SqlCommand(sql4, dal.dbc.conn);
                    cmd.CommandType = CommandType.Text;
                    cmd2.CommandType = CommandType.Text;
                    cmd3.CommandType = CommandType.Text;
                    cmd4.CommandType = CommandType.Text;

                    dal.dbc.conn.Open();

                    reader = cmd.ExecuteReader();
                    reader2 = cmd2.ExecuteReader();
                    reader3 = cmd3.ExecuteReader();
                    reader4 = cmd4.ExecuteReader();
                    while (reader.Read())
                    {
                        o = reader.GetInt32(0);
                    }
                    while (reader2.Read())
                    {
                        m = reader.GetInt32(0);
                    }
                    while (reader3.Read())
                    {
                        y = reader.GetInt32(0);
                    }
                    while (reader4.Read())
                    {
                        d = reader.GetInt32(0);
                    }
                    reader.Close();
                    reader2.Close();
                    reader3.Close();
                    reader4.Close();
                    dal.dbc.conn.Close();
                    TextBox1.Enabled = false;
                    TextBox1.Text = o.ToString();
                    TextBox2.Enabled = false;
                    TextBox2.Text = d.ToString();
                    TextBox3.Enabled = false;
                    TextBox3.Text = m.ToString();
                    TextBox4.Enabled = false;
                    TextBox4.Text = y.ToString();

                }
                catch
                {
                    dal.dbc.conn.Close();
                }

                DropDownList2.Visible = false;
                Button10.Visible = false;
                DropDownList1.Visible = false;
                Button11.Visible = false;
                DropDownList3.Visible = false;
                Button12.Visible = false;
                Label1.Visible = false;
                Label2.Visible = false;
                Label3.Visible = false;
                TextBox5.Visible = false;
                TextBox6.Visible = false;
                TextBox7.Visible = false;
                DropDownList4.Visible = false;
                Button13.Visible = false;

                if (Session["t"] != null)
                {
                    bool oo = false;
                    int h = (int)Session["t"];
                    SqlCommand cmd5 = new SqlCommand("select state from admin_permissions where admin_id=" + h + "and per_name='view statistic' ", dal.dbc.conn);
                    SqlDataReader reader5;
                    dal.dbc.conn.Open();
                    reader5 = cmd5.ExecuteReader();
                    while (reader5.Read())
                    {
                        oo = reader5.GetBoolean(0);
                    }
                    reader5.Close();
                    dal.dbc.conn.Close();

                    if (oo == false)
                    {
                        Button7.Enabled = false;
                        Button8.Enabled = false;
                        Button9.Enabled = false;
                    }
                }
                if (Session["tt"] != null)
                {
                    bool oo2 = false;
                    int h1 = (int)Session["tt"];
                    SqlCommand cmd6 = new SqlCommand("select state from admin_permissions where admin_id=" + h1 + "and per_name='view statistic' ", dal.dbc.conn);
                    SqlDataReader reader6;
                    dal.dbc.conn.Open();
                    reader6 = cmd6.ExecuteReader();
                    while (reader6.Read())
                    {
                        oo2 = reader6.GetBoolean(0);
                    }
                    reader6.Close();
                    dal.dbc.conn.Close();

                    if (oo2 == false)
                    {
                        Button7.Enabled = false;
                        Button8.Enabled = false;
                        Button9.Enabled = false;
                    }
                    else
                    {
                        Button7.Enabled = false;
                        Button8.Enabled = true;
                        Button9.Enabled = false;
                    }
                }
            }
            else
                Response.Redirect("Login.aspx");

        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("customer_classification1.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            DropDownList1.Visible = true;
            Button11.Visible = true;
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            int x =int.Parse( DropDownList1.SelectedValue);
            if(x==4 || x == 5 || x == 6 || x == 1 || x ==2)
            {
                DropDownList2.Visible = true;
                Button10.Visible = true;
                DropDownList1.Visible = true;
                Button11.Visible = true;
            }
            if (x == 1)
            {
                DataTable Dt = new DataTable();
                SqlDataAdapter Da = new SqlDataAdapter("select * from offers", dal.dbc.conn);
                Da.Fill(Dt);
                DropDownList2.DataSource = Dt;
                DropDownList2.DataTextField = "offer_name";
                DropDownList2.DataValueField = "offer_id";
                DropDownList2.DataBind();
            }
            if (x == 2||x==4)
            {
                DataTable Dt = new DataTable();
                SqlDataAdapter Da = new SqlDataAdapter("select * from advert", dal.dbc.conn);
                Da.Fill(Dt);
                DropDownList2.DataSource = Dt;
                DropDownList2.DataTextField = "advert";
                DropDownList2.DataValueField = "advert_id";
                DropDownList2.DataBind();
            }
            if (x == 5)
            {
                DataTable Dt = new DataTable();
                SqlDataAdapter Da = new SqlDataAdapter("select * from news", dal.dbc.conn);
                Da.Fill(Dt);
                DropDownList2.DataSource = Dt;
                DropDownList2.DataTextField = "t_news";
                DropDownList2.DataValueField = "new_id";
                DropDownList2.DataBind();
            }
            if (x == 6)
            {
                DataTable Dt = new DataTable();
                SqlDataAdapter Da = new SqlDataAdapter("select * from notification", dal.dbc.conn);
                Da.Fill(Dt);
                DropDownList2.DataSource = Dt;
                DropDownList2.DataTextField = "offername";
                DropDownList2.DataValueField = "id";
                DropDownList2.DataBind();
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            DropDownList3.Visible = true;
            Button12.Visible = true;
            
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            DropDownList4.Visible = true;
            Button13.Visible = true;
            DropDownList3.Visible = true;
            Button12.Visible = true;
            int x = int.Parse(DropDownList3.SelectedValue);
            if(x==1)
            {
                DataTable Dt = new DataTable();
                SqlDataAdapter Da = new SqlDataAdapter("select * from agent", dal.dbc.conn);
                Da.Fill(Dt);
                DropDownList4.DataSource = Dt;
                DropDownList4.DataTextField = "name";
                DropDownList4.DataValueField = "agent_id";
                DropDownList4.DataBind();
            }
            if (x == 2)
            {
                DataTable Dt = new DataTable();
                SqlDataAdapter Da = new SqlDataAdapter("select * from advert", dal.dbc.conn);
                Da.Fill(Dt);
                DropDownList4.DataSource = Dt;
                DropDownList4.DataTextField = "advert";
                DropDownList4.DataValueField = "advert_id";
                DropDownList4.DataBind();
            }
            if (x == 3)
            {
                DataTable Dt = new DataTable();
                SqlDataAdapter Da = new SqlDataAdapter("select * from offers", dal.dbc.conn);
                Da.Fill(Dt);
                DropDownList4.DataSource = Dt;
                DropDownList4.DataTextField = "offer_name";
                DropDownList4.DataValueField = "offer_id";
                DropDownList4.DataBind();
            }

        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            TextBox5.Visible = true;
            TextBox6.Visible = true;
            TextBox7.Visible = true;
            DropDownList4.Visible = true;
            Button13.Visible = true;
            DropDownList3.Visible = true;
            Button12.Visible = true;
            int x = int.Parse(DropDownList3.SelectedValue);
            int y = int.Parse(DropDownList4.SelectedValue);
            try
            {
                if (x == 1)
                {

                    int month = DateTime.Now.Month;
                    int year = DateTime.Now.Year;
                    int day = DateTime.Now.Day;
                    int yy = 0;
                    int d = 0;
                    int m = 0;

                    SqlDataReader reader, reader2, reader3;
                    string sql = "select count(customertrac_id) from tracking where agentt_id=" + y + " and time.Month =" + month + "";
                    string sql2 = "select count(customertrac_id) from tracking where agentt_id=" + y + " and time.Year =" + year + "   ";
                    string sql3 = "select count(customertrac_id) from tracking where agentt_id=" + y + " and time.Day =" + day + "   ";


                    SqlCommand cmd = new SqlCommand(sql, dal.dbc.conn);
                    SqlCommand cmd2 = new SqlCommand(sql2, dal.dbc.conn);
                    SqlCommand cmd3 = new SqlCommand(sql3, dal.dbc.conn);
                    cmd.CommandType = CommandType.Text;
                    cmd2.CommandType = CommandType.Text;
                    cmd3.CommandType = CommandType.Text;

                    dal.dbc.conn.Open();

                    reader = cmd.ExecuteReader();
                    reader2 = cmd2.ExecuteReader();
                    reader3 = cmd3.ExecuteReader();
                    while (reader.Read())
                    {
                        m = reader.GetInt32(0);
                    }
                    while (reader2.Read())
                    {
                        yy = reader.GetInt32(0);
                    }
                    while (reader3.Read())
                    {
                        d = reader.GetInt32(0);
                    }

                    reader.Close();
                    reader2.Close();
                    reader3.Close();
                    dal.dbc.conn.Close();

                    TextBox5.Enabled = false;
                    TextBox5.Text = d.ToString();
                    TextBox6.Enabled = false;
                    TextBox6.Text = m.ToString();
                    TextBox7.Enabled = false;
                    TextBox7.Text = y.ToString();

                }

                if (x == 2)
                {

                    int month = DateTime.Now.Month;
                    int year = DateTime.Now.Year;
                    int day = DateTime.Now.Day;
                    int yy = 0;
                    int d = 0;
                    int m = 0;

                    SqlDataReader reader, reader2, reader3;
                    string sql = "select count(customerstat_id)from statistic_advert where advertstat_id=" + y + " and  date.Month =" + month + "";
                    string sql2 = "select count(customerstat_id)from statistic_advert where advertstat_id=" + y + " and  date.Year =" + year + "";
                    string sql3 = "select count(customerstat_id)from statistic_advert where advertstat_id=" + y + " and  date.Day =" + day + "";


                    SqlCommand cmd = new SqlCommand(sql, dal.dbc.conn);
                    SqlCommand cmd2 = new SqlCommand(sql2, dal.dbc.conn);
                    SqlCommand cmd3 = new SqlCommand(sql3, dal.dbc.conn);
                    cmd.CommandType = CommandType.Text;
                    cmd2.CommandType = CommandType.Text;
                    cmd3.CommandType = CommandType.Text;

                    dal.dbc.conn.Open();

                    reader = cmd.ExecuteReader();
                    reader2 = cmd2.ExecuteReader();
                    reader3 = cmd3.ExecuteReader();
                    while (reader.Read())
                    {
                        m = reader.GetInt32(0);
                    }
                    while (reader2.Read())
                    {
                        yy = reader.GetInt32(0);
                    }
                    while (reader3.Read())
                    {
                        d = reader.GetInt32(0);
                    }

                    reader.Close();
                    reader2.Close();
                    reader3.Close();
                    dal.dbc.conn.Close();

                    TextBox5.Enabled = false;
                    TextBox5.Text = d.ToString();
                    TextBox6.Enabled = false;
                    TextBox6.Text = m.ToString();
                    TextBox7.Enabled = false;
                    TextBox7.Text = y.ToString();

                }
                if (x == 3)
                {
                    int month = DateTime.Now.Month;
                    int year = DateTime.Now.Year;
                    int day = DateTime.Now.Day;
                    int yy = 0;
                    int d = 0;
                    int m = 0;

                    SqlDataReader reader, reader2, reader3;
                    string sql = "select count(customerstat_id)from statistic_offer where offerstat_id=" + y + " and  date.Month =" + month + "";
                    string sql2 = "select count(customerstat_id)from statistic_offer where offerstat_id=" + y + " and  date.Year =" + year + "";
                    string sql3 = "select count(customerstat_id)from statistic_offer where offerstat_id = " + y + " and date.Day = " + day + "";


                    SqlCommand cmd = new SqlCommand(sql, dal.dbc.conn);
                    SqlCommand cmd2 = new SqlCommand(sql2, dal.dbc.conn);
                    SqlCommand cmd3 = new SqlCommand(sql3, dal.dbc.conn);
                    cmd.CommandType = CommandType.Text;
                    cmd2.CommandType = CommandType.Text;
                    cmd3.CommandType = CommandType.Text;

                    dal.dbc.conn.Open();

                    reader = cmd.ExecuteReader();
                    reader2 = cmd2.ExecuteReader();
                    reader3 = cmd3.ExecuteReader();
                    while (reader.Read())
                    {
                        m = reader.GetInt32(0);
                    }
                    while (reader2.Read())
                    {
                        yy = reader.GetInt32(0);
                    }
                    while (reader3.Read())
                    {
                        d = reader.GetInt32(0);
                    }

                    reader.Close();
                    reader2.Close();
                    reader3.Close();
                    dal.dbc.conn.Close();

                    TextBox5.Enabled = false;
                    TextBox5.Text = d.ToString();
                    TextBox6.Enabled = false;
                    TextBox6.Text = m.ToString();
                    TextBox7.Enabled = false;
                    TextBox7.Text = y.ToString();
                }
            }
            catch
            {
                dal.dbc.conn.Close();
            }
        
            //جمل if
            //select count(customertrac_id) from tracking where agentt_id=x and time.Month =" + month + ";//
            //select count ( customerstat_id)from statistic_advert where advertstat_id=x and  date.Month =" + month + " //وكذالك للايام والسنة
            //select count(customerstat_id)from statistic_offer where offer_id=x and  date.Month =" + month + " //وكذالك للايام والسنة
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            DropDownList2.Visible = true;
            Button10.Visible = true;
            DropDownList1.Visible = true;
            Button11.Visible = true;
            int x = int.Parse(DropDownList1.SelectedValue);
            int y = int.Parse(DropDownList2.SelectedValue);
            try
            {
                if (x == 1)
                {
                    DataTable Dt1 = new DataTable();
                    SqlDataAdapter Da1 = new SqlDataAdapter("select email,offer_name from post_offer_news,offers,customer where offerp_id=" + y + " and customerp_id=customer_id and offerp_id=offer_id", dal.dbc.conn);
                    Da1.Fill(Dt1);
                    GridView1.DataSource = Dt1;
                    GridView1.DataBind();
                }
                if (x == 2)
                {
                    DataTable Dt1 = new DataTable();
                    SqlDataAdapter Da1 = new SqlDataAdapter("select email,news_name from post_offer_news,advert,customer where advertp_id=" + y + " and customerp_id=customer_id and advertp_id=advert_id", dal.dbc.conn);
                    Da1.Fill(Dt1);
                    GridView1.DataSource = Dt1;
                    GridView1.DataBind();
                }
                if (x == 3)
                {
                    DataTable Dt1 = new DataTable();
                    SqlDataAdapter Da1 = new SqlDataAdapter("select destinct email from customer,point_customer where cust_id=customer_id", dal.dbc.conn);
                    Da1.Fill(Dt1);
                    GridView1.DataSource = Dt1;
                    GridView1.DataBind();
                }
                if (x == 4)
                {
                    DataTable Dt1 = new DataTable();
                    SqlDataAdapter Da1 = new SqlDataAdapter("select email,n_of_second,count(customerstat_id) from statistic_advert,customer where advertstat_id=" + y + " and customerstat_id=customer_id", dal.dbc.conn);
                    Da1.Fill(Dt1);
                    GridView1.DataSource = Dt1;
                    GridView1.DataBind();
                }
                if (x == 5)
                {
                    DataTable Dt1 = new DataTable();
                    SqlDataAdapter Da1 = new SqlDataAdapter("select email,n_of_second,count(customerstat_id) from statistic_news,customer where newsstat_id=" + y + " and customerstat_id=customer_id", dal.dbc.conn);
                    Da1.Fill(Dt1);
                    GridView1.DataSource = Dt1;
                    GridView1.DataBind();
                }
                if (x == 6)
                {
                    DataTable Dt1 = new DataTable();
                    SqlDataAdapter Da1 = new SqlDataAdapter("select email,n_of_second,count(customerstat_id) from statistic_notification,customer where notification_id=" + y + " and customerstat_id=customer_id", dal.dbc.conn);
                    Da1.Fill(Dt1);
                    GridView1.DataSource = Dt1;
                    GridView1.DataBind();
                }
            }
            catch
            {
                dal.dbc.conn.Close();
            }
            //1 select email,offer_name from post_offer_news,offers,customer where offerp_id=x and customerp_id=customer_id and offerp_id=offer_id
            //2 select email,news_name from post_offer_news,news,customer where newsp_id=x and customerp_id=customer_id and newsp_id=new_id
            //3 select destinct email from customer,point_customer where cust_id=customer_id
            //4 select email,n_of_second,count(customerstat_id)where advertstat_id=x and customerstat_id=customer_id
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            Response.ClearContent();
            // Response.Buffer = false;
            Response.AppendHeader("content-disposition", string.Format("attachment; filename=customer.xls"));
            Response.ContentType = "application/excel";
            StringWriter stringWriter = new StringWriter();
            HtmlTextWriter htmlTextWriter = new HtmlTextWriter(stringWriter);
            // GridView1.AllowPaging = false;

            GridView1.RenderControl(htmlTextWriter);
            Response.Write(stringWriter.ToString());
            Response.End();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
    
    }
}