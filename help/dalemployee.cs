using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace orgproject.dal
{
    public class dalemployee
    {

        public int add(entityemployee entity)
        {
            int result = 0;
            string sql = "insert into employee (employeename,salary,gender,deptid) values ('" + entity.employeename + "','" + entity.salary + "','" + entity.gender + "'," + entity.deptid+ ")";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }

        public int edit(entityemployee entity)
        {
            int result = 0;
            string sql = "update employee  set  employeename= '" + entity.employeename + "',salary='" + entity.salary +"',deptid='"+entity.deptid+ "'where employeeid=" + entity.employeeid + "";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }

        public int removeall()
        {
            int result = 0;
            string sql = "delete from employee ";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }

        public int remove(entityemployee entity)
        {
            int result = 0;
            string sql = "delete from employee where employeeid=" + entity.employeeid + "";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }

        public DataTable getData(entityemployee entity=null )
        {
            DataTable table = new DataTable();
            string sql = "select * from employee where 1=1 ";
            if (entity != null)
            {
                if (entity.employeeid != 0)
                    sql = sql + " and employeeid =" + entity.employeeid;

                if (entity.employeename != null)
                    sql = sql + " and employeename ='" + entity.employeename + "' ";

                if (entity.salary != 0)
                    sql = sql + " and salary ='" + entity.salary + "' ";

                if (entity.deptid != 0)
                    sql = sql + " and deptid ='" + entity.deptid + "' ";

            }

            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbc.conn);
            adapter.Fill(table);
            return table;
        }
    }
}