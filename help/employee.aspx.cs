using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace orgproject
{
    public partial class employee : System.Web.UI.Page
    {
        dal.daldepartment dept = new dal.daldepartment();

        dal.dalemployee dal_emp = new dal.dalemployee();
        dal.entityemployee ent_emp = new dal.entityemployee();

        protected void Page_Load(object sender, EventArgs e)
        {
           if(!Page.IsPostBack)
            {
                ddlDeprtment.DataSource = dept.getData();
                ddlDeprtment.DataTextField = "departname";
                ddlDeprtment.DataValueField = "departid";
                ddlDeprtment.DataBind();
            }
            GridView1.DataSource = dal_emp.getData();
            GridView1.DataBind();

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ent_emp.employeename = txtemployeename.Text;
                ent_emp.salary = decimal.Parse(txtsalary.Text);
                ent_emp.gender = rdoMale.Checked ? "M" : "F";
                ent_emp.deptid = int.Parse(ddlDeprtment.SelectedValue);

                if (dal_emp.add(ent_emp) > 0)
                {
                    Response.Write("Data Was Saved Successfully ..!");
                    GridView1.DataSource = dal_emp.getData();
                    GridView1.DataBind();
                }

                }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnedit_Click(object sender, EventArgs e)
        {

            try
            {
                ent_emp.employeeid = int.Parse(txtemployeeid.Text);
                ent_emp.employeename = txtemployeename.Text;
                ent_emp.salary = decimal.Parse(txtsalary.Text);
                ent_emp.gender = rdoMale.Checked ? "M" : "F";
                ent_emp.deptid = int.Parse(ddlDeprtment.SelectedValue);

                if (dal_emp.edit(ent_emp) > 0)
                {
                    Response.Write("Data Was Saved Successfully ..!");
                    GridView1.DataSource = dal_emp.getData();
                    GridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnremove_Click(object sender, EventArgs e)
        {
            try
            {
                ent_emp.employeeid = int.Parse(txtemployeeid.Text);


                if (dal_emp.remove(ent_emp) > 0)
                {
                    Response.Write("Data Was Saved Successfully ..!");
                    GridView1.DataSource = dal_emp.getData();
                    GridView1.DataBind();
                }
                }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}