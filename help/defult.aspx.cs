using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace orgproject
{
    public partial class defult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Response.Write(Session["id"].ToString);
            if (Session["t"] != null)
            {
                DataTable table = (DataTable)Session["t"];
                fullname.Text=("welcome:" + table.Rows[0]["employeename"]);
            }
            else
                Response.Redirect("Login.aspx");
        }

        protected void btnemployee_Click(object sender, EventArgs e)
        {

        }

        protected void btnemployee_Click1(object sender, EventArgs e)
        {

        }

        protected void btnlocation_Click(object sender, EventArgs e)
        {

        }
    }
}