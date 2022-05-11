using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace orgproject
{
    public partial class register2 : System.Web.UI.Page
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
            if (!Page.IsPostBack)
            {
                DropDownList1.DataSource = cr.getData_category();
                DropDownList1.DataTextField = "cat_name";
                DropDownList1.DataValueField = "cat_id";
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                string username = TextBox2.Text;
                string password = SHA512(TextBox3.Text);
                string passwordc = SHA512(TextBox4.Text);
                string phone = TextBox5.Text;
                string address = TextBox7.Text;
                string city = TextBox8.Text;
                int cat_id = int.Parse(DropDownList1.SelectedValue);
                DateTime br = DateTime.Parse(TextBox6.Text);
                int sub_cat = int.Parse(DropDownList2.SelectedValue);
                string des = TextBox9.Text;

                if (password != passwordc)
                {
                    Label1.Text = "Wrong confirming password";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox3.Focus();
                }
                else
                {
                    int n = cr.add_agent(username, password, phone,address, city, cat_id,sub_cat,des);
                    if (n > 0)
                    {
                        Label1.Text = "add succ";
                        TextBox2.Text = "";
                        TextBox3.Text = "";
                        TextBox4.Text = "";
                        TextBox5.Text = "";
                        TextBox6.Text = "";
                        TextBox7.Text = "";
                        TextBox8.Text = "";
                        GridView1.DataSource = cr.getData_agent();
                        GridView1.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(TextBox1.Text);
                string username = TextBox2.Text;
                string phone = TextBox5.Text;
                string address = TextBox7.Text;
                string city = TextBox8.Text;
                int cat_id = int.Parse(DropDownList1.SelectedValue);
                string br = TextBox6.Text;

                GridView1.DataSource = cr.getData_agent(0, username, cat_id);
                GridView1.DataBind();

            }

            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int id = 0;
            string name = null;
            id = int.Parse(TextBox1.Text);
            name = TextBox2.Text;
            if (id == 0 && name != null)
            {
                DataTable y = new DataTable();
                string sql = "select agent_id from agent where name='" + name + "'";
                SqlDataAdapter x = new SqlDataAdapter(sql, dal.dbc.conn);
                x.Fill(y);

                string yy = (y.Rows[0]["agent_id"].ToString());
                int xx = int.Parse(yy);
                id = xx;
            }
            cr.remove_agent(id);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            int y = int.Parse(DropDownList1.SelectedValue);
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select * from sub_cat where catsub_id=" + y + "", dal.dbc.conn);
            Da.Fill(Dt);
            DropDownList2.DataSource = Dt;
            DropDownList2.DataTextField = "catsub_name";
            DropDownList2.DataValueField = "sub_id";
            DropDownList2.DataBind();
        }
    }
}