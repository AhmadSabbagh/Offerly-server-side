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
    public partial class server : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //add server
        /*   int result = 0;
            string ip = "";
            string host_name = "";
            string nice_name = "";
            bool type = false;
            decimal price = 0;
            string company = "";
            string username_at_company = "";
            DateTime d = DateTime.Parse(--);
            string date = d.ToString("yyyy-MM-dd");
            bool add_day = false;
            string sql = "insert into offers (ip,host_name,nice_name,type,price,company,username_at_company,date,add_day) values ('"+ ip +"','"+ host_name +"','"+ nice_name+"'," + type + ","+price+",'"+ company +"','" + username_at_company + "','" + date + "',"+ add_day+")";
            SqlCommand cmd = new SqlCommand(sql, dal.dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();


            // 
            DataTable y = new DataTable();
            string sql = "select ip,host_name,nice_name,type,price,company,username_at_company,date,add_day from server order by date";
            SqlDataAdapter x = new SqlDataAdapter(sql, dal.dbc.conn);
            x.Fill(y);
            GridView1.DataSource = y;
            GridView1.DataBind();

            //
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            int d = DateTime.Now.Day ;
            int m= DateTime.Now.Month;
            int y= DateTime.Now.Year;
            if (month==2 && day==27)
            {
                day = 1;
                month = 3;

            }
            else
            if (day == 29 || day == 30)
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
                day = day + 2;
            DataTable y = new DataTable();
            string sql = "select ip,host_name,nice_name,type,price,company,username_at_company,date,add_day from server where  Month(date)<=" + month + "and Month(date)>=" + m + " and day(date)<=" + day + " and day(date)>=" + d + " and Year(date)<=" + year + "  and Year(date)>=" + y + "";
            SqlDataAdapter x = new SqlDataAdapter(sql, dal.dbc.conn);
            x.Fill(y);
            GridView1.DataSource = y;
            GridView1.DataBind();









            //دفعت خلال الشهر

            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
           
            
            DataTable y = new DataTable();
            string sql = "select ip,host_name,nice_name,type,price,company,username_at_company,date,add_day from server_pay where  Month(date)=" + month + "";
            SqlDataAdapter x = new SqlDataAdapter(sql, dal.dbc.conn);
            x.Fill(y);
            GridView1.DataSource = y;
            GridView1.DataBind();

            //التي لم تدفع 

            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;


            DataTable y = new DataTable();
            string sql = "select ip,host_name,nice_name,type,price,company,username_at_company,date,add_day from server where  Month(date)=" + month + " minus (select ip,host_name,nice_name,type,price,company,username_at_company,date,add_day from server_pay where  Month(date)=" + month + ")";
            SqlDataAdapter x = new SqlDataAdapter(sql, dal.dbc.conn);
            x.Fill(y);
            GridView1.DataSource = y;
            GridView1.DataBind();




            //كامل المبلغ 
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;


            DataTable y = new DataTable();
            string sql = "select sum(price) from server where  Month(date)=" + month + "";
            SqlDataAdapter x = new SqlDataAdapter(sql, dal.dbc.conn);
            x.Fill(y);
            //  GridView1.DataSource = y;
            //   GridView1.DataBind();


            //المدفوعات

            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;


            DataTable y = new DataTable();
            string sql = "select ip,host_name,nice_name,price from server where  Month(date)=" + month + " minus (select ip,host_name,nice_name,price from server_pay where  Month(date)=" + month + ")";
            SqlDataAdapter x = new SqlDataAdapter(sql, dal.dbc.conn);
            x.Fill(y);
            GridView1.DataSource = y;
            GridView1.DataBind();

            //كامل المبلغ المدفوع
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;


            DataTable y = new DataTable();
            string sql = "select sum(price) from server_pay where  Month(date)=" + month + "";
            SqlDataAdapter x = new SqlDataAdapter(sql, dal.dbc.conn);
            x.Fill(y);
            //  GridView1.DataSource = y;
            //   GridView1.DataBind();


            //مجموع السرفرات

            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;


            DataTable y = new DataTable();
            string sql = "select sum(price),count(ip) from server_pay where  Month(date)=" + month + "";
            SqlDataAdapter x = new SqlDataAdapter(sql, dal.dbc.conn);
            x.Fill(y);

            */


        }
    }
}