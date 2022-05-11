using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace orgproject
{
    public partial class product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataTable Dt = new DataTable();
                SqlDataAdapter Da = new SqlDataAdapter("select * from product", dal.dbc.conn);
                Da.Fill(Dt);
                DropDownList1.DataSource = Dt;
                DropDownList1.DataTextField = "product_name";
                DropDownList1.DataValueField = "product_id";
                DropDownList1.DataBind();

                DataTable Dt2 = new DataTable();
                SqlDataAdapter Da2 = new SqlDataAdapter("select * from product", dal.dbc.conn);
                Da2.Fill(Dt2);
                DropDownList2.DataSource = Dt2;
                DropDownList2.DataTextField = "product_name";
                DropDownList2.DataValueField = "product_id";
                DropDownList2.DataBind();

                DataTable y = new DataTable();
                string sql = "select product_name,name,phone,address,price from product,product_order where product_order.product_id=product.product_id";
                SqlDataAdapter x = new SqlDataAdapter(sql, dal.dbc.conn);
                x.Fill(y);
                GridView1.DataSource = y;
              GridView1.DataBind();
                
                Label1.Text = "";
                Label2.Text = "";
            }
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                //Label1.Visible = true;
                int result = 0;
                string pname = TextBox2.Text;
                string descr = TextBox4.Text;
                decimal p = decimal.Parse(TextBox5.Text);
                string sql1 = null;
             //   int x = int.Parse(DropDownList1.SelectedValue);
                if (FileUpload1.HasFile)

                {
                    string UNid = Convert.ToString(Guid.NewGuid());
                    string file = UNid + ".jpg";
                    FileUpload1.SaveAs(Server.MapPath(UNid + ".jpg"));
                    FileStream fs = new FileStream(Server.MapPath(UNid + ".jpg"), FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    FileInfo fi = new FileInfo(Server.MapPath(UNid + ".jpg"));
                    byte[] imgdata = br.ReadBytes((int)fi.Length);
                    fs.Close();
                    br.Close();
                    sql1 = "insert into product (product_name,url,price,descr)values('" + pname + "','" + file + "'," + p + ",'"+descr+"')";
                    SqlCommand cmd = new SqlCommand(sql1, dal.dbc.conn);
                    dal.dbc.conn.Open();
                    result = cmd.ExecuteNonQuery();
                    dal.dbc.conn.Close();
                    //  File.Delete(Server.MapPath("image.jpg"));
                    Label1.Text = "تم اضافة المنتج بنجاح";
                }
                else
                    Label1.Text = "معلومات خطأ";
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);
            }
            TextBox5.Text = "";
            TextBox4.Text = "";
            TextBox2.Text = "";
        }

        protected void Button5_Click1(object sender, EventArgs e)
        {
            try
            {
                int result = 0;
                int ad_id = int.Parse(DropDownList1.SelectedValue);
                string sql = "delete from product where product_id =" + ad_id + " ";


                SqlCommand cmd = new SqlCommand(sql, dal.dbc.conn);
                dal.dbc.conn.Open();
                result = cmd.ExecuteNonQuery();
                dal.dbc.conn.Close();
                if (result != 0)
                    Label2.Text = "تم حذف المنتج بنجاح ";
                if (!IsPostBack)
                {
                    DataTable Dt = new DataTable();
                    SqlDataAdapter Da = new SqlDataAdapter("select * from product", dal.dbc.conn);
                    Da.Fill(Dt);
                    DropDownList1.DataSource = Dt;
                    DropDownList1.DataTextField = "product_name";
                    DropDownList1.DataValueField = "product_id";
                    DropDownList1.DataBind();
                }
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);

            }
            TextBox5.Text = "";
            TextBox4.Text = "";
            TextBox2.Text = "";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            try
            {
              //  Label3.Visible = true;
                int m = int.Parse(DropDownList2.SelectedValue);
                if (FileUpload2.HasFile)

                {
                    string UNid = Convert.ToString(Guid.NewGuid());
                    string file = UNid + ".jpg";
                    FileUpload2.SaveAs(Server.MapPath(UNid + ".jpg"));
                    FileStream fs = new FileStream(Server.MapPath(UNid + ".jpg"), FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    FileInfo fi = new FileInfo(Server.MapPath(UNid + ".jpg"));
                    byte[] imgdata = br.ReadBytes((int)fi.Length);
                    fs.Close();
                    br.Close();
                    //   ss.add_picture(m, imgdata);
                    string sql1 = "insert into picture (product_id,picture,url) values (" + m + ",'" + (object)imgdata + "','" + file + "')";
                    SqlCommand cmd = new SqlCommand(sql1, dal.dbc.conn);
                    dal.dbc.conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    dal.dbc.conn.Close();
                    //  Faile.Delete(Server.MapPath("image.jpg"));
                    Label12.Text = "تم رفع الصورة ";
                }
                else
                    Label12.Text = "ارفع ملف صوره صحيح";
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);
            }
        }

       
    }
    }
    