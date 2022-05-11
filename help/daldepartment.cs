using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace orgproject.dal
{
    public class daldepartment
    {

        public int add(entitydepartment entity)
        {
            int result = 0;
            string sql = "insert into department (deptid,deptname,locid) values (" + entity.deptid + ",'" + entity.deptname + "','" + entity.locid + "')";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }

        public int edit(entitydepartment entity)
        {
            int result = 0;
            string sql = "update department  set  locid= '" + entity.locid + "',deptname='" + entity.deptname + "'where deptid=" + entity.deptid + ")";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }

        public int removeall()
        {
            int result = 0;
            string sql = "delet from department ";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }

        public int remove(entitydepartment entity)
        {
            int result = 0;
            string sql = "delet from department where deptid=" + entity.deptid + ")";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }

        public DataTable getData(entitydepartment entity =null)
        {
            DataTable table = new DataTable();
            string sql = "select * from department where 1=1 ";
            if (entity != null)
            {
                if (entity.deptid != 0)
                    sql = sql + " and deptid =" + entity.deptid;

                if (entity.deptname != null)
                    sql = sql + " and deptname ='" + entity.deptname + "' ";

                if (entity.locid != 0)
                    sql = sql + " and locid ='" + entity.locid + "' ";

            }

            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbc.conn);
            adapter.Fill(table);
            return table;
        }
    }
}