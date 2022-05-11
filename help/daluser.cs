using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace orgproject.dal
{
    public class daluser
    {
        public int add(entityuser entity)
        {
            int result = 0;
            string sql = "insert into users (employeeid,username,password) values ("+ entity.employeeid +",'"+ entity.username +"','" + entity.password + "')";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();
            
            return result;
        }

        public int edit(entityuser entity)
        {
            int result = 0;
            string sql = "update users  set  username= '" + entity.username + "',password='" + entity.password +"'where employeeid="+ entity.employeeid +")";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }

        public int removeall()
        {
            int result = 0;
            string sql = "delet from users ";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }

        public int remove(entityuser entity)
        {
            int result = 0;
            string sql = "delet from users where employeeid=" + entity.employeeid + ")";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }
        public DataTable getData(entityuser entity = null)
        {
        DataTable table = new DataTable();
        string sql = "select * from users,employee where users.employeeid= employee.employeeid ";
        if (entity !=null)
            {
            if (entity.employeeid !=0)
            sql=sql+ " and employeeid ="+entity.employeeid;

             if (entity.username !=null)
            sql=sql+ " and username ='"+entity.username +"' ";

             if (entity.password !=null)
            sql=sql+ " and password ='"+entity.password +"' ";

    }

    SqlDataAdapter adapter = new SqlDataAdapter(sql, dbc.conn);
    adapter.Fill(table);
    return table;
    }
}}