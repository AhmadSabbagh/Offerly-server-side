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
    public partial class admin_permissions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if( !IsPostBack)
            {
                DataTable Dt = new DataTable();
                SqlDataAdapter Da = new SqlDataAdapter("select * from admin", dal.dbc.conn);
                Da.Fill(Dt);
                DropDownList1.DataSource = Dt;
                DropDownList1.DataTextField = "admin_name";
                DropDownList1.DataValueField = "admin_id";
                DropDownList1.DataBind();

                DataTable Dt1 = new DataTable();
                SqlDataAdapter Da1 = new SqlDataAdapter("select * from admin", dal.dbc.conn);
                Da1.Fill(Dt1);
                DropDownList2.DataSource = Dt1;
                DropDownList2.DataTextField = "admin_name";
                DropDownList2.DataValueField = "admin_id";
                DropDownList2.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int s1 = 0;
            int s2 = 0;
            int s3 = 0;
            int s4 = 0;
            int s5 = 0;
            int s6 = 0;
            int s7 = 0;
            int s8 = 0;
            int s9 = 0;
           
            int x = int.Parse(DropDownList1.SelectedValue);

            try
            {
                if (CheckBox1.Checked == true)
                    s1 = 1;
                else //if(CheckBox2.Checked == true)
                    s1 = 0;

                SqlCommand cmd = new SqlCommand("update admin_permissions  set state =" + s1 + " where admin_id=" + x + "and per_name='add agent' ", dal.dbc.conn);
                dal.dbc.conn.Open();
                cmd.ExecuteNonQuery();
               // dal.dbc.conn.Close();


                if (CheckBox3.Checked == true)
                    s2 = 1;
                else //if (CheckBox4.Checked == true)
                    s2 = 0;

                SqlCommand cmd2 = new SqlCommand("update admin_permissions  set state =" + s2 + " where admin_id=" + x + "and per_name='edit agent' ", dal.dbc.conn);
             //   dal.dbc.conn.Open();
                cmd2.ExecuteNonQuery();
             //   dal.dbc.conn.Close();

                if (CheckBox5.Checked == true)
                    s3 = 1;
                else //if (CheckBox6.Checked == true)
                    s3 = 0;

                SqlCommand cmd3 = new SqlCommand("update admin_permissions  set state =" + s3 + " where admin_id=" + x + "and per_name='delet agent' ", dal.dbc.conn);
              //  dal.dbc.conn.Open();
                cmd3.ExecuteNonQuery();
              //  dal.dbc.conn.Close();


                if (CheckBox7.Checked == true)
                    s4 = 1;
                else //if (CheckBox8.Checked == true)
                    s4 = 0;

                SqlCommand cmd4 = new SqlCommand("update admin_permissions  set state =" + s4 + " where admin_id=" + x + "and per_name='view statistic' ", dal.dbc.conn);
              //  dal.dbc.conn.Open();
                cmd4.ExecuteNonQuery();
              //  dal.dbc.conn.Close();

                if (CheckBox9.Checked == true)
                    s5 = 1;
                else //if (CheckBox10.Checked == true)
                    s5 = 0;

                SqlCommand cmd5 = new SqlCommand("update admin_permissions  set state =" + s5 + " where admin_id=" + x + "and per_name='add offers' ", dal.dbc.conn);
             //   dal.dbc.conn.Open();
                cmd5.ExecuteNonQuery();
            //    dal.dbc.conn.Close();




                if (CheckBox11.Checked == true)
                    s6 = 1;
                else //if (CheckBox12.Checked == true)
                    s6 = 0;

                SqlCommand cmd6 = new SqlCommand("update admin_permissions  set state =" + s6 + " where admin_id=" + x + "and per_name='add event' ", dal.dbc.conn);
             //   dal.dbc.conn.Open();
                cmd6.ExecuteNonQuery();
              //  dal.dbc.conn.Close();


                if (CheckBox13.Checked == true)
                    s7 = 1;
                else //if (CheckBox14.Checked == true)
                    s7 = 0;

                SqlCommand cmd7 = new SqlCommand("update admin_permissions  set state =" + s7 + " where admin_id=" + x + "and per_name='add news' ", dal.dbc.conn);
             //   dal.dbc.conn.Open();
                cmd7.ExecuteNonQuery();
            //    dal.dbc.conn.Close();


                if (CheckBox15.Checked == true)
                    s8 = 1;
                else //if (CheckBox16.Checked == true)
                    s8 = 0;

                SqlCommand cmd8 = new SqlCommand("update admin_permissions  set state =" + s8 + " where admin_id=" + x + "and per_name='Review comment and evaluation' ", dal.dbc.conn);
           //     dal.dbc.conn.Open();
                cmd8.ExecuteNonQuery();
            //    dal.dbc.conn.Close();


                if (CheckBox17.Checked == true)
                    s9 = 1;
                else //if (CheckBox18.Checked == true)
                    s9 = 0;

                SqlCommand cmd9 = new SqlCommand("update admin_permissions  set state =" + s9 + " where admin_id=" + x + "and per_name='add advert' ", dal.dbc.conn);
             //   dal.dbc.conn.Open();
                cmd9.ExecuteNonQuery();
                dal.dbc.conn.Close();
            }
            catch
            {
                dal.dbc.conn.Close();
                Label1.Text = "لم تتم الاضافة ";

            }
            Label1.Text = "تمت اضافة الصلاحيات بنجاح ";

            }

        protected void Button2_Click(object sender, EventArgs e)
        {
           int xx = int.Parse(DropDownList2.SelectedValue);
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select * from admin_permissions where admin_id="+xx+"", dal.dbc.conn);
            Da.Fill(Dt);
            GridView1.DataSource = Dt;
            GridView1.DataBind();
        }
    }
}