using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace orgproject
{
    public partial class suggestion_complint2 : System.Web.UI.Page
    {
        orgproject.dal.customer cs = new orgproject.dal.customer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GridView1.DataSource = cs.getData_suggest();
                GridView1.DataBind();

                GridView2.DataSource = cs.getData_complaint();
                GridView2.DataBind();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n = cs.remove_suggest();
            if (n > 0)
                Label1.Text = "تم المسح بنجاح";
            GridView1.DataSource = cs.getData_suggest();
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int n = cs.remove_complaint();
            if (n > 0)
                Label2.Text = "تم المسح بنجاح";
            GridView2.DataSource = cs.getData_complaint();
            GridView2.DataBind();
        }
    }
}