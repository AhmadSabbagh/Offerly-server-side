using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace orgproject.dal
{
    public class dallocation
    {

        public int add(entitylocation entity)
        {
            int result = 0;
            string sql = "insert into location (locid,locname) values (" + entity.locid + ",'" + entity.locname + "')";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }

        internal object getData()
        {
            throw new NotImplementedException();
        }

        public int edit(entitylocation entity)
        {
            int result = 0;
            string sql = "update location  set  locname= '" + entity.locname +  "'where locid=" + entity.locid + ")";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }

        public int removeall()
        {
            int result = 0;
            string sql = "delet from location ";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }

        public int remove(entitylocation entity)
        {
            int result = 0;
            string sql = "delet from location where locid=" + entity.locid + ")";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }

        public DataTable getData(entitylocation entity)
        {
            DataTable table = new DataTable();
            string sql = "select * from location where 1=1 ";
            if (entity != null)
            {
                if (entity.locid != 0)
                    sql = sql + " and locid =" + entity.locid;

                if (entity.locname != null)
                    sql = sql + " and locname ='" + entity.locname + "' ";

            

            }

            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbc.conn);
            adapter.Fill(table);
            return table;
        }
    }
}