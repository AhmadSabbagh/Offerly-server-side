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
    
    public partial class priv : System.Web.UI.Page
    {
        orgproject.dal.customer pr = new orgproject.dal.customer();
        //  SqlConnection con = new SqlConnection(@"Server=.\SQLEXPRESS; Database=DB; Integrated Security=true");
        SqlDataAdapter Da;
        DataTable Dts = new DataTable();
       
            
         //   LoadData();

        
        void LoadData()
        {

            DataTable Dt = new DataTable();
            DataTable Dt2 = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select agent_id,name from agent", dal.dbc.conn);
            Da.Fill(Dt);
            SqlDataAdapter Db = new SqlDataAdapter("select admin_id,admin_name from admin", dal.dbc.conn);
            Db.Fill(Dt);


            SqlDataAdapter Da2 = new SqlDataAdapter("select * from list ", dal.dbc.conn);
            Da2.Fill(Dt2);
            DropDownList2.DataSource = Dt2;
            DropDownList2.DataTextField = "List_name";
            DropDownList2.DataValueField = "List_ID";
            DropDownList2.DataBind();
            int a = int.Parse(DropDownList2.SelectedValue);
            if (a == 2)
            {
                DropDownList1.DataSource = Dt;
                DropDownList1.DataTextField = "admin_name";
                DropDownList1.DataValueField = "agent_id";
                DropDownList1.DataBind();
            }
            else
            if (a == 1)
            {
                DropDownList1.DataSource = Dt;
                DropDownList1.DataTextField = "admin_name";
                DropDownList1.DataValueField = "admin_id";
                DropDownList1.DataBind();
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                LoadData();

           
        }

        protected void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Dts.Clear();
             SqlDataAdapter   Da = new SqlDataAdapter("select priv.priv_scren_id,scren_name,priv_agent_id,p_disply, P_add,p_edit,p_delete  from priv,screen where  priv_scren_id=screen.scren_id and screen.list_id=(select list_id from list where list_id= 1)    and priv_agent_id= 4003", dal.dbc.conn);

                Da.Fill(Dts);
               GridView1.DataSource = Dts;
               /* GridView1.Columns[0].Visible = false;
                GridView1.Columns[2].Visible = false;
               // GridView1.Columns[1].Width = 120;
                GridView1.Columns[1].HeaderText = "أسـم الـشـاشـة";
                GridView1.Columns[3].HeaderText = "عـرض";
                GridView1.Columns[4].HeaderText = "إضـافة";
                GridView1.Columns[5].HeaderText = "تـعـديل";
                GridView1.Columns[6].HeaderText = "حـذف";
                //  GridView1.Columns[2].ReadOnly = true;*/
                GridView1.DataBind();
            }
            catch (Exception)
            {

                //throw;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Dts.Clear();
            int x = int.Parse(DropDownList2.SelectedValue);
            int y = int.Parse(DropDownList1.SelectedValue);
            SqlDataAdapter Da = new SqlDataAdapter("select priv.priv_scren_id,scren_name,priv_agent_id,p_disply, P_add,p_edit,p_delete  from priv,screen where  priv_scren_id=screen.scren_id and screen.list_id=(select list_id from list where list_id=" + x + ") and priv_agent_id= " + y + "", dal.dbc.conn);

            Da.Fill(Dts);
            GridView1.DataSource = Dts;
            //  GridView1.Columns[0].Visible = false;
            //    GridView1.Columns[2].Visible = false;
            // GridView1.Width = 120;
          //  GridView1.Columns[0].w
            //    GridView1.Columns[].HeaderText = "أسـم الـشـاشـة";
            //  GridView1.Columns[3].HeaderText = "عـرض";
            //   GridView1.Columns[4].HeaderText = "إضـافة";
            //   GridView1.Columns[5].HeaderText = "تـعـديل";
            //    GridView1.Columns[6].HeaderText = "حـذف";
            //  GridView1.Columns[2].ReadOnly = true;
            GridView1.DataBind();
            // GridView1.Columns[]
            // Response.Write(GridView1.ind);
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {

            
        }
    }
}