using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace orgproject
{
    public partial class location : System.Web.UI.Page
    {
        dal.entitylocation ent_loc = new dal.entitylocation();
        dal.dallocation loc = new dal.dallocation();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                ent_loc.locid = int.Parse(txtlocid.Text);
                ent_loc.locname = txtlocname.Text;

               

                if (loc.add(ent_loc) > 0)
                    Response.Write("Data Was Saved Successfully ..!");

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

        }
    }
}