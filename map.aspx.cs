using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace orgproject
{
    public partial class map : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label1.Text = Session["agent"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = (int)Session["agent"];

                decimal la = decimal.Parse(latitude.Text);
                decimal lo = decimal.Parse(longitude.Text);
                string sql = "update  agent  set latitude=" + la + " ,longitude=" + lo + " where agent_id=" + x + "";
                SqlCommand cmd = new SqlCommand(sql, dal.dbc.conn);
                dal.dbc.conn.Open();
                int result = cmd.ExecuteNonQuery();
                dal.dbc.conn.Close();

                /*    Label1.Text = la + "";
                     Label2.Text = lo + "";

                     Session["lo"] = longitude.Text;
                     Session["la"] = latitude.Text;*/
                if (result != 0)
                    Response.Redirect("picture.aspx");
                //else
                   // Label1.Text = "اعد المحاوله";
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);

            }
        }
    }
}