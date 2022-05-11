using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace orgproject
{
    public partial class register : System.Web.UI.Page
    {
        orgproject.dal.customer cr = new orgproject.dal.customer();
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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["t"] != null)
            {

                if (!Page.IsPostBack)
                {
                    DropDownList1.DataSource = cr.getData_category();
                    DropDownList1.DataTextField = "cat_name";
                    DropDownList1.DataValueField = "cat_id";
                    DropDownList1.DataBind();
                    Button3.Visible = false;
                    Button7.Enabled = false;
                    Button8.Enabled = false;
                    DropDownList3.DataSource = cr.getData_agent();
                    DropDownList3.DataTextField = "name";
                    DropDownList3.DataValueField = "agent_id";
                    DropDownList3.DataBind();
                    DropDownList5.DataSource = cr.getData_agent();
                    DropDownList5.DataTextField = "name";
                    DropDownList5.DataValueField = "agent_id";
                    DropDownList5.DataBind();
                }

                bool o=false;
            int h = (int)Session["t"];
            SqlCommand cmd = new SqlCommand("select state from admin_permissions where admin_id="+ h +"and per_name='add agent' ", dal.dbc.conn);
            SqlDataReader reader;
            dal.dbc.conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                o = reader.GetBoolean(0);
            }
            reader.Close();
            dal.dbc.conn.Close();

            if(o==false)
            {
                Button3.Enabled = false;
                Button5.Enabled = false;
            }

            bool f=false;
          //  int x = (int)Session["t"];
            SqlCommand cmd2 = new SqlCommand("select state from admin_permissions where admin_id=" + h + "and per_name='edit agent' ", dal.dbc.conn);
            SqlDataReader reader2;
            dal.dbc.conn.Open();
            reader2 = cmd.ExecuteReader();
            while (reader2.Read())
            {
                f = reader2.GetBoolean(0);
            }
            reader.Close();
            dal.dbc.conn.Close();

            if (f == false)
            {
                Button2.Enabled = false;
               
            }

            bool ff=false;
            //  int x = (int)Session["t"];
            SqlCommand cmd3 = new SqlCommand("select state from admin_permissions where admin_id=" + h + "and per_name='delet agent' ", dal.dbc.conn);
            SqlDataReader reader3;
            dal.dbc.conn.Open();
            reader3 = cmd.ExecuteReader();
            while (reader3.Read())
            {
                ff = reader3.GetBoolean(0);
            }
            reader.Close();
            dal.dbc.conn.Close();

            if (ff == false)
            {
                Button1.Enabled = false;

            }

            }
            else
                Response.Redirect("Login.aspx");


            // ListBox1.DataSource = cr.getData_agent();
            // ListBox1.DisplayMember = "agent_id";
            //  ListBox1.valueMember = "agent_name";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label1.Text = "";

            if (TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "" || TextBox6.Text == "" || TextBox7.Text == "")
                Label1.Text = "الرجاء ادخال الحقول المهمه ";
            else
            {

                try
                {
                    int sub_cat = 0;
                    string username = TextBox2.Text;
                    string pass = TextBox3.Text;
                    string password = SHA512(TextBox3.Text);
                    string passwordc = SHA512(TextBox4.Text);
                    string phone = TextBox5.Text;
                    string address = TextBox6.Text;
                    string city = TextBox7.Text;
                    int cat_id = int.Parse(DropDownList1.SelectedValue);
                    int xx = int.Parse(TextBox1.Text);
                    string hhh = DropDownList2.SelectedValue;
                    if (DropDownList2.SelectedValue!="")
                    sub_cat = int.Parse(DropDownList2.SelectedValue);
                    string des = TextBox9.Text;


                    if (password != passwordc)
                    {
                        Label1.Text = "خطأ في تأكيد كلمة المرور";
                        TextBox3.Text = "";
                        TextBox4.Text = "";
                        TextBox3.Focus();
                    }
                    else
                    {
                        int n = cr.add_agent(username, password, phone, address, city, cat_id,sub_cat,des);
                        if (n > 0)
                        {
                            Label1.Text = " '"+ pass +"' تمت الاضافة بنجاح رقم السر للعميل المضاف ";
                            TextBox2.Text = "";
                            TextBox3.Text = "";
                            TextBox4.Text = "";
                            TextBox5.Text = "";
                            TextBox6.Text = "";
                            TextBox7.Text = "";
                           
                            Button5.Visible = true;
                            GridView1.DataSource = cr.getData_agent();
                            GridView1.DataBind();
                            Session["agent"] =int.Parse (TextBox1.Text);
                            Response.Redirect("map.aspx");
                        }
                    }
                }
                catch (Exception ex)
                {
                    dal.dbc.conn.Close();
                    Response.Write(ex.Message);
                }
                // "insert into priv(priv_scren_id,priv_agent_id) select scren_id,"+agen
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            DropDownList4.DataSource = cr.getData_agent();
            DropDownList4.DataTextField = "name";
            DropDownList4.DataValueField = "agent_id";
            DropDownList4.DataBind();
            Button7.Enabled = true;
            Button8.Enabled = true;
        }

       

        protected void Button4_Click(object sender, EventArgs e)
        {

            Label1.Text = "";
            try
            {
               // int id = int.Parse(TextBox1.Text);
                string username = TextBox2.Text;              
                string phone = TextBox5.Text;
                string address = TextBox6.Text;
                string city = TextBox7.Text;
                int cat_id = int.Parse(DropDownList1.SelectedValue);
                GridView1.DataSource = cr.getData_agent(0, username, cat_id);
                GridView1.DataBind(); 

            }

            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(DropDownList3.SelectedValue);

                SqlCommand cmd = new SqlCommand("delete from agent where agent_id=" + x + "", dal.dbc.conn);
                dal.dbc.conn.Open();
                int result = cmd.ExecuteNonQuery();
                dal.dbc.conn.Close();
                if (result != 0)
                    Label1.Text = "remove agent has number " + x + " ";
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

        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                Button3.Visible = true;
                Button5.Visible = false;
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
               
                Label1.Text = "";
                SqlCommand cmd = new SqlCommand("select ISNULL (MAX(agent_id)+1,1)from agent", dal.dbc.conn);
                dal.dbc.conn.Open();
                SqlDataReader ra = cmd.ExecuteReader();
                ra.Read();
                TextBox1.Text = ra[0].ToString();
                ra.Close();
                dal.dbc.conn.Close();
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);
            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            int y = int.Parse(DropDownList1.SelectedValue);
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select * from sub_categorie where catsub_id=" + y +"", dal.dbc.conn);
            Da.Fill(Dt);
            DropDownList2.DataSource = Dt;
            DropDownList2.DataTextField = "catsub_name";
            DropDownList2.DataValueField = "sub_id";
            DropDownList2.DataBind();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                string o = null;
                string o1 = null;
                string o2 = null;
                string o3 = null;
                string o4 = null;
                string o5 = null;
                int y = int.Parse(DropDownList4.SelectedValue);
                SqlCommand cmd2 = new SqlCommand("select name,phone,address,city,descr from agent where agent_id=" + y + " ", dal.dbc.conn);
                SqlDataReader reader;
                dal.dbc.conn.Open();
                reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    o = reader.GetString(0);
                    o1 = reader.GetString(1);
                  
                    o3 = reader.GetString(3);
                    o4 = reader.GetString(4);
                    o5 = reader.GetString(5);
                }
                reader.Close();
                dal.dbc.conn.Close();

                TextBox2.Text = o;

                TextBox5.Text = o1;
              
                TextBox6.Text = o3;
                TextBox7.Text = o4;
                TextBox9.Text = o5;
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(DropDownList4.SelectedValue);
                string o = TextBox2.Text;
                string o1 = TextBox5.Text;
              
                string o3 = TextBox6.Text;
                string o4 = TextBox7.Text;
                string o5 = TextBox9.Text;
                string p = SHA512(TextBox3.Text);
                SqlCommand cmd5 = new SqlCommand("update agent  set name ='" + o + "',password='" + p + "',phone='" + o1 + "',address='" + o3 + "',city='" + o4 + "',descr='" + o5 + "' where agent_id=" + x + "", dal.dbc.conn);
                dal.dbc.conn.Open();
                int result = cmd5.ExecuteNonQuery();
                dal.dbc.conn.Close();
                if (result != 0)
                    Label1.Text = "تم تحديث البيانات بنجاح ";
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(DropDownList5.SelectedValue);
                string name = TextBox10.Text;
                string phone = TextBox11.Text;
                int r = cr.add_branchagent(x, name, phone);//تعديل الموقع 
                if (r != 0)
                {
                    SqlCommand cmd = new SqlCommand("select ISNULL (MAX(id),1)from branches_agent", dal.dbc.conn);
                    dal.dbc.conn.Open();
                    SqlDataReader ra = cmd.ExecuteReader();
                    ra.Read();
                    string m = ra[0].ToString();
                    ra.Close();
                    dal.dbc.conn.Close();
                    Session["agenth"] = int.Parse(m);
                    Label1.Text = "تم اصافة البيانات بنجاح ";
                    Response.Redirect("mapbranch.aspx");
                }
                else
                    Label1.Text = "لم تتم اضافة البيانات بنجاح ";
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);
            }
        }
    }
}