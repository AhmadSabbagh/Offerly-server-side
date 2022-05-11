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
    public partial class Categorieagent1 : System.Web.UI.Page
    {
        orgproject.dal.customer ct = new orgproject.dal.customer();
        protected void Page_Load(object sender, EventArgs e)
        {
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

                int cat_id = int.Parse(DropDownList2.SelectedValue);
                DropDownList3.DataSource = ct.getData_category(cat_id);
                DropDownList3.DataTextField = "catsub_name";
                DropDownList3.DataValueField = "catsub_id";
                DropDownList3.DataBind();


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            int cat_id = int.Parse(DropDownList2.SelectedValue);
            string catsub_name = TextBox2.Text;
            int n = ct.add_subcategory(cat_id, catsub_name);
            if (n > 0)
            {
                Label1.Text = "تمت الاضافة بنجاح";
                GridView1.DataSource = ct.getData_category(cat_id, catsub_name);
                GridView1.DataBind();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int cat_id = int.Parse(DropDownList2.SelectedValue);
            int catsub_id = int.Parse(DropDownList3.SelectedValue);

            DataTable y = new DataTable();
            string sql = "select agent_id,agent.name,categories.name,sub_categorie.name from agent,categories,sub_categorie where agent.cat_id" + cat_id + "";
            SqlDataAdapter x = new SqlDataAdapter(sql, dal.dbc.conn);
            x.Fill(y);
            GridView1.DataSource = y;
            GridView1.DataBind();
        }
    }
}