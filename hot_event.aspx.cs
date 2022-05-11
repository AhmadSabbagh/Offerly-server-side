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
    public partial class hot_event : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["t"] != null)
            {
                if (!IsPostBack)
                {
                    DropDownList2.Visible = false;
                    Button8.Visible = false;
                    // Label2.Visible = false;
                   // TextBox7.Visible = false;
                  //  TextBox8.Visible = false;
                    TextBox9.Visible = false;
                 //   TextBox10.Visible = false;
                    TextBox12.Visible = false;
                    // Image1.Visible = false;
                    Button5.Visible = false;

                }
                bool o = false;
                int h = (int)Session["t"];
                SqlCommand cmd2 = new SqlCommand("select state from admin_permissions where admin_id=" + h + "and per_name='add event' ", dal.dbc.conn);
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
                  //  Button7.Enabled = false;
                }
            }
            else
                Response.Redirect("Login.aspx");


        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                string hot_name = TextBox1.Text;
                string sql1 = "";
                int result = 0;
                string t = TextBox11.Text;


                sql1 = "insert into hot_event (descr,hot_text) values ('" + hot_name + "','" + t + "')";
                SqlCommand cmd = new SqlCommand(sql1, dal.dbc.conn);
                dal.dbc.conn.Open();
                result = cmd.ExecuteNonQuery();
                dal.dbc.conn.Close();
                
                if (result != 0)
                {
                    
                        SqlCommand cmd5 = new SqlCommand("select ISNULL (MAX(hotevent_id),1)from hot_event", dal.dbc.conn);
                        dal.dbc.conn.Open();
                        SqlDataReader ra = cmd5.ExecuteReader();
                        ra.Read();
                        string m = ra[0].ToString();
                        ra.Close();
                        dal.dbc.conn.Close();
                        Session["event"] = int.Parse(m);
                        Label1.Text = "تم اصافة البيانات بنجاح ";
                        Response.Redirect("mapevent.aspx");
                   
                   // Label1.Text = "تم اضافة الاعلان بنجاح";
                  //  Response.Redirect("picture.aspx");
                }
                else
                    Label1.Text = "اعد المحاوله";
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
           // Label2.Visible = false;
         //   TextBox7.Visible = false;
          //  TextBox8.Visible = false;
            TextBox9.Visible = false;
         //   TextBox10.Visible = false;
            TextBox12.Visible = false;
           // Image1.Visible = false;
            Button5.Visible = false;
            DataTable Dt1 = new DataTable();
            SqlDataAdapter Da1 = new SqlDataAdapter("select * from hot_event", dal.dbc.conn);
            Da1.Fill(Dt1);
            DropDownList2.DataSource = Dt1;
            DropDownList2.DataTextField = "descr";
            DropDownList2.DataValueField = "hotevent_id";
            DropDownList2.DataBind();

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                //Image1.Visible = true;
              //  TextBox7.Visible = true;
                // Label2.Visible = true;
             //   TextBox8.Visible = true;
                TextBox9.Visible = true;
               // TextBox10.Visible = true;
                TextBox12.Visible = true;
                int x = int.Parse(DropDownList2.SelectedValue);
                SqlDataReader reader;
                string sql = "select * from hot_event where hotevent_id=" + x + " ";
                SqlCommand cmd = new SqlCommand(sql, dal.dbc.conn);
                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
             //   string advert = reader.GetString(1);
                string name = reader.GetString(1);
              //  string tel = reader.GetString(4);
               // string pho = reader.GetString(5);
              //  int buy = reader.GetInt32(6);
                string text = reader.GetString(3);
                // byte[] imgdata = (byte[])reader.GetValue(4);
                dal.dbc.conn.Close();


              //  TextBox7.Text = advert;
              //  TextBox8.Text = tel;
                TextBox9.Text = name;
                TextBox12.Text = text;
              /*  if (buy == 0)
                    TextBox10.Text = "لايوجد تذاكر";
                if (buy == 1)
                    TextBox10.Text = "الشراء عن طريق الباي بال";
                if (buy == 2)
                    TextBox10.Text = "الشراء بالكردت كارد";
                if (buy == 3)
                    TextBox10.Text = "الشراء بالهاتف ";*/
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
            SqlDataAdapter Da = new SqlDataAdapter("select * from hot_event", dal.dbc.conn);
            Da.Fill(Dt);
            DropDownList2.DataSource = Dt;
            DropDownList2.DataTextField = "descr";
            DropDownList2.DataValueField = "hotevent_id";
            DropDownList2.DataBind();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                int result = 0;
                int ad_id = int.Parse(DropDownList2.SelectedValue);
                string sql = "delete from hot_event where hotevent_id =" + ad_id + " ";


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

        protected void Button7_Click(object sender, EventArgs e)
        {
           /* 
            string sql1 = "";
            int result = 0;
            int hot_id = int.Parse(DropDownList3.SelectedValue);
            if (FileUpload2.HasFile)

            {
                FileUpload1.SaveAs(Server.MapPath("image.jpg"));
                FileStream fs = new FileStream(Server.MapPath("image.jpg"), FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                FileInfo fi = new FileInfo(Server.MapPath("image.jpg"));
                byte[] imgdata = br.ReadBytes((int)fi.Length);
                fs.Close();
                br.Close();
                sql1 = "insert into picture (hoteventpc_id,picture) values ('" + hot_id + "','" + (object)imgdata + "')";
                SqlCommand cmd = new SqlCommand(sql1, dal.dbc.conn);
                dal.dbc.conn.Open();
                result = cmd.ExecuteNonQuery();
                dal.dbc.conn.Close();
                File.Delete(Server.MapPath("image.jpg"));

            }
            else
                Label1.Text = "ارفع ملف صوره صحيح";
            if (result != 0)
            {
                Label1.Text = "تم اضافة الصوره بنجاح";
            }
            else
                Label1.Text = "اعد المحاوله";
       */ }
    }
}