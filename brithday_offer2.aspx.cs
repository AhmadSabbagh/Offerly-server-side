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
    public partial class brithday_offer2 : System.Web.UI.Page
    {

        DataTable Dt = new DataTable();

        orgproject.dal.customer br = new orgproject.dal.customer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Visible = false;
                DropDownList2.Visible = false;
                Label1.Visible = false;
                Label2.Visible = false;
                TextBox3.Visible = false;
                FileUpload1.Visible = false;
                Button7.Visible = false;
                Button8.Visible = false;
                //  GridView1.Width
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime frist = DateTime.Parse(TextBox1.Text);
            DateTime second = DateTime.Parse(TextBox2.Text);
            SqlDataAdapter Da = new SqlDataAdapter("select email,brith_day from customer where brith_day between " + frist + " and " + second + " ", dal.dbc.conn);
            Da.Fill(Dt);

            GridView1.DataSource = Dt;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DateTime frist = DateTime.Parse(TextBox1.Text);
            DateTime second = DateTime.Parse(TextBox2.Text);
            SqlDataAdapter Da = new SqlDataAdapter("select email,marriage_date from customer where marriage_date between " + frist + " and " + second + " ", dal.dbc.conn);
            Da.Fill(Dt);

            GridView1.DataSource = Dt;
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            DateTime frist = DateTime.Parse(TextBox1.Text);
            DateTime second = DateTime.Parse(TextBox2.Text);
            SqlDataAdapter Da = new SqlDataAdapter("select email,name_baby,children_brith.brith_day from customer,children_brith where customer_id=customerch_id and children_brith.brith_day between " + frist + " and " + second + " ", dal.dbc.conn);
            Da.Fill(Dt);

            GridView1.DataSource = Dt;
            GridView1.DataBind();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            DropDownList1.Visible = true;
            DropDownList2.Visible = true;
            Label1.Visible = true;
            Label2.Visible = true;
            TextBox3.Visible = true;
            FileUpload1.Visible = true;
            Button7.Visible = true;
            SqlDataAdapter Da = new SqlDataAdapter("select * from categories", dal.dbc.conn);
            Da.Fill(Dt);
            DropDownList1.DataSource = Dt;
            DropDownList1.DataTextField = "cat_name";
            DropDownList1.DataValueField = "cat_id";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("اختر التصنيف  ", "0"));
            DropDownList1.SelectedIndex = 0;
            DropDownList2.Items.Insert(0, "لم يتم اختيار التصنيف");

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            DropDownList1.Visible = true;
            DropDownList2.Visible = true;
            Label1.Visible = true;
            Label2.Visible = true;
            TextBox3.Visible = true;
            FileUpload1.Visible = true;
            Button8.Visible = true;
            SqlDataAdapter Da = new SqlDataAdapter("select * from categories", dal.dbc.conn);
            Da.Fill(Dt);
            DropDownList1.DataSource = Dt;
            DropDownList1.DataTextField = "cat_name";
            DropDownList1.DataValueField = "cat_id";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("اختر التصنيف  ", "0"));
            DropDownList1.SelectedIndex = 0;
            DropDownList2.Items.Insert(0, "لم يتم اختيار التصنيف");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            string path = Request.PhysicalApplicationPath;

            string[] extension = { ".png", ".gif", ".jpg", ".bmp" };
            int agent_id = int.Parse(DropDownList2.SelectedValue);
            string offer = TextBox3.Text;
            DateTime first = DateTime.Parse(TextBox1.Text);
            DateTime last = DateTime.Parse(TextBox2.Text);
            int result = 0;
            int result2 = 0;
            string sql1 = null;

            if (FileUpload1.HasFile)

            {
                FileUpload1.SaveAs(Server.MapPath("image.jpg"));
                FileStream fs = new FileStream(Server.MapPath("image.jpg"), FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                FileInfo fi = new FileInfo(Server.MapPath("image.jpg"));
                byte[] imgdata = br.ReadBytes((int)fi.Length);
                fs.Close();
                br.Close();
                sql1 = "insert into brith_offer (agent_id,offer,picture,first_time,last_time) values (" + agent_id + ",'" + offer + "','" + (object)imgdata + "','" + first + "','" + last + "')";
                string sql2 = "insrt into cus_brithoffer (customerb_id,brithoffer_id)select customer_id,id from customer,brith_offer where brith_day between first_time and last_time ";

                SqlCommand cmd2 = new SqlCommand(sql2, dal.dbc.conn);
                SqlCommand cmd = new SqlCommand(sql1, dal.dbc.conn);
                dal.dbc.conn.Open();
                result = cmd.ExecuteNonQuery();
                result2 = cmd.ExecuteNonQuery();
                dal.dbc.conn.Close();
                File.Delete(Server.MapPath("image.jpg"));


            }
            else
                Label3.Text = "ارفع ملف صوره صحيح";

            if (result > 0 && result2 > 0)
            {
                Label3.Text = "تم اضافة عرض الميلاد بنجاح";
                TextBox3.Text = "";
            }
            DropDownList1.Visible = false;
            DropDownList2.Visible = false;
            Label1.Visible = false;
            Label2.Visible = false;
            TextBox3.Visible = false;
            FileUpload1.Visible = false;
            Button8.Visible = false;
            Button7.Visible = false;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            string path = Request.PhysicalApplicationPath;

            string[] extension = { ".png", ".gif", ".jpg", ".bmp" };

            int agent_id = int.Parse(DropDownList2.SelectedValue);
            string offer = TextBox3.Text;
            DateTime first = DateTime.Parse(TextBox1.Text);
            DateTime last = DateTime.Parse(TextBox2.Text);
            int result = 0;
            int result2 = 0;


            if (FileUpload1.HasFile)

            {
                FileUpload1.SaveAs(Server.MapPath("image.jpg"));
                FileStream fs = new FileStream(Server.MapPath("image.jpg"), FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                FileInfo fi = new FileInfo(Server.MapPath("image.jpg"));
                byte[] imgdata = br.ReadBytes((int)fi.Length);
                fs.Close();
                br.Close();
                string sql1 = "insert into marriage_offer (agent_id,offer,picture,first_time,last_time) values (" + agent_id + ",'" + offer + "','" + (object)imgdata + "','" + first + "','" + last + "')";
                string sql2 = "insrt into cus_marriagoffer (customerb_id,marriageoffer_id)select customer_id,id from customer,brith_offer where brith_day between first_time and last_time ";

                SqlCommand cmd2 = new SqlCommand(sql2, dal.dbc.conn);
                SqlCommand cmd = new SqlCommand(sql1, dal.dbc.conn);
                dal.dbc.conn.Open();
                result = cmd.ExecuteNonQuery();
                result2 = cmd2.ExecuteNonQuery();
                dal.dbc.conn.Close();
                File.Delete(Server.MapPath("image.jpg"));


            }
            else
                Label3.Text = "ارفع ملف صوره صحيح";




            if (result > 0 && result2 > 0)
            {
                Label3.Text = "تم اضافة عرض الميلاد بنجاح";
                TextBox3.Text = "";


            }
            DropDownList1.Visible = false;
            DropDownList2.Visible = false;
            Label1.Visible = false;
            Label2.Visible = false;
            TextBox3.Visible = false;
            FileUpload1.Visible = false;
            Button8.Visible = false;
            Button7.Visible = false;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dt.Clear();
            // DataTable Dt1 = new DataTable;
            int id;
            string name;
            id = int.Parse(DropDownList1.SelectedValue);
            name = DropDownList1.SelectedItem.Text;
            if (id != 0)
            {
                SqlDataAdapter Da = new SqlDataAdapter("select * from agent where cat_id= " + id + "", dal.dbc.conn);
                Da.Fill(Dt);
                DropDownList2.DataSource = Dt;
                DropDownList2.DataTextField = "name";
                DropDownList2.DataValueField = "agent_id";
                DropDownList2.DataBind();
                DropDownList2.Items.Insert(0, new ListItem("اختر العميل  ", "0"));
                DropDownList2.SelectedIndex = 0;

            }
            else
            {
                DropDownList2.Items.Insert(0, "لايوجد عميل في التصنيف");
                DropDownList2.DataBind();
            }
        }
    }
}