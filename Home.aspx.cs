using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace orgproject
{
    public partial class Home : System.Web.UI.Page
    {
        orgproject.dal.customer adm = new orgproject.dal.customer();
        dal.ReturnData re = new dal.ReturnData();
        static int id = 0;
       static DateTime end = default(DateTime);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["t"] != null)
            {
                if (!IsPostBack)
                {
                    TextBox1.Visible = false;
                    TextBox2.Visible = false;
                    Label1.Visible = false;
                    Label2.Visible = false;
                    Button8.Visible = false;
                    Label3.Visible = false;
                    Button9.Visible = false;
                    Label4.Visible = false;
                    Label5.Visible = false;
                    DropDownList1.Visible = false;
                    Button11.Visible = false;
                    Button12.Visible = false;

                }
            }
            else
                Response.Redirect("Login.aspx");
            int h = (int)Session["t"];
            int y = h + 1;
            if (h != 1)
            {
                Button6.Enabled = false;
                Button5.Enabled = false;
                Button7.Enabled = false;
                Button10.Enabled = false;
            }


            /*    DataTable table = (DataTable)Session["t"];
               string h  = table.Rows[0]["admin_id"].ToString();
                int x = int.Parse(h);
                if (x == 1)
                    Button6.Visible = false;*/
            int day = 0;
           
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            int d = DateTime.Now.Day;
            if (d == 30 || d == 31)
            {
                day = 1;
                 month = month + 1;
                if (month == 13)
                {
                    month = 1;
                    year = year + 1;
                }
                
            }
            else
                day = d + 2;
            string off = null;
            
           // DateTime end = default(DateTime);
          /*  string sql = "select offer_name,end_time,offer_id from offers where Month(end_time)=" + month + " and day(end_time)=" + day + " and Year(end_time)=" + year + "";
            SqlCommand cmd2 = new SqlCommand(sql, dal.dbc.conn);
            SqlDataReader reader;
            dal.dbc.conn.Open();
            reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                off = reader.GetString(0);
                end = reader.GetDateTime(1);
                id = reader.GetInt32(2);
            }
            reader.Close();
            dal.dbc.conn.Close();
            if (off != null)
            {
                Label6.Text = " سينتهي العرض بعد غدا يرجى الذهاب لصفحة تعديل العروض لتعديل تاريخ نهاية العرض" + off + "";
                Button11.Visible = true;
                Button12.Visible = true;
            }
                int month1 = DateTime.Now.Month;
            int year1 = DateTime.Now.Year;
            int d1 = DateTime.Now.Day;
            int off1 = 0;
            DateTime end1 = default(DateTime);
            string sql1 = "select offer_id,end_time from offers where Month(end_time)=" + month1 + " and day(end_time)=" + d1 + " and Year(end_time)=" + year1 + " ";
            SqlCommand cmd7 = new SqlCommand(sql1, dal.dbc.conn);
            SqlDataReader reader2;
            dal.dbc.conn.Open();
            reader2 = cmd7.ExecuteReader();
            while (reader2.Read())
            {
                off1 = reader2.GetInt32(0);
                end1 = reader2.GetDateTime(1);
            }
            reader2.Close();
            // dal.dbc.conn.Close();
            string sql3 = null;
            
                sql3 = "delete from offers where offer_id="+ off1 +"";
            SqlCommand cmd8 = new SqlCommand(sql3, dal.dbc.conn);
            cmd8.ExecuteNonQuery();
            dal.dbc.conn.Close();*/

        }
        public string SHA512(string pass)
        {
            SHA512Managed SHA512 = new SHA512Managed();
            byte[] Hash = System.Text.Encoding.UTF8.GetBytes(pass);
            Hash = SHA512.ComputeHash(Hash);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in Hash)
            {
                sb.Append(b.ToString("x2").ToLower());
            }
            return sb.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            TextBox1.Visible = true;
            TextBox2.Visible = true;
            Label1.Visible = true;
            Label2.Visible = true;
            Label1.Text = "اسم الادمن الجديد";
            Label2.Text = "كلمة السر";
            Button8.Visible = true;
            Button9.Visible = false;
            Label4.Visible = false;
            Label5.Visible = false;
            DropDownList1.Visible = false;

        }

        protected void Button8_Click(object sender, EventArgs e)
        {

            try
            {
                Label3.Visible = true;
                string name = TextBox1.Text;
                string pass = TextBox2.Text;
                string password = SHA512(TextBox2.Text);
                int n = adm.add_admin(name, password);
                // int n = re.id;
                if (n > 0)
                    Label3.Text = " تمت اضافة ادمن جديد بدون صلاحيات برقم سر '" + pass + "' ";
                else
                    Label3.Text = "لم تتم الاضافة  ";

                TextBox1.Visible = false;
                TextBox2.Visible = false;
                Label1.Visible = false;
                Label2.Visible = false;
                Button8.Visible = false;
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);

            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            TextBox1.Visible = false;
            TextBox2.Visible = false;
            Label1.Visible = false;
            Label2.Visible = false;
            Button8.Visible = false;
            Label3.Visible = false;
           
            Label4.Visible = true;
            DropDownList1.Visible = true;
            Label4.Text = "اسم الادمن ";
            Button9.Visible = true;
            DropDownList1.DataSource = adm.getData_admin();
            DropDownList1.DataTextField = "admin_name";
            DropDownList1.DataValueField = "admin_id";
            DropDownList1.DataBind();

        }

        protected void Button9_Click(object sender, EventArgs e)
        {

        }

        protected void Button9_Click1(object sender, EventArgs e)
        {
            try
            {
                Label5.Visible = true;
                int id = int.Parse(DropDownList1.SelectedValue);
                int n=  adm.remove_admin(id);
               // int n = re.id;
                if (n != 0)
                    Label5.Text = "تم الحذف بنجاح ";
                else
                    Label5.Text = "لم يتم الحذف  ";
                TextBox1.Visible = false;

                DropDownList1.Visible = false;
                Label4.Visible = false;
                Button9.Visible = false;
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);

            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("agent_permissions.aspx");
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            try
            {
                int year = DateTime.Now.Year;
                int x = end.Day;
                int y = end.Month;
                int xx = x + 45;
                while (xx > 30)
                {
                    xx = xx - 30;
                    y = y + 1;
                    if (y == 13)
                    {
                        y = 1;
                        year = year + 1;
                    }
                }

                DateTime date1 = new DateTime(year, y, xx, 12, 00, 0);
                string sql3 = "update offers set end_time='" + date1 + "' where offer_id=" + id + "";
                SqlCommand cmd8 = new SqlCommand(sql3, dal.dbc.conn);
                dal.dbc.conn.Open();
                int m = cmd8.ExecuteNonQuery();
                dal.dbc.conn.Close();
                if (m != 0)
                    Label6.Text = "تم التمديد 45 يوم ";
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);

            }
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            Response.Redirect("agent_offer.aspx");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin_permissions.aspx");
        }
    }
}