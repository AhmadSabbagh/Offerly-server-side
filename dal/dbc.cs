using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace orgproject.dal
{
    public class dbc
    {

   //  public static SqlConnection conn = new SqlConnection("Data Source=AMER-PC\\HKIMI;Initial Catalog=company;Integrated Security=True;user id=user1;password=user1@test");
 //  public static SqlConnection conn = new SqlConnection("Data Source=H-PC\\SQLEXPRESS;Initial Catalog=company;Integrated Security=True");
      public static SqlConnection conn = new SqlConnection("Data Source=WIN-D01OGI1CJ8S\\SQLEXPRESS;Initial Catalog=company;Integrated Security=True;user id=user1;password=user1@test");

    }
}

//;user id=user1;password=user1@test
//Data Source=H-PC\SQLEXPRESS;Initial Catalog=company;Integrated Security=True
//Data Source=AMER-PC\\HKIMI;Initial Catalog=company;Integrated Security=True
//Data Source=AMER-PC\HKIMI;Initial Catalog=company;Integrated Security=True
//عند الرفع للسرفر في ويب كونفج 
//Data Source=hamos.stell-host.com\SQLEXPRESS;Initial Catalog=company;Integrated Security=True;user id=user1;password=user1@test
//عند الرفع للسرفر في كلاس الربط
//Data Source=WIN-D01OGI1CJ8S\\SQLEXPRESS;Initial Catalog=company;Integrated Security=True;user id=user1;password=user1@test
//عند تحديث الداتا بيز نغير السيكورتي جرانت مثل هذا الرابط
//https://stackoverflow.com/questions/7698286/login-failed-for-user-iis-apppool-asp-net-v4-0

/*
 * 
 DataTable y = new DataTable();
            string sql = "select agent_id from agent where name='" + name + "'";
            SqlDataAdapter x = new SqlDataAdapter(sql, dal.dbc.conn);
            x.Fill(y);
            if (y.Rows.Count > 0)
            {
                string yy = (y.Rows[0]["agent_id"].ToString());
                int xx = int.Parse(yy);
                id = xx;
*/
