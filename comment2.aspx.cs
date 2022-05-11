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
    public partial class comment2 : System.Web.UI.Page
    {
        DataTable Dt = new DataTable();

        orgproject.dal.customer pr = new orgproject.dal.customer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Visible = false;
                Button3.Visible = false;
                Button4.Visible = false;
                Label1.Visible = false;
                DropDownList2.Items.Insert(0, new ListItem("التعليق على ", "0"));
                DropDownList2.SelectedIndex = 0;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DropDownList1.Visible = true;
            Button3.Visible = true;
            Button4.Visible = true;
            Label1.Visible = true;
            int r = int.Parse(DropDownList2.SelectedValue);
            if (r == 1)
            {

                SqlDataAdapter Da = new SqlDataAdapter("select comment_id,email,star,comment,history,agent.name from comments,customer,agent where customercom_id= customer_id and comments.agent_id=agent.agent_id ", dal.dbc.conn);
                Da.Fill(Dt);

                GridView1.DataSource = Dt;
                GridView1.DataBind();
                DropDownList1.DataSource = Dt;
                DropDownList1.DataTextField = "email";
                DropDownList1.DataValueField = "comment_id";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, new ListItem("التعليق من ", "0"));
                DropDownList1.SelectedIndex = 0;
            }
            if (r == 2)
            {
                SqlDataAdapter Da = new SqlDataAdapter("select comment_id,email,star,comment,history,offers.name from comments,customer,offers where customercom_id= customer_id and comments.offer_id=offers.offer_id ", dal.dbc.conn);
                Da.Fill(Dt);

                GridView1.DataSource = Dt;
                GridView1.DataBind();
                DropDownList1.DataSource = Dt;
                DropDownList1.DataTextField = "email";
                DropDownList1.DataValueField = "comment_id";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, new ListItem("التعليق من ", "0"));
                DropDownList1.SelectedIndex = 0;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DropDownList1.Visible = false;
            Button3.Visible = false;
            Button4.Visible = false;
            Label1.Visible = false;
            int x = int.Parse(DropDownList2.SelectedValue);
            if (x == 1)
            {
                SqlDataAdapter Da = new SqlDataAdapter("select comment_id,email,star,comment,history,agent.name from comment_ok,customer,agent where customercom_id= customer_id and comment_ok.agent_id=agent.agent_id ", dal.dbc.conn);
                Da.Fill(Dt);

                GridView1.DataSource = Dt;
                GridView1.DataBind();
            }
            if (x == 2)
            {
                SqlDataAdapter Da = new SqlDataAdapter("select comment_id,email,star,comment,history,offers.name from comment_ok,customer,offers where customercom_id= customer_id and comment_ok.offer_id=offers.offer_id ", dal.dbc.conn);
                Da.Fill(Dt);

                GridView1.DataSource = Dt;
                GridView1.DataBind();
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int x = int.Parse(DropDownList1.SelectedValue);
            int n = 0;
            if (x != 0)
                n = pr.comment_ok(x);
            if (n > 0)
            {
                Label1.Text = "تمت الموافقة ";
                pr.remove_comment(x);
                SqlDataAdapter Da = new SqlDataAdapter("select comment_id,email,star,comment,history,agent.name from comments,customer,agent where customercom_id= customer_id and comments.agent_id=agent.agent_id ", dal.dbc.conn);
                Da.Fill(Dt);

                GridView1.DataSource = Dt;
                GridView1.DataBind();


            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int xx = int.Parse(DropDownList1.SelectedValue);
            int n = 0;
            if (xx != 0)
                n = pr.remove_comment(xx);
            if (n > 0)
            {
                Label1.Text = "تم رفض التعليق ومسحة";
                SqlDataAdapter Da = new SqlDataAdapter("select comment_id,email,star,comment,history,agent.name from comments,customer,agent where customercom_id= customer_id and comments.agent_id=agent.agent_id ", dal.dbc.conn);
                Da.Fill(Dt);

                GridView1.DataSource = Dt;
                GridView1.DataBind();
            }

        }
    }
}