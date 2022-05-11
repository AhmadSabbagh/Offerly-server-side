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
    public partial class point_customer : System.Web.UI.Page
    {
    DataTable Dt = new DataTable();

        orgproject.dal.customer po = new orgproject.dal.customer();

        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                /*   SqlDataAdapter Da = new SqlDataAdapter("select email,count(type)  group by email ", dal.dbc.conn);
                   Da.Fill(Dt);
                   GridView1.DataSource = Dt;
                   GridView1.DataBind();
                   SqlDataAdapter Da1 = new SqlDataAdapter("select email,count(type)  group by email ", dal.dbc.conn);*/
                Label1.Visible = false;
                Label2.Visible = false;
                Label3.Visible = false;
                Label4.Visible = false;
                TextBox1.Visible = false;
                TextBox2.Visible = false;
                TextBox3.Visible = false;
                Button4.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable Dt2 = new DataTable();
            SqlDataAdapter Da2 = new SqlDataAdapter("select email,count(cust_id) from customer,point_customer where cust_id=customer_id group by email ", dal.dbc.conn);//مبدئيا العد لعدد الزبائن والا نضيف حقل للعد ي كل حالة اضافة 
            Da2.Fill(Dt2);         
            GridView1.DataSource = Dt;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            DataTable Dt2 = new DataTable();
            SqlDataAdapter Da2 = new SqlDataAdapter("select email,count(face) as facbok,count(email) as email,count(whats) as whasapp,count(sms)as sms from customer,point_customer where cust_id=customer_id and face=1 and emailp=1 and whats=1 and sms=1 group by email ", dal.dbc.conn);//مبدئيا العد لعدد الزبائن والا نضيف حقل للعد ي كل حالة اضافة 
            Da2.Fill(Dt2);
            GridView1.DataSource = Dt;
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;
            TextBox1.Visible = true;
            TextBox2.Visible = true;
            TextBox3.Visible = true;
            Button4.Visible = true;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                string sql1 = "";
                int result = 0;
                string offer = TextBox1.Text;
                decimal discount = decimal.Parse(TextBox2.Text);
                int count = int.Parse(TextBox3.Text);
               
                    sql1 = "insert into point_offer (offer,discount,n_of_shar) values ('" + offer + "'," + discount + "," + count + " )";
                    SqlCommand cmd = new SqlCommand(sql1, dal.dbc.conn);
                    dal.dbc.conn.Open();
                    result = cmd.ExecuteNonQuery();
                    dal.dbc.conn.Close();
                  //  File.Delete(Server.MapPath("image.jpg"));

                
                   // Label1.Text = "ارفع ملف صوره صحيح";






                if (result != 0)
                {
                    Label4.Text = "تم اضافة الاعلان بنجاح";
                    //TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                }
                else
                    Label4.Text = "لم يتم اضافة العرض";



                string sql = "insert into cus_point (point_id,customer_id)select pointoffer_id,customer_id from point_offer,point_customer,customer where count(emailp) >=" + count + " and cust_id=customer_id  group by cust_id";
                SqlCommand cmd2 = new SqlCommand(sql, dal.dbc.conn);
                dal.dbc.conn.Open();
                cmd2.ExecuteNonQuery();
                dal.dbc.conn.Close();
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}