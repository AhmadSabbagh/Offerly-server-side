using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace orgproject
{
    public partial class users : System.Web.UI.Page
    {

        dal.dalemployee dal_emp = new dal.dalemployee();
        dal.entityuser ent_user = new dal.entityuser();
        dal.daluser dal_user = new dal.daluser();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddluser.DataSource = dal_emp.getData();
                ddluser.DataTextField = "employeename";
                ddluser.DataValueField = "employeeid";
                ddluser.DataBind();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                ent_user.employeeid = int.Parse(ddluser.SelectedValue);
                ent_user.username = txtusername.Text;
                ent_user.password = txtpassword.Text;

                if (dal_user.add(ent_user) > 0)
                    Response.Write("Data Was Saved Successfully ..!");

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        
    }
    }
}