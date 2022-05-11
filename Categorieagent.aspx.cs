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
    public partial class Categorieagent : System.Web.UI.Page
    {

        orgproject.dal.customer ct = new orgproject.dal.customer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["t"]==null)
            { Response.Redirect("Login.aspx"); }
            if (!Page.IsPostBack)
            {
                DropDownList1.DataSource = ct.getData_category();
                DropDownList1.DataTextField = "cat_name";
                DropDownList1.DataValueField = "cat_id";
                DropDownList1.DataBind();
                DropDownList2.DataSource = ct.getData_category();
                DropDownList2.DataTextField = "cat_name";
                DropDownList2.DataValueField = "cat_id";
                DropDownList2.DataBind();

                /*   int cat_id = int.Parse(DropDownList2.SelectedValue);
                   DropDownList3.DataSource = ct.getData_subcategory(cat_id);
                   DropDownList3.Items.Add(" ");
                   DropDownList3.DataTextField = "catsub_name";
                   DropDownList3.DataValueField = "catsub_id";
                   DropDownList3.DataBind();*/
                DropDownList5.DataSource = ct.getData_category();
                DropDownList5.DataTextField = "cat_name";
                DropDownList5.DataValueField = "cat_id";
                DropDownList5.DataBind();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cat_name = TextBox1.Text;
                int n = ct.add_category(cat_name);
                if (n > 0)
                {
                    Label2.Text = "تمت الاضافة بنجاح";
                    GridView1.DataSource = ct.getData_category(0, cat_name);
                    GridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int cat_id = int.Parse(DropDownList1.SelectedValue);
                string catsub_name = TextBox2.Text;
                int n = ct.add_subcategory(cat_id, catsub_name);
                if (n > 0)
                {
                    Label1.Text = "تمت الاضافة بنجاح";
                    GridView1.DataSource = ct.getData_category(cat_id, catsub_name);
                    GridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);

            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
          //  int catsub_id;
            int cat_id = int.Parse(DropDownList2.SelectedValue);
          //  if(DropDownList3.SelectedValue!="")
          //   catsub_id = int.Parse(DropDownList3.SelectedValue);

            DataTable y = new DataTable();
            string sql = "select agent.name,categories.cat_name from agent,categories where agent.cat_id =" + cat_id + "and agent.cat_id=categories.cat_id";
            SqlDataAdapter x = new SqlDataAdapter(sql, dal.dbc.conn);
            x.Fill(y);
            GridView1.DataSource = y;
            GridView1.DataBind();
            DropDownList4.DataSource = ct.getData_subcategory(cat_id);
            DropDownList4.Items.Add(" ");
            DropDownList4.DataTextField = "catsub_name";
            DropDownList4.DataValueField = "sub_id";
            DropDownList4.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            int catsub_id = int.Parse(DropDownList4.SelectedValue);
            int result = 0;
            string sql = "delete from sub_categorie where sub_id =" + catsub_id + " ";

            SqlCommand cmd = new SqlCommand(sql, dal.dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();
            if (result != 0)
                Label4.Text = "تم مسح التصنيف الفرعي ";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            int cat_id = int.Parse(DropDownList5.SelectedValue);
            int result = 0;
            string sql = "delete from categories where cat_id =" + cat_id + " ";

            SqlCommand cmd = new SqlCommand(sql, dal.dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();
            if (result != 0)
                Label3.Text = "تم مسح التصنيف  ";
        }
    }
}