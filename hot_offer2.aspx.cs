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
    public partial class hot_offer2 : System.Web.UI.Page
    {
        static string x;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["t"] != null)
            {
                //   DataTable table = (DataTable)Session["t"];
                //   x =  table.Rows[0][""];
                x = Session["t"].ToString();
            }
            else
                Response.Redirect("Login.aspx");
            DropDownList1.Visible = false;
            Button6.Visible = false;
            Label2.Visible = false;
            TextBox3.Visible = false;
            Image1.Visible = false;
            Button5.Visible = false;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string hot_name = TextBox2.Text;
            string sql1 = "";
            int result = 0;
            int id = int.Parse(x);
            if (FileUpload1.HasFile)

            {
                FileUpload1.SaveAs(Server.MapPath("image.jpg"));
                FileStream fs = new FileStream(Server.MapPath("image.jpg"), FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                FileInfo fi = new FileInfo(Server.MapPath("image.jpg"));
                byte[] imgdata = br.ReadBytes((int)fi.Length);
                fs.Close();
                br.Close();
                sql1 = "insert into hot_offer (hot_name,picture,adminhot_id) values ('" + hot_name + "','" + (object)imgdata + "'," + id + ")";
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            DropDownList1.Visible = true;
            Button6.Visible = true;
            Label2.Visible = false;
            TextBox3.Visible = false;
            Image1.Visible = false;
            Button5.Visible = false;
            DataTable Dt1 = new DataTable();
            SqlDataAdapter Da1 = new SqlDataAdapter("select * from hot_offer", dal.dbc.conn);
            Da1.Fill(Dt1);
            DropDownList1.DataSource = Dt1;
            DropDownList1.DataTextField = "hot_name";
            DropDownList1.DataValueField = "hot_id";
            DropDownList1.DataBind();


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DropDownList1.Visible = true;
            Button5.Visible = true;
            Button6.Visible = false;
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select * from hot_offer", dal.dbc.conn);
            Da.Fill(Dt);
            DropDownList1.DataSource = Dt;
            DropDownList1.DataTextField = "hot_name";
            DropDownList1.DataValueField = "hot_id";
            DropDownList1.DataBind();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            int result = 0;
            int ad_id = int.Parse(DropDownList1.SelectedValue);
            string sql = "delete from hot_offer where hot_id =" + ad_id + " ";


            SqlCommand cmd = new SqlCommand(sql, dal.dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();
            if (result != 0)
                Label1.Text = "تم حذف الاعلان بنجاح ";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Image1.Visible = true;
            TextBox3.Visible = true;
            Label2.Visible = true;
            SqlDataReader reader;
            string sql = "select * from hot_offer where hot_id=" + int.Parse(DropDownList1.SelectedValue) + " ";
            SqlCommand cmd = new SqlCommand(sql, dal.dbc.conn);
            dal.dbc.conn.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            string advert = reader.GetString(1);
            byte[] imgdata = (byte[])reader.GetValue(4);
            dal.dbc.conn.Close();
            FileStream fs = new FileStream(Server.MapPath(DropDownList1.SelectedItem.Text + ".jpg"), FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(imgdata);
            fs.Close();
            bw.Close();

            TextBox3.Text = advert;
            Image1.ImageUrl = DropDownList1.SelectedItem.Text + ".jpg";

        }
    }
}