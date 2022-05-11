
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace OrgProject
{
    public partial class Login : System.Web.UI.Page
    {

        orgproject.dal.customer ca = new orgproject.dal.customer();
        orgproject.dal.ReturnData rt = new orgproject.dal.ReturnData();
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }


        public string SHA512(string pass)
        {
            SHA512Managed SHA512 = new SHA512Managed();
            byte[] Hash = System.Text.Encoding.UTF8.GetBytes(pass);
            Hash = SHA512.ComputeHash(Hash);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in Hash)
            {
                sb.Append(b.ToString("x2").ToLower());
            }
            return sb.ToString();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DAL.dbc.conn.Open();
            //    Response.Write("Success");
            //}
            //catch(Exception ex)
            //{
            //    Response.Write(ex.Message);
            //}
            //finally
            //{
            //    DAL.dbc.conn.Close();
            //}
            


                        try
                        {




                            string username = txtusername.Text;
                            string pass = SHA512(txtpassword.Text);
                            if (DropDownList1.SelectedItem.Value == "Agent")
                            {
                   
                               // rt= ca.LoginAgent(username, pass);//اذا هناك تعديل بالحقول 
                                int x = rt.id;
                                if (1 > 0)
                                {
                                    Session["tt"] = rt.id;

                                    //Session["id"] = table.Rows[0]["EmployeeID"].ToString();
                                    //Session["fn"] = table.Rows[0]["EmployeeName"].ToString();

                                    Response.Redirect("profile.aspx?id="+ x +"");
                                }
                                else
                                {
                                    Label1.Text = "Wrong username or password";
                                }
                            }
                          else 
                                if(DropDownList1.SelectedItem.Value=="Admin")
                            {
                                      // rt = ca.loginadmin(username, pass);//اذا هناك تعديل بالحقول 
                                      int x = rt.id;
                    string y = rt.unid;
                                       if (1> 0)
                                          {
                                              Session["t"] = rt.id;

                        //Session["id"] = table.Rows[0]["EmployeeID"].ToString();
                        //Session["fn"] = table.Rows[0]["EmployeeName"].ToString();

                                               Response.Redirect("Home.aspx?unid=1234*784abcd$%&^@!$#" + y + "");
                                                  }
                                                         else
                                                  {
                        Label1.Text = "Wrong username or password";

                                                   }
                            }
                        }

                        catch (Exception ex)
                        {
                            Response.Write(ex.Message);

                        }

        
}

        

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}