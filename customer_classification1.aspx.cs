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
    public partial class customer_classification1 : System.Web.UI.Page
    {
        dal.customer s = new dal.customer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["t"]==null)
            { Response.Redirect("Login.aspx"); }
            if (!IsPostBack)
            {

                DataTable Dt2 = new DataTable();
                SqlDataAdapter Da2 = new SqlDataAdapter("select distinct network_type from customer", dal.dbc.conn);
                Da2.Fill(Dt2);
                DropDownList3.DataSource = Dt2;
                DropDownList3.DataTextField = "network_type";
                DropDownList3.DataValueField = "network_type";
                DropDownList3.DataBind();
               
                /*  }
                GridView1.DataSource = s.getData_customer();
                 GridView1.DataBind();*/
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string x = null;
            string x1 = null;
            int age1 = 0;
            int age2 = 0;
            string y = null;
            string m = null;
            string sql = null;
            DataTable yy = new DataTable();
            if (DropDownList1.SelectedValue != "a")
            {
                x = DropDownList1.SelectedValue;
                sql = "select email,phone,address,gender,age from customer where gender like '%"+ x +"%'";
            }
            else
                if (TextBox1.Text != "" && TextBox4.Text != "")
            {
                age2 = int.Parse(TextBox1.Text);
                age1 = int.Parse(TextBox4.Text);
                sql = "select email,phone,address,gender,age from customer where age between " + age1 + " and " + age2 + "";
            }
            else
                    if (TextBox2.Text != "")
            {
                y = TextBox2.Text.Trim();
                sql = "select email,phone,address,gender,age from customer where address like'%"+ y +"%'";
            }
            else
                if (TextBox3.Text != "")
            {
                m = TextBox3.Text.Trim();
                sql = "select email,phone,address,gender,age from customer where brith_day like'%"+ m +"%'";
            }
            else 
                if (DropDownList4.SelectedValue != "a")
            {
                x1 = DropDownList1.SelectedItem.Text;
                sql = "select email,phone,address,gender,age from customer where device_type like '%"+ x1 +"%'";

            }
            else
                if(DropDownList3.SelectedItem.Text !="")
            {
                x1 = DropDownList1.SelectedItem.Text;
                sql = "select email,phone,address,gender,age from customer where network_type like '%"+ x1 +"%'";

            }

            SqlDataAdapter xx = new SqlDataAdapter(sql, dal.dbc.conn);
            xx.Fill(yy);

            GridView1.DataSource = yy;
            GridView1.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            int x =int.Parse( DropDownList2.SelectedValue);
            string sql = null;
            DataTable y = new DataTable();
            if (x == 1)
                sql = "select email,phone,nationality,address,gender from customer order by gender";
            else
            if (x == 2)
                sql = "select email,phone,nationality,address,age from customer order by age";
            else
                if(x==3)
                sql = "select email,phone,nationality,address from customer order by address";
            else    
                if(x==4)
            sql = "select email,phone,nationality,address,brith_day,age from customer order by brith_day";

            SqlDataAdapter xx = new SqlDataAdapter(sql, dal.dbc.conn);
            xx.Fill(y);

            GridView1.DataSource = y;
            GridView1.DataBind();

        
      

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.ClearContent();
            // Response.Buffer = false;
            Response.AppendHeader("content-disposition", string.Format("attachment; filename=customer.xls"));
            Response.ContentType = "application/excel";
            StringWriter stringWriter = new StringWriter();
            HtmlTextWriter htmlTextWriter = new HtmlTextWriter(stringWriter);
            // GridView1.AllowPaging = false;

            GridView1.RenderControl(htmlTextWriter);
            Response.Write(stringWriter.ToString());
            Response.End();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
    }
}