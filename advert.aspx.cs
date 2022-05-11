using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace orgproject
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        dal.customer ad = new dal.customer();
      static int m = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["t"] != null)
            {
                if (! Page.IsPostBack)
                {
                    dal.dbc.conn.Close();
                    SqlCommand cmd = new SqlCommand("select ISNULL (MAX(advert_id)+1,1)from advert", dal.dbc.conn);
                    dal.dbc.conn.Open();
                    SqlDataReader ra = cmd.ExecuteReader();
                    ra.Read();
                    TextBox1.Text = ra[0].ToString();
                    m = int.Parse(TextBox1.Text);
                    ra.Close();
                    dal.dbc.conn.Close();
                    DropDownList2.Visible = false;
                    Button5.Visible = false;
                    Button8.Visible = false;
                    TextBox7.Visible = false;
                    TextBox8.Visible = false;
                    TextBox9.Visible = false;
                    TextBox10.Visible = false;
                    Image2.Visible = false;

                }
                bool o = false;
                int h = (int)Session["t"];
                SqlCommand cmd2 = new SqlCommand("select state from admin_permissions where admin_id=" + h + "and per_name='add advert' ", dal.dbc.conn);
                SqlDataReader reader;
                dal.dbc.conn.Open();
                reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    o = reader.GetBoolean(0);
                }
                reader.Close();
                dal.dbc.conn.Close();

                if (o == false)
                {
                    Button4.Enabled = false;
                    Button2.Enabled = false;
                    Button8.Enabled = false;
                }
            }
            else
                Response.Redirect("Login.aspx");


            }

            protected void Button4_Click(object sender, EventArgs e)
        {
            /* string server_path = Request.PhysicalApplicationPath;

             string[] extension = { ".png", ".gif", ".jpg", ".bmp" };
             if (FileUpload1.HasFile)
             {
                string fullpath = server_path + FileUpload1.FileName;
                 string type = Path.GetExtension(fullpath);

                 if (!extension.Contains(type))
                 {
                     Label1.Text = "file not allow extension";
                     return;
                 }
                 long size = FileUpload1.FileContent.Length / 1024;
                 if (size > 1000)
                 {
                     Label1.Text = "file size large 1000kb";
                     return;
                 }
                 FileUpload1.SaveAs(fullpath);
                 Label1.Text = "file was upload succ>>>!";

             }
             else
             {
                 Label1.Text = "select file plese";
                 FileUpload1.Focus();
             }
         }

         */
            DropDownList2.Visible = false;
            Button5.Visible = false;
            Button8.Visible = false;
            TextBox7.Visible = false;
            TextBox8.Visible = false;
            TextBox9.Visible = false;
            TextBox10.Visible = false;
            Image2.Visible = false;
            // string name = TextBox2.Text;
            string advert = TextBox3.Text;
     string t = TextBox4.Text;
     string tt = TextBox5.Text;
    //string path= FileUpload1.FileName;
   // string path = Request.PhysicalApplicationPath;
            string sql1 = "";
            int result=0;
            try
            {
                sql1 = "insert into advert (advert,time,period) values ('" + advert + "','" + t + "','" + tt + "')";
                SqlCommand cmd = new SqlCommand(sql1, dal.dbc.conn);
                dal.dbc.conn.Open();
                result = cmd.ExecuteNonQuery();
                dal.dbc.conn.Close();


                if (result != 0)
                {
                    Label1.Text = "تم اضافة الاعلان بنجاح";
                    //TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";

                }

                else
                    Label1.Text = "اعد المحاوله ";
                int x = int.Parse(DropDownList1.SelectedValue);
                string sql = null;
                string ss = TextBox6.Text;
                if (x == 1)
                    sql = "insert into cus_adv (advert_id,customer_id)select advert_id,customer_id from advert,customer where advert_id=" + m + "  ";
                if (x == 2)
                    sql = "insert into cus_adv (advert_id,customer_id)select advert_id,customer_id from advert,customer where customer.gender= 'male' and advert_id =" + m + "";
                if (x == 3)
                    sql = "insert into cus_adv (advert_id,customer_id)select advert_id,customer_id from advert,customer where customer.gender='female' and advert_id =" + m + "";
                if (x == 4)
                    sql = "insert into cus_adv (advert_id,customer_id)select advert_id,customer_id from advert,customer where customer.address= '" + ss + "' and advert_id =" + m + "";
                if (x == 5)
                    sql = "insert into cus_adv (advert_id,customer_id)select advert_id,customer_id from advert,customer where customer.age= '" + ss + "'and advert_id =" + m + "";//للتعديل لاحقا 


                SqlCommand cmd2 = new SqlCommand(sql, dal.dbc.conn);
                dal.dbc.conn.Open();
                cmd2.ExecuteNonQuery();

                dal.dbc.conn.Close();
                Response.Redirect("picture.aspx");
            }

            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DropDownList2.Visible = true;
            Button5.Visible = true;
            Button8.Visible = false;
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select * from advert", dal.dbc.conn);
            Da.Fill(Dt);
            DropDownList2.DataSource = Dt;
            DropDownList2.DataTextField = "advert";
            DropDownList2.DataValueField = "advert_id";
            DropDownList2.DataBind();

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            TextBox8.Visible = true;
            TextBox9.Visible = true;
            TextBox10.Visible = true;
            Image2.Visible = true;
            SqlDataReader reader;
            try
            {
                string sql = "select * from advert where advert_id=" + int.Parse(DropDownList2.SelectedValue) + " ";
                SqlCommand cmd = new SqlCommand(sql, dal.dbc.conn);
                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                string advert = reader.GetString(1);
                string t = reader.GetString(2);
                string tt = reader.GetString(3);
                /* byte[] imgdata = (byte[])reader.GetValue(4);
                 dal.dbc.conn.Close();
                 FileStream fs = new FileStream(Server.MapPath(DropDownList2.SelectedItem.Text + ".jpg"), FileMode.OpenOrCreate, FileAccess.Write);
                 BinaryWriter bw = new BinaryWriter(fs);
                 bw.Write(imgdata);
                 fs.Close();
                 bw.Close();*/
                reader.Close();
                dal.dbc.conn.Close();
                TextBox8.Text = advert;
                TextBox9.Text = t;
                TextBox10.Text = tt;
                Image2.ImageUrl = DropDownList2.SelectedValue + ".jpg";
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DropDownList2.Visible = true;
            Button8.Visible = true;
            DataTable Dt1 = new DataTable();
            SqlDataAdapter Da1 = new SqlDataAdapter("select * from advert", dal.dbc.conn);
            Da1.Fill(Dt1);
            DropDownList2.DataSource = Dt1;
            DropDownList2.DataTextField = "advert";
            DropDownList2.DataValueField = "advert_id";
            DropDownList2.DataBind();

        

            
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                int result = 0;
                int ad_id = int.Parse(DropDownList2.SelectedValue);
                string sql = "delete from advert where advert_id =" + ad_id + " ";
                SqlCommand cmd = new SqlCommand(sql, dal.dbc.conn);
                dal.dbc.conn.Open();
                result = cmd.ExecuteNonQuery();
                dal.dbc.conn.Close();
                if (result != 0)
                    Label1.Text = "تم حذف الاعلان بنجاح ";
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);

            }
        }
    }
}