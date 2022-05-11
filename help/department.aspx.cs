using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace orgproject
{
    public partial class department : System.Web.UI.Page
    {

        dal.daldepartment dept = new dal.daldepartment();
        dal.entitydepartment ent_dept = new dal.entitydepartment();
        dal.dallocation loc = new dal.dallocation();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddllocation.DataSource = loc.getData();
                ddllocation.DataTextField = "locName";
                ddllocation.DataValueField = "locID";
                ddllocation.DataBind();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                ent_dept.deptid = int.Parse(txtdeptid.Text);
                ent_dept.deptname = txtdeptname.Text;
               
                ent_dept.locid = int.Parse(ddllocation.SelectedValue);

                if (dept.add(ent_dept) > 0)
                    Response.Write("Data Was Saved Successfully ..!");

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void ddllocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}