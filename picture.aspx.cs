using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace orgproject
{
    public partial class picture : System.Web.UI.Page
    {
        dal.customer ss = new dal.customer();
        dal.send sss = new dal.send();
        dal.send_ios sios = new dal.send_ios();
        dal.send_flow sflow = new dal.send_flow();
        dal.send_flowios sflowios = new dal.send_flowios();

        protected void Page_Load(object sender, EventArgs e)
        {
            Button2.Visible = false;
            Button9.Visible = false;
            if (! Page.IsPostBack)
            {
                
                DataTable Dt = new DataTable();
                SqlDataAdapter Da = new SqlDataAdapter("select * from advert", dal.dbc.conn);
                Da.Fill(Dt);
                DropDownList1.DataSource = Dt;
                DropDownList1.DataTextField = "advert";
                DropDownList1.DataValueField = "advert_id";
                DropDownList1.DataBind();

                DropDownList2.DataSource = ss.getData_agent();
                DropDownList2.DataTextField = "name";
                DropDownList2.DataValueField = "agent_id";
                DropDownList2.DataBind();

                DropDownList8.DataSource = ss.getData_agent();
                DropDownList8.DataTextField = "name";
                DropDownList8.DataValueField = "agent_id";
                DropDownList8.DataBind();
                //int x = int.Parse(DropDownList2.SelectedValue);
                DropDownList3.DataSource = ss.getData_offer();
                DropDownList3.DataTextField = "offer_name";
                DropDownList3.DataValueField = "offer_id";
                DropDownList3.DataBind();

                DataTable Dt1 = new DataTable();
                SqlDataAdapter Da1 = new SqlDataAdapter("select * from hot_event", dal.dbc.conn);
                Da1.Fill(Dt1);
                DropDownList4.DataSource = Dt1;
                DropDownList4.DataTextField = "descr";
                DropDownList4.DataValueField = "hotevent_id";
                DropDownList4.DataBind();

                DataTable Dt3 = new DataTable();
                SqlDataAdapter Da3 = new SqlDataAdapter("select * from hot_offer", dal.dbc.conn);
                Da3.Fill(Dt3);
                DropDownList5.DataSource = Dt3;
                DropDownList5.DataTextField = "hot_name";
                DropDownList5.DataValueField = "hot_id";
                DropDownList5.DataBind();

                DataTable Dt6 = new DataTable();
                SqlDataAdapter Da6 = new SqlDataAdapter("select * from agent", dal.dbc.conn);
                Da6.Fill(Dt6);
                DropDownList6.DataSource = Dt6;
                DropDownList6.DataTextField = "name";
                DropDownList6.DataValueField = "agent_id";
                DropDownList6.DataBind();

                DataTable Dt9 = new DataTable();
                SqlDataAdapter Da9 = new SqlDataAdapter("select * from sub_categorie", dal.dbc.conn);
                Da9.Fill(Dt9);
                DropDownList9.DataSource = Dt9;
                DropDownList9.DataTextField = "catsub_name";
                DropDownList9.DataValueField = "sub_id";
                DropDownList9.DataBind();

                Label1.Visible = false;
                Label2.Visible = false;
                Label3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Label1.Visible = true;
                int result = 0;
                string sql1 = null;
                int x = int.Parse(DropDownList1.SelectedValue);
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
                    sql1 = "update advert set picture ='" + (object)imgdata + "',url='"+file+"' where advert_id=" + x + "";
                    SqlCommand cmd = new SqlCommand(sql1, dal.dbc.conn);
                    dal.dbc.conn.Open();
                    result = cmd.ExecuteNonQuery();
                    dal.dbc.conn.Close();
                    //  File.Delete(Server.MapPath("image.jpg"));
                    Label1.Text = "تم رفع الصوره";
                }
                else
                    Label1.Text = "ارفع ملف صوره صحيح";
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {


            int x = int.Parse(DropDownList8.SelectedValue);
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select * from news where agent_id=" + x + "", dal.dbc.conn);
            Da.Fill(Dt);
            DropDownList7.DataSource = Dt;
            DropDownList7.DataTextField = "news_name";
            DropDownList7.DataValueField = "new_id";
            DropDownList7.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                Label6.Visible = true;
                int o = 0;
                int m = int.Parse(DropDownList3.SelectedValue);
                SqlCommand cmd2 = new SqlCommand("select ch from offers where offer_id=" + m + " ", dal.dbc.conn);

                SqlDataReader reader;
                dal.dbc.conn.Open();
                reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    o = reader.GetInt32(0);
                   
                }
                reader.Close();

                string sql1 = null;

                
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
                    if (o != 1)
                        sql1 = "insert into picture (offerpc_id,picture,url) values (" + m + ",'" + (object)imgdata + "','" + file + "')";
                    else if (o == 1)
                    {
                        sql1 = "update offers  set url='" + file + "',ch=0  where offer_id=" + m + "";
                        int agent=int.Parse(DropDownList2.SelectedValue);
                        sflow.SendNotification(agent);
                        sflowios.SendNotification(agent);

                    }
                    SqlCommand cmd = new SqlCommand(sql1, dal.dbc.conn);
                  //  dal.dbc.conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    dal.dbc.conn.Close();
                  //  File.Delete(Server.MapPath("image.jpg"));
                    Label6.Text = "تم رفع الصورة ";
                }
                else
                    Label6.Text = "ارفع ملف صوره صحيح";
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                Label2.Visible = true;
                int result = 0;
                string sql1 = null;
                int x = int.Parse(DropDownList4.SelectedValue);
                if (FileUpload3.HasFile)

                {
                    string UNid = Convert.ToString(Guid.NewGuid());
                    string file = UNid + ".jpg";
                    FileUpload3.SaveAs(Server.MapPath(UNid + ".jpg"));
                    FileStream fs = new FileStream(Server.MapPath(UNid + ".jpg"), FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    FileInfo fi = new FileInfo(Server.MapPath(UNid + ".jpg"));
                    byte[] imgdata = br.ReadBytes((int)fi.Length);
                    fs.Close();
                    br.Close();
                    sql1 = "update hot_event set picture ='" + (object)imgdata + "',url='"+file+"' where hotevent_id=" + x + "";
                    SqlCommand cmd = new SqlCommand(sql1, dal.dbc.conn);
                    dal.dbc.conn.Open();
                    result = cmd.ExecuteNonQuery();
                    dal.dbc.conn.Close();
                    //  File.Delete(Server.MapPath("image.jpg"));
                    //  dal.send sss = new dal.send();
                      sss.SendNotification();
                     sios.SendNotification();


                   
                   


                    Label2.Text = "تم رفع الصوره";
                }
                else
                    Label2.Text = "ارفع ملف صوره صحيح";
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                Label3.Visible = true;
                int m = int.Parse(DropDownList4.SelectedValue);
                if (FileUpload4.HasFile)

                {
                    string UNid = Convert.ToString(Guid.NewGuid());
                    string file = UNid + ".jpg";
                    FileUpload4.SaveAs(Server.MapPath(UNid + ".jpg"));
                    FileStream fs = new FileStream(Server.MapPath(UNid + ".jpg"), FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    FileInfo fi = new FileInfo(Server.MapPath(UNid + ".jpg"));
                    byte[] imgdata = br.ReadBytes((int)fi.Length);
                    fs.Close();
                    br.Close();
                    //   ss.add_picture(m, imgdata);
                    string sql1 = "insert into picture (hoteventpc_id,picture,url) values (" + m + ",'" + (object)imgdata + "','"+file+"')";
                    SqlCommand cmd = new SqlCommand(sql1, dal.dbc.conn);
                    dal.dbc.conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    dal.dbc.conn.Close();
                    //  File.Delete(Server.MapPath("image.jpg"));
                    Label3.Text = "تم رفع الصورة ";
                }
                else
                    Label3.Text = "ارفع ملف صوره صحيح";
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                Label4.Visible = true;
                int result = 0;
                string sql1 = null;
                int x = int.Parse(DropDownList5.SelectedValue);
                if (FileUpload5.HasFile)

                {
                    string UNid = Convert.ToString(Guid.NewGuid());
                    string file = UNid + ".jpg";
                    FileUpload5.SaveAs(Server.MapPath(UNid + ".jpg"));
                    FileStream fs = new FileStream(Server.MapPath(UNid + ".jpg"), FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    FileInfo fi = new FileInfo(Server.MapPath(UNid + ".jpg"));
                    byte[] imgdata = br.ReadBytes((int)fi.Length);
                    fs.Close();
                    br.Close();
                    sql1 = "update hot_offer set picture ='" + (object)imgdata + "',url='"+file+"' where hot_id=" + x + "";
                    SqlCommand cmd = new SqlCommand(sql1, dal.dbc.conn);
                    dal.dbc.conn.Open();
                    result = cmd.ExecuteNonQuery();
                    dal.dbc.conn.Close();
                    //  File.Delete(Server.MapPath("image.jpg"));
                    sss.SendNotification();
                    sios.SendNotification();
                    Label4.Text = "تم رفع الصوره";
                }
                else
                    Label4.Text = "ارفع ملف صوره صحيح";
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);
            }

        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                Label5.Visible = true;
                int m = int.Parse(DropDownList6.SelectedValue);
                if (FileUpload6.HasFile)

                {
                    string UNid = Convert.ToString(Guid.NewGuid());
                    string file = UNid + ".jpg";
                    FileUpload6.SaveAs(Server.MapPath(UNid + ".jpg"));
                    FileStream fs = new FileStream(Server.MapPath(UNid + ".jpg"), FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    FileInfo fi = new FileInfo(Server.MapPath(UNid + ".jpg"));
                    byte[] imgdata = br.ReadBytes((int)fi.Length);
                    fs.Close();
                    br.Close();
                    //   ss.add_picture(m, imgdata);
                    string sql1 = "insert into picture (agentpc_id,picture,url) values (" + m + ",'" + (object)imgdata + "','"+file+"')";
                    SqlCommand cmd = new SqlCommand(sql1, dal.dbc.conn);
                    dal.dbc.conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    dal.dbc.conn.Close();
                    //  File.Delete(Server.MapPath("image.jpg"));
                    Label5.Text = "تم رفع الصورة ";
                }
                else
                    Label5.Text = "ارفع ملف صوره صحيح";
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            int x = int.Parse(DropDownList2.SelectedValue);
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select * from offers where agentoff_id="+x+"", dal.dbc.conn);
            Da.Fill(Dt);
            DropDownList3.DataSource = Dt;
            DropDownList3.DataTextField = "offer_name";
            DropDownList3.DataValueField = "offer_id";
            DropDownList3.DataBind();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                Label7.Visible = true;
                int m = int.Parse(DropDownList7.SelectedValue);
                if (FileUpload7.HasFile)

                {
                    string UNid = Convert.ToString(Guid.NewGuid());
                    string file = UNid + ".jpg";
                    FileUpload7.SaveAs(Server.MapPath(UNid + ".jpg"));
                    FileStream fs = new FileStream(Server.MapPath(UNid + ".jpg"), FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    FileInfo fi = new FileInfo(Server.MapPath(UNid + ".jpg"));
                    byte[] imgdata = br.ReadBytes((int)fi.Length);
                    fs.Close();
                    br.Close();
                    //   ss.add_picture(m, imgdata);
                    string sql1 = "update news set picture ='" + (object)imgdata + "',url='"+file+"' where new_id="+ m +"";
                    SqlCommand cmd = new SqlCommand(sql1, dal.dbc.conn);
                    dal.dbc.conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    dal.dbc.conn.Close();
                    int agent_id = int.Parse(DropDownList8.SelectedValue);
                    sflow.SendNotification(agent_id);
                    sflowios.SendNotification(agent_id);
                    //  File.Delete(Server.MapPath("image.jpg"));
                    Label7.Text = "تم رفع الصورة ";
                }
                else
                    Label7.Text = "ارفع ملف صوره صحيح";
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);
            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            try
            {
                Label5.Visible = true;
                int m = int.Parse(DropDownList6.SelectedValue);
                if (FileUpload8.HasFile)

                {
                    string UNid = Convert.ToString(Guid.NewGuid());
                    string file = UNid + ".jpg";
                    FileUpload8.SaveAs(Server.MapPath(UNid + ".jpg"));
                    FileStream fs = new FileStream(Server.MapPath(UNid + ".jpg"), FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    FileInfo fi = new FileInfo(Server.MapPath(UNid + ".jpg"));
                    byte[] imgdata = br.ReadBytes((int)fi.Length);
                    fs.Close();
                    br.Close();
                    //   ss.add_picture(m, imgdata);
                    string sql1 = "update agent set urla='" + file + "' where agent_id=" + m + "";
                    SqlCommand cmd = new SqlCommand(sql1, dal.dbc.conn);
                    dal.dbc.conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    dal.dbc.conn.Close();
                    //  File.Delete(Server.MapPath("image.jpg"));
                    Label8.Text = "تم رفع الصورة ";
                }
                else
                    Label8.Text = "ارفع ملف صوره صحيح";
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);
            }
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            try
            {
                Label9.Visible = true;
                int m = int.Parse(DropDownList9.SelectedValue);
                if (FileUpload9.HasFile)

                {
                    string UNid = Convert.ToString(Guid.NewGuid());
                    string file = UNid + ".jpg";
                    FileUpload9.SaveAs(Server.MapPath(UNid + ".jpg"));
                    FileStream fs = new FileStream(Server.MapPath(UNid + ".jpg"), FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    FileInfo fi = new FileInfo(Server.MapPath(UNid + ".jpg"));
                    byte[] imgdata = br.ReadBytes((int)fi.Length);
                    fs.Close();
                    br.Close();
                    //   ss.add_picture(m, imgdata);
                    string sql1 = "update sub_categorie set url='" + file + "' where sub_id=" + m + "";
                    SqlCommand cmd = new SqlCommand(sql1, dal.dbc.conn);
                    dal.dbc.conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    dal.dbc.conn.Close();
                    //  File.Delete(Server.MapPath("image.jpg"));
                    Label8.Text = "تم رفع الصورة ";
                }
                else
                    Label8.Text = "ارفع ملف صوره صحيح";
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Response.Write(ex.Message);
            }
        }

        protected void DropDownList8_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = int.Parse(DropDownList8.SelectedValue);
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select * from news where agent_id=" + x + "", dal.dbc.conn);
            Da.Fill(Dt);
            DropDownList7.DataSource = Dt;
            DropDownList7.DataTextField = "news_name";
            DropDownList7.DataValueField = "new_id";
            DropDownList7.DataBind();
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = int.Parse(DropDownList2.SelectedValue);
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select * from offers where agentoff_id=" + x + "", dal.dbc.conn);
            Da.Fill(Dt);
            DropDownList3.DataSource = Dt;
            DropDownList3.DataTextField = "offer_name";
            DropDownList3.DataValueField = "offer_id";
            DropDownList3.DataBind();

        }
    }
}