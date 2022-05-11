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
    public partial class dragdata2 : System.Web.UI.Page
    {


        DataTable Dt = new DataTable();
        DataTable Dt1 = new DataTable();

        orgproject.dal.customer pr = new orgproject.dal.customer();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlDataAdapter Da = new SqlDataAdapter("select * from categories", dal.dbc.conn);
                Da.Fill(Dt);
                DropDownList1.DataSource = Dt;
                DropDownList1.DataTextField = "cat_name";
                DropDownList1.DataValueField = "cat_id";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, new ListItem("اختر التصنيف  ", "0"));
                DropDownList1.SelectedIndex = 0;
                DropDownList2.Items.Insert(0, "لم يتم اختيار التصنيف");
                SqlDataAdapter Da1 = new SqlDataAdapter("select email,phone,age,gender from customer", dal.dbc.conn);
                Da1.Fill(Dt1);
                GridView2.DataSource = Dt1;
                GridView2.DataBind();

            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            int id;
            string name;
            id = int.Parse(DropDownList1.SelectedValue);
            name = DropDownList1.SelectedItem.Text;
            if (id != 0)
            {
                SqlDataAdapter Da = new SqlDataAdapter("select * from agent where cat_id= " + id + "", dal.dbc.conn);
                Da.Fill(Dt1);
                DropDownList2.DataSource = Dt1;
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

        protected void Button3_Click(object sender, EventArgs e)
        {
            //  str  name = DropDownList1.SelectedItem.Text;
            int id = int.Parse(DropDownList2.SelectedValue);
            SqlDataAdapter Da = new SqlDataAdapter("select email,customer.phone,name   from customer,agent,interests_of_customer where customerinterst_id= customer_id and agentint_id=agent_id and agent_id=" + id + " ", dal.dbc.conn);
            Da.Fill(Dt);

            GridView2.DataSource = Dt;
            GridView2.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(DropDownList2.SelectedValue);
            SqlDataAdapter Da = new SqlDataAdapter("select email,name as name_agent   from customer,agent,interests_of_customer where customerinterst_id= customer_id and agentint_id=agent_id and agent_id=" + id + " ", dal.dbc.conn);
            Da.Fill(Dt);

            GridView2.DataSource = Dt;
            GridView2.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.ClearContent();
            // Response.Buffer = false;
            Response.AppendHeader("content-disposition", string.Format("attachment; filename=customer.xlsx"));
            Response.ContentType = "application/excel";
            StringWriter stringWriter = new StringWriter();
            HtmlTextWriter htmlTextWriter = new HtmlTextWriter(stringWriter);
            // GridView1.AllowPaging = false;

            GridView2.RenderControl(htmlTextWriter);
            Response.Write(stringWriter.ToString());
            Response.End();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* int id;
           string name;
           id = int.Parse(DropDownList1.SelectedValue);
           name = DropDownList1.SelectedItem.Text;
           if (id != 0)
           {
               SqlDataAdapter Da = new SqlDataAdapter("select * from agent where cat_id= " + id + "", dal.dbc.conn);
               Da.Fill(Dt1);
               DropDownList2.DataSource = Dt1;
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
           }*/
        }
    }
}