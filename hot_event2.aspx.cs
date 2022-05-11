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
    public partial class hot_event2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable Dt2 = new DataTable();
                SqlDataAdapter Da2 = new SqlDataAdapter("select * from hot_event", dal.dbc.conn);
                Da2.Fill(Dt2);
                DropDownList3.DataSource = Dt2;
                DropDownList3.DataTextField = "descr";
                DropDownList3.DataValueField = "hotevent_id";
                DropDownList3.DataBind();
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            DropDownList2.Visible = true;
            Button8.Visible = true;
            // Label2.Visible = false;
            TextBox7.Visible = false;
            TextBox8.Visible = false;
            TextBox9.Visible = false;
            TextBox10.Visible = false;
            Image1.Visible = false;
            Button5.Visible = false;
            DataTable Dt1 = new DataTable();
            SqlDataAdapter Da1 = new SqlDataAdapter("select * from hot_event", dal.dbc.conn);
            Da1.Fill(Dt1);
            DropDownList2.DataSource = Dt1;
            DropDownList2.DataTextField = "descr";
            DropDownList2.DataValueField = "hotevent_id";
            DropDownList2.DataBind();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string hot_name = TextBox1.Text;
            string address = TextBox4.Text;
            string phone = TextBox6.Text;
            string telphone = TextBox5.Text;
            int buy = 0;
            if (RadioButton4.Checked == true)
                buy = 0;
            else if (RadioButton3.Checked == true)
                buy = 3;
            else if (RadioButton2.Checked == true)
                buy = 2;
            else if (RadioButton1.Checked == true)
                buy = 1;
            string sql1 = "";
            int result = 0;

            if (FileUpload1.HasFile)

            {
                FileUpload1.SaveAs(Server.MapPath("image.jpg"));
                FileStream fs = new FileStream(Server.MapPath("image.jpg"), FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                FileInfo fi = new FileInfo(Server.MapPath("image.jpg"));
                byte[] imgdata = br.ReadBytes((int)fi.Length);
                fs.Close();
                br.Close();
                sql1 = "insert into hot_event (descr,picture,telephone,phone,buy) values ('" + hot_name + "','" + (object)imgdata + "','" + telphone + "','" + phone + "'," + buy + ")";
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
                Label1.Text = "تم اضافة الاعلان بنجاح";
            }
            else
                Label1.Text = "اعد المحاوله";

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Image1.Visible = true;
            TextBox7.Visible = true;
            // Label2.Visible = true;
            TextBox8.Visible = true;
            TextBox9.Visible = true;
            TextBox10.Visible = true;
            SqlDataReader reader;
            string sql = "select * from hot_event where hotevent_id=" + int.Parse(DropDownList2.SelectedValue) + " ";
            SqlCommand cmd = new SqlCommand(sql, dal.dbc.conn);
            dal.dbc.conn.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            string advert = reader.GetString(1);
            string tel = reader.GetString(3);
            string pho = reader.GetString(4);
            int buy = reader.GetInt32(5);
            byte[] imgdata = (byte[])reader.GetValue(4);
            dal.dbc.conn.Close();
            FileStream fs = new FileStream(Server.MapPath(DropDownList2.SelectedItem.Text + ".jpg"), FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(imgdata);
            fs.Close();
            bw.Close();

            TextBox7.Text = advert;
            TextBox8.Text = tel;
            TextBox9.Text = pho;
            if (buy == 0)
                TextBox10.Text = "لايوجد تذاكر";
            if (buy == 1)
                TextBox10.Text = "الشراء عن طريق الباي بال";
            if (buy == 2)
                TextBox10.Text = "الشراء بالكردت كارد";
            if (buy == 3)
                TextBox10.Text = "الشراء بالهاتف ";

            Image1.ImageUrl = DropDownList2.SelectedItem.Text + ".jpg";


        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            int result = 0;
            int ad_id = int.Parse(DropDownList2.SelectedValue);
            string sql = "delete from hot_event,picture where hotevent_id =" + ad_id + " ";


            SqlCommand cmd = new SqlCommand(sql, dal.dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();
            if (result != 0)
                Label1.Text = "تم حذف الاعلان بنجاح ";
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
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
        }
    }
}