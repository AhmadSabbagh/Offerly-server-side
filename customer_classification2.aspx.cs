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
    public partial class customer_classification2 : System.Web.UI.Page
    {

        dal.customer ss = new dal.customer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //  DropDownList1.Items.Add("اختر الجنس");
                DropDownList1.Items.Add("Male");
                DropDownList1.Items.Add("Femal");
                DropDownList2.Items.Add("Gender");
                DropDownList2.Items.Add("Age");
                DropDownList2.Items.Add("Address ");
                DropDownList2.Items.Add("Brithday");

            }
           // GridView1.DataSource = ss.getData_customer();
          //  GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string x = DropDownList2.SelectedValue;

            DataTable y = new DataTable();
            string sql = "select * from customer group by'" + x + "'";
            SqlDataAdapter xx = new SqlDataAdapter(sql, dal.dbc.conn);
            xx.Fill(y);

            GridView1.DataSource = y;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string x = DropDownList1.SelectedValue;
            int age = int.Parse(TextBox1.Text);
            string y = TextBox2.Text;
            string m = TextBox3.Text;

         //   GridView1.DataSource = ss.getData_customer(0, null, null, null, m, y, null, x, age, null, null);
           // GridView1.DataBind();
        }
    }
}