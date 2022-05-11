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
    public partial class test2 : System.Web.UI.Page
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

            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
           
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        protected void Timer1_Tick1(object sender, EventArgs e)
        {
            int id;
            // string name;
            id = int.Parse(DropDownList1.SelectedValue);
            //    name = DropDownList1.SelectedItem.Text;
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
    }
}