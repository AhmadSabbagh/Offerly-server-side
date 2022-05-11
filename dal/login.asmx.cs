using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;


namespace orgproject.dal
{
    /// <summary>
    /// Summary description for login
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class login : System.Web.Services.WebService
    {

      /*  [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }*/
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void Login(string email,string facebook_go_tw, string password)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            int UserID = 0;
            string Message = "";
            string sql = "";
            SHA512Managed SHA512 = new SHA512Managed();
            byte[] Hash = System.Text.Encoding.UTF8.GetBytes(password);
            Hash = SHA512.ComputeHash(Hash);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in Hash)
            {
                sb.Append(b.ToString("x2").ToLower());
            }
            string pass= sb.ToString();

            try
            {
                SqlDataReader reader;
                if(email !="")
                 sql = "select customer_id from customer where email='" + email + "'and password='" + password + "' ";
                if(facebook_go_tw !="")
                    sql = "select customer_id from customer where facebook='" + facebook_go_tw + "'and password='" + password + "' ";
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UserID = reader.GetInt32(0);

                }
                if (UserID == 0)
                {
                    Message = " user name or password is in correct";
                }
                else
                    Message = "login succ";
                reader.Close();

                dal.dbc.conn.Close();


            }
            catch (Exception ex)
            {
                Message = " cannot access to the data";


            }

            var jsonData = new
            {
                id = UserID,
                message = Message
            };           
            Context.Response.Write( sr.Serialize(jsonData));
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void activemail(string email, string code)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            int UserID = 0;
            string Message = "";
            // int act = code / 4596;
            string act = "123456";
            try
            {
                SqlDataReader reader;
                string sql = "select customer_id from customer where email='" + email + "' ";
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UserID = reader.GetInt32(0);

                }
                //  if (UserID == act)
                if (code == act)
                {
                    Message = " active succ";
                }
                else
                    Message = "active code in correct";
                reader.Close();
                dal.dbc.conn.Close();
            }
            catch (Exception ex)
            {
                Message = " cannot access to the data";
                dal.dbc.conn.Close();
            }

            var jsonData = new
            {
                customer_id = UserID,
                message =  Message
            };
            Context.Response.Write( sr.Serialize(jsonData));
        }


        [WebMethod(MessageName = "add_customer_reg", Description = "this method add costomer")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void add_customer(string email, string facebook_go_tw, string password, string phone, string nationality, string address, string brith_day, string marriage_date, string gender, int age, string network_type, string device_type,decimal latitude ,decimal longitude)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
          /*  SHA512Managed SHA512 = new SHA512Managed();
            byte[] Hash = System.Text.Encoding.UTF8.GetBytes(password);
            Hash = SHA512.ComputeHash(Hash);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in Hash)
            {
                sb.Append(b.ToString("x2").ToLower());
            }
           string pass= sb.ToString();*/
            string mess = null;
            int result = 0;
            string sql = "";
            int id = 0;
            DataTable rt1 = new DataTable();
            ReturnData rt = new ReturnData();
            try
            {
                if (email != "")
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("select * from customer where email like '"+ email +"' ", dbc.conn);

                    adapter.Fill(rt1);
                }
                else
                if (facebook_go_tw != "")
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("select * from customer where facebook like '"+ facebook_go_tw +"' ", dbc.conn);

                    adapter.Fill(rt1);
                }
                if (rt1 != null && rt1.Rows.Count > 0)
                    {
                        mess = "User already exists";
                        result = 0;
                    }
               
                else
                {
                    if (email != "")
                        sql = "insert into customer (email,password,phone,nationality,address,brith_day,marriage_date,gender,age,network_type,device_type,latitude,longitude) values ('" + email + "','" + password + "','" + phone + "','" + nationality + "','" + address + "','" + brith_day + "','" + marriage_date + "','" + gender + "'," + age + ",'" + network_type + "','" + device_type + "','"+ latitude+"','"+ longitude+"')";

                    if (facebook_go_tw != "")
                        sql = "insert into customer (facebook,password,phone,nationality,address,brith_day,marriage_date,gender,age,network_type,device_type,latitude,longitude) values ('" + facebook_go_tw + "','" + password + "','" + phone + "','" + nationality + "','" + address + "','" + brith_day + "','" + marriage_date + "','" + gender + "'," + age + ",'" + network_type + "','" + device_type + "','"+ latitude+"','"+ longitude+"')";
                    /*  else
                      if (google != null)
                          sql = "insert into customer (google,pass,phone,nationality,address,brith_day,marriage_date,gender,age,network_type,device_type) values ('" + google + "','" + password + "','" + phone + "','" + nationality + "','" + address + "','" + brith_day + "','" + marriage_date + "','" + gender + "'," + age + ",'" + network_type + "','" + device_type + "')";
                      else
                      if (twiter != null)
                          sql = "insert into customer (twiter,pass,phone,nationality,address,brith_day,marriage_date,gender,age,network_type,device_type) values ('" + twiter + "','" + password + "','" + phone + "','" + nationality + "','" + address + "','" + brith_day + "','" + marriage_date + "','" + gender + "'," + age + ",'" + network_type + "','" + device_type + "')";
                    */
                    
                    SqlCommand cmd = new SqlCommand(sql, dal.dbc.conn);
                    dal.dbc.conn.Open();
                    result = cmd.ExecuteNonQuery();
                    dal.dbc.conn.Close();
                    if (result != 0)
                    { 
                        mess = "add succ ";
                   
                    }
                }
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                mess = "تأكد من صحة البيانات ";
            }
            var jsonData = new
            {
                message = mess
            };
            Context.Response.Write(sr.Serialize(jsonData));
        }

        [WebMethod(MessageName = "change_password", Description = "this method change password")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void change_password(string email, string old_password, string new_password)
        {
            sha hh = new sha();
            JavaScriptSerializer sr = new JavaScriptSerializer();
          //  string oldpass = hh.SHA512(old_password);
            //string newpass = hh.SHA512(new_password);
            string Message = "";
            int result = 0;

            try
            {
                string sql = "update customer  set password ='" + new_password + "' where password='" + old_password + "'and email='" + email + "' ";
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                dal.dbc.conn.Open();
                result = cmd.ExecuteNonQuery();
                dal.dbc.conn.Close();
                if (result != 0)
                    Message = "Password changed Successfully";
                else
                    Message = "Please enter correct Current password";
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Message = "Please enter correct Current password";
            }

            var jsonData = new
            {
                message = Message
            };
            Context.Response.Write( sr.Serialize(jsonData));
        }


        [WebMethod(MessageName = "forget_password", Description = "this method return password")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void forget_password(string email)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            sha ss = new sha();
            string Message = null;
            int id = 0;
            int new_password = 0;
            int result = 0;
            try
            {
                SqlDataReader reader;
              
                SqlCommand cmd = new SqlCommand("SELECT email,customer_id FROM customer Where email='"+ email +"'", dbc.conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandType = CommandType.Text;                                                                        
                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(1);
                }
               // reader.Close();
                dal.dbc.conn.Close();
                 new_password = id * 3456;
            
                //في كلاس send في ملف help  
               // string oldpass = ss.SHA510(new_password);

                string sql = "update customer  set password ='" + new_password + "' where email='" + email + "' ";
                SqlCommand cmd2 = new SqlCommand(sql, dbc.conn);
                  dal.dbc.conn.Open();
                result = cmd2.ExecuteNonQuery();
                dal.dbc.conn.Close();
                if (result != 0)
                    Message = "check your mail send new password";
                else
                    Message = "Please enter correct mail";

            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Message = "Please enter ";
            }

            var jsonData = new
            {
                message = Message,
                new_pass= new_password
            };
            Context.Response.Write( sr.Serialize(jsonData));
        }      
        [WebMethod(MessageName = "add_fav", Description = "this method add  favorate to costomer")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void add_fav(int customer_id, int offer_id = 0, int news_id = 0)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();

            string mess = "";
            int result = 0;
            string sql = "";
            DataTable rt1 = new DataTable();
            try
            {
                if (offer_id != 0)
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("select customerfav_id,offerfav_id from fav where customerfav_id = " + customer_id + "and offerfav_id=" + offer_id + "", dbc.conn);
                    adapter.Fill(rt1);
                    if (rt1 != null && rt1.Rows.Count > 0)
                    {
                        mess = "fav already exists";
                        result = 0;
                    }
                    else
                    {
                        sql = "insert into fav (customerfav_id,offerfav_id) values (" + customer_id + "," + offer_id + ")";
                    }
                }
                    if (news_id != 0)
                    {
                        SqlDataAdapter adapter2 = new SqlDataAdapter("select customerfav_id,newsfav_id from fav where customerfav_id = " + customer_id + "and newsfav_id=" + news_id + "", dbc.conn);
                        adapter2.Fill(rt1);
                        if (rt1 != null && rt1.Rows.Count > 0)
                        {
                            mess = "fav already exists";
                            result = 0;
                        }
                        else
                        {
                            sql = "insert into fav (customerfav_id,newsfav_id) values (" + customer_id + "," + news_id + ")";
                        }
                    }
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                dal.dbc.conn.Open();
                result = cmd.ExecuteNonQuery();
                dal.dbc.conn.Close();
                if (result > 0)
                    mess = "add fav to succ";
                else
                    mess = "try again";
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            var jsonData = new
            {
                Message = mess

            };
            Context.Response.Write( sr.Serialize(jsonData));
        }

        [WebMethod(MessageName = "remove_fav", Description = "this method remove  favorate ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void remove_fav(int fav_id)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            int result = 0;
            string mess = "remove faild";
            try
            {
                string sql = "delete from fav where fav_id= " + fav_id + "";
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                dal.dbc.conn.Open();
                result = cmd.ExecuteNonQuery();
                dal.dbc.conn.Close();
                if (result != 0)
                    mess = "remove succ";
                else mess = "try again";
            }

            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            var jsonData = new
            {
                Message = mess

            };
            Context.Response.Write( sr.Serialize(jsonData));
        }

        [WebMethod(MessageName = "select_id_fav", Description = "this method allow know id_fav")]

        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void select_fav(int customer_id, int offer_id = 0, int news_id = 0)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            int id = 0;
            string Message = "";

            try
            {
                SqlDataReader reader;
                string sql = "select fav_id from fav where customerfav_id=" + customer_id + "";
                if (offer_id != 0)
                    sql = sql + " and offerfav_id=" + offer_id + " ";
                if (news_id != 0)
                    sql = sql + "and newsfav_id=" + news_id + " ";
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                if (id == 0)
                {
                    Message = " costomer_id or offer_id or news_id  is in correct";
                }
                else
                    Message = " succ";
                reader.Close();
                dal.dbc.conn.Close();
            }
            catch (Exception ex)
            {
                Message = " cannot access to the data";
                dal.dbc.conn.Close();
            }
            var jsonData = new
            {
                message = Message,
                Id = id
            };
            Context.Response.Write( sr.Serialize(jsonData));
        }

        [WebMethod(MessageName = "add_childbrith", Description = "this method add  children and childbrith")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void add_childbrith(int customerch_id, string name_baby, string brith_day)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();


            string mess = "";
            int result = 0;
            try
            {
                string sql = "insert into children_brith (customerch_id,name_baby,brith_day) values (" + customerch_id + ",'" + name_baby + "','" + brith_day + "')";
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                dal.dbc.conn.Open();
                result = cmd.ExecuteNonQuery();
                dal.dbc.conn.Close();
                if (result != 0)
                    mess = "add succ";
                else
                    mess = "try agen";
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                //   Message = "Please enter correct Current password";
            }

            var jsonData = new
            {
                message = mess
            };
            Context.Response.Write( sr.Serialize(jsonData));
        }

        [WebMethod(MessageName = "add_comment_from_user", Description = "this method add comments and evaluation")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void add_comment(int customercom_id, string comment, DateTime history, int star=0, int agent_id = 0, int offer_id = 0)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            string mess = "";
            int result = 0;
            string sql = "";
            try
            {
                if (agent_id != 0)
                    sql = "insert into comments (customercom_id,star,comment,history,agent_id) values (" + customercom_id + "," + star + ",'" + comment + "','" + history + "'," + agent_id + ")";
                else if (offer_id != 0)
                    sql = "insert into comments (customercom_id,star,comment,history,offer_id) values (" + customercom_id + "," + star + ",'" + comment + "','" + history + "'," + offer_id + ")";
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                dal.dbc.conn.Open();
                result = cmd.ExecuteNonQuery();
                dal.dbc.conn.Close();
                if (result > 0)
                    mess = "Comment and evaluation under processing";
                else
                    mess = "not send";
            }

            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                mess = "error";
            }

            var jsonData = new
            {
                message = mess
            };
            Context.Response.Write( sr.Serialize(jsonData));
        }

        [WebMethod(MessageName = "return_comment", Description = "this method return comment to customer ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        // public string getdata_comment(int customer_id, int agent_id = 0, int offer_id = 0)
        public void getdata_comment(int agent_id = 0, int offer_id = 0)
        {
            List<aa> xxx = new List<aa>();
            string sql = null;
            JavaScriptSerializer sr = new JavaScriptSerializer();
          
                SqlDataReader reader;
            if(agent_id !=0)
            sql = "select customercom_id,email,comment_id,history,agent_id,comment from comment_ok,customer where agent_id="+agent_id+ " and customercom_id=customer_id";
          else  if(offer_id !=0)
                sql = "select customercom_id,email,comment_id,history,offer_id,comment,star from comment_ok,customer where offer_id="+offer_id+ " and customercom_id=customer_id";

            SqlCommand cmd = new SqlCommand(sql, dbc.conn);

                dal.dbc.conn.Open();

                reader = cmd.ExecuteReader();
               
                    while (reader.Read())
                    {
                        aa aaa = new aa();
                        
                aaa.customercom_id = Convert.ToInt32(reader["customercom_id"]);
                aaa.comment_id = Convert.ToInt32(reader["comment_id"]);
                aaa.agent_id = Convert.ToInt32(reader["agent_id"]);
                aaa.offer_id = Convert.ToInt32(reader["offer_id"]);
                aaa.star = Convert.ToInt32(reader["star"]);
                aaa.history = Convert.ToDateTime(reader["history"]);
                aaa.email = reader["email"].ToString();
                aaa.comment = reader["comment"].ToString();  
                xxx.Add(aaa);
                    }  
                dal.dbc.conn.Close();
                     
            Context.Response.Write(sr.Serialize(xxx));
        }

        [WebMethod(MessageName = "add_suggest", Description = "add suggest for agent ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void add_suggest(int customersugg_id, string nameagent, string phoneage, string emailage, string customer_phone, string customer_email)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            int result = 0;
            string mess = "";
            try
            {
                string sql = "insert into suggestions (customersugg_id,name,phone,email,customer_phone,customer_emil) values (" + customersugg_id + ",'" + nameagent + "','" + phoneage + "','" + emailage + "','" + customer_phone + "','" + customer_email + "')";
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                dal.dbc.conn.Open();
                result = cmd.ExecuteNonQuery();
                dal.dbc.conn.Close();
                if (result > 0)
                    mess = "add suggest to succ";
                else
                    mess = "try again";
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            var jsonData = new
            {
                Message = mess

            };
            Context.Response.Write( sr.Serialize(jsonData));

        }
        [WebMethod(MessageName = "add_complaint", Description = "add complaint  ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void add_complaint( int customercomp_id, string email, string complaint)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            int result = 0;
            string mess = "";
            try
            {
                string sql = "insert into complaints (customercomp_id,email,complaint) values (" + customercomp_id + ",'" + email + "','" + complaint + "')";
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                dal.dbc.conn.Open();
                result = cmd.ExecuteNonQuery();
                dal.dbc.conn.Close();
                if (result > 0)
                    mess = "add suggest to succ";
                else
                    mess = "try again";
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            var jsonData = new
            {
                Message = mess

            };
            Context.Response.Write( sr.Serialize(jsonData));


        }


        [WebMethod(MessageName = "getdata_evalution_agent", Description = "this method return evalution to customer ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void getdata_evalute(int agent_id,int customer_id)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            int star = 0;
            int ag = 0;
            string comm = null;
            string sql = "";
            try
            {
                SqlDataReader reader;
                sql = "select star,agent_id from comment where agent_id =" + agent_id + " and star!=0 and customercom_id="+customer_id+" ";
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                cmd.CommandType = CommandType.Text;
                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        star = reader.GetInt32(0);
                        ag = reader.GetInt32(1);
                    }
                }
                reader.Close();
                dal.dbc.conn.Close();
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            var jsonData = new
            {
                star = star,
                agent_id = ag
            };
            Context.Response.Write(sr.Serialize(jsonData));
        }

        [WebMethod(MessageName = "getdata_newsfav", Description = "this method return news fav to customer ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void getdata_newsfav(int customer_id)
        {
            
            JavaScriptSerializer sr = new JavaScriptSerializer();
            List<favnews> hot = new List<favnews>();
            string sql = "";
            try
            {
                SqlDataReader reader;
                sql = "select fav_id,t_news,news.agent_id,news_name,new_id,news.url,name from fav,news,agent where customerfav_id ="+customer_id+" and newsfav_id=new_id and agent.agent_id=news.agent_id ";
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
               // cmd.CommandType = CommandType.Text;
                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();
               
                    while (reader.Read())
                    {
                        favnews h = new favnews();
                        h.text_news = reader["t_news"].ToString();
                        h.agent_id = Convert.ToInt32(reader["agent_id"]);
                        h.fav_id = Convert.ToInt32(reader["fav_id"]);
                        h.news_id = Convert.ToInt32(reader["new_id"]);
                        h.news_name = reader["news_name"].ToString();
                        h.url_picture=reader["url"].ToString();
                    h.agent_name = reader["name"].ToString();
                    hot.Add(h);
                    }
               
                reader.Close();
                dal.dbc.conn.Close();
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

           
            Context.Response.Write( sr.Serialize(hot));
        }

        [WebMethod(MessageName = "getdata_offerfav", Description = "this method return offers fav to customer ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void getdata_offerfav(int customer_id)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            List<offerfav> hot = new List<offerfav>();
            int id = 0;
            string name = null;
            decimal dis = 0;
            string sql = "";
            byte[] imgdata = null;
            try
            {
                SqlDataReader reader;
                sql = "select fav_id,offers.descr,agentoff_id,offer_name,start_time,end_time,offer_id,offers.url,name from fav,offers,agent where customerfav_id =" + customer_id + " and offerfav_id=offer_id and agentoff_id=agent_id ";

                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
              //  cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    offerfav h = new offerfav();
                    h.offer_name = reader["offer_name"].ToString();
                    h.agent_id = Convert.ToInt32(reader["agentoff_id"]);
                    h.fav_id = Convert.ToInt32(reader["fav_id"]);
                    h.offer_id = Convert.ToInt32(reader["offer_id"]);
                  //  h.time = Convert.ToInt32(reader["time"]);
                    h.descr = reader["descr"].ToString();
                    h.url = reader["url"].ToString();
                    h.agent_name = reader["name"].ToString();
                    //    h.start_time = Convert.ToDateTime(reader["start_time"]);
                    //    h.end_time = Convert.ToDateTime(reader["end_time"]);
                    //  h.image = (byte[])reader.GetValue(1);
                    hot.Add(h);

                }

                reader.Close();
                dal.dbc.conn.Close();
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            var jsonData = new
            {
                fav_id = id,
                name_offer = name,
                discount = dis,
                picture = imgdata
            };
            Context.Response.Write( sr.Serialize(hot));
        }


        [WebMethod(MessageName = "getdata_advert", Description = "this method return advert to customer ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void getdata_advert(int customer_id)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            int id = 0;
            string adv = null;
            string t = null;
            string per = null;
            byte[] imgdata = null;
            string url = null;
            try
            {
                SqlDataReader reader;
                string sql = "select cus_adv.advert_id,advert,time,period,picture,url from cus_adv,advert where cus-adv.advert_id=advert.advert_id and cus_adv.customer_id =" + customer_id + "";

                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                    adv = reader.GetString(1);
                    t = reader.GetString(2);
                    per = reader.GetString(3);
                    imgdata = (byte[])reader.GetValue(4);
                    url= reader.GetString(5);
                }

                reader.Close();
                dal.dbc.conn.Close();
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            var jsonData = new
            {
                advert_id = id,
                advert = adv,
                time = t,
                period = per,
                picture = imgdata
            };
            Context.Response.Write( sr.Serialize(jsonData));
        }


        [WebMethod(MessageName = "add_tracking", Description = "add tracing for customer ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void add_trac(int customer_id, string pagename, DateTime time)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            int result = 0;
            string mess = "";
            try
            {
                string sql = "insert into Tracking (customertrac_id,pagename,time) values (" + customer_id + ",'" + pagename + "','" + time + "')";
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                dal.dbc.conn.Open();
                result = cmd.ExecuteNonQuery();
                dal.dbc.conn.Close();
                if (result > 0)
                    mess = "add track to succ";
                else
                    mess = "try again";
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            var jsonData = new
            {
                Message = mess

            };
            Context.Response.Write( sr.Serialize(jsonData));

        }

        [WebMethod(MessageName = "getdata_hotoffer", Description = "this method return hot offers to customer ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void getdata_hotoffer()
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            List<hotoffer> hot = new List<hotoffer>();              
             
            try
            {
                SqlDataReader reader;
                string sql = "select hot_name,picture,hot_text,url from hot_offer  ";

                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
               // cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    hotoffer h = new hotoffer();
                    h.name = reader["hot_name"].ToString();
                    h.image = (byte[])reader.GetValue(1);
                    h.text = reader["hot_text"].ToString();
                    h.url_picture = reader["url"].ToString();
                    hot.Add(h);
                }

                reader.Close();
                dal.dbc.conn.Close();
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

          /*  var jsonData = new
            {
                name_hotoffer = name,
                picture = imgdata
            };*/
            Context.Response.Write( sr.Serialize(hot));
        }

        [WebMethod(MessageName = "getdata_hoteventheadr", Description = "this method return hot event header to customer ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void getdata_hoteventheader()
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            List<hoteventhead> hot = new List<hoteventhead>();
            
            try
            {
                SqlDataReader reader;
                string sql = "select hotevent_id,descr,picture,url from hot_event  ";

                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
               // cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    hoteventhead h = new hoteventhead();
                    h.id= Convert.ToInt32(reader["hotevent_id"]);
                    h.name = reader["descr"].ToString();
                   h.image = (byte[])reader.GetValue(2);
                    h.url = reader["url"].ToString();
                    hot.Add(h);
                }

                reader.Close();
                dal.dbc.conn.Close();
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

          /*  var jsonData = new
            {
                hotevent_id = id,
                name_hotevent = name,
                picture = imgdata
            };*/
            Context.Response.Write( sr.Serialize(hot));
        }
    
        [WebMethod(MessageName = "getdata_hotevent", Description = "this method return hot event dtails to customer ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void getdata_hotevent(int hotevent_id)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            string nam = null;
            string pho = null;
            int buy = 0;
            decimal la = 0;
            decimal lo = 0;
           string mess=null;
            string add = null;
            string hot_text = null;
            string url = null;
            try
            {
                SqlDataReader reader;
                string sql = "select descr,hot_text,url,latitude,longitude from hot_event where hot_event.hotevent_id= " + hotevent_id +" ";

                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    nam = reader.GetString(0);
                    la= Convert.ToDecimal(reader["latitude"]);
                    lo = Convert.ToDecimal(reader["longitude"]);
                    hot_text = reader.GetString(1);
                    url = reader.GetString(2);
                }

                reader.Close();
                dal.dbc.conn.Close();

             /*   if (buy == 0)
                    mess = "non buy ";
                else if (buy == 1)
                    mess = " buy to paypal ";
                else if (buy == 2)
                    mess = " buy to cridit card ";
                else if (buy == 3)
                    mess = " buy to phone ";*/
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            var jsonData = new
            {
                name = nam,
                hotevent_text = hot_text,
                latitude = la,
                longitude = lo,
                url_picture=url
            };
            Context.Response.Write( sr.Serialize(jsonData));
        }

        [WebMethod(MessageName = "getdata_hoteventpicture", Description = "this method return hot event dtails to customer ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void getdata_hoteventpicture(int hotevent_id)//التعديل على جملة السيلكت 
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            List<hotevent> hot = new List<hotevent>();
           
          
            string mess = null;
           // string add = null;
            try
            {
                SqlDataReader reader;
                string sql = "select picture,url from picture where hoteventpc_id = "+ hotevent_id +"";

                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
              //  cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    hotevent h = new hotevent();
                    h.image = (byte[])reader.GetValue(0);
                    h.url = reader["url"].ToString();
                    hot.Add(h);
                    //add = reader.GetString(4);
                }

                reader.Close();
                dal.dbc.conn.Close();

              
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

          /*  var jsonData = new
            {
                picture=imgdata
                //type_buy = mess
            };*/
            Context.Response.Write( sr.Serialize(hot));
        }



        [WebMethod(MessageName = "getdata_customer", Description = "this method return  dtails  customer ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void getdata_customer(int customer_id) 
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            string email = null;
            string facebok = null;
            string googl = null;
            string twiter1 = null;
            string phone = null;
            string nation = null;
            string addres = null;
            DateTime brith = default(DateTime);
            DateTime marr = default(DateTime);
            string gende = null;
            int ag = 0;
            try
            {
                SqlDataReader reader;
                string sql = "select email,facebook,google,twiter,phone,nationality,address,brith_day,marriage_date,gender,age from customer where customer.customer_id= " + customer_id + " ";

                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    email = reader.GetString(0);
                //    facebok = reader.GetString(1);
                  //  googl = reader.GetString(2);
                   // twiter1 = reader.GetString(3);
                    phone = reader.GetString(4);
                    nation = reader.GetString(5);
                    addres = reader.GetString(6);
                    brith = reader.GetDateTime(7);
                    marr = reader.GetDateTime(8);
                    gende = reader.GetString(9);
                    ag = reader.GetInt32(10);
                }

                reader.Close();
                dal.dbc.conn.Close();

               
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

                   
                var jsonData = new
                {
                    usernam = email,
                    phone = phone,
                    nationality = nation,
                    addrss = addres,
                    brith_day = brith,
                    marriage_dat = marr,
                    gender = gende,
                    age = ag

                };
                Context.Response.Write( sr.Serialize(jsonData));
            

        }


        [WebMethod(MessageName = "getdata_customer_face", Description = "this method return  dtails  customer ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void getdata_customer_face(int customer_id)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            string email = null;
            string facebok = null;
            string googl = null;
            string twiter1 = null;
            string phone = null;
            string nation = null;
            string addres = null;
            DateTime brith = default(DateTime);
            DateTime marr = default(DateTime);
            string gende = null;
            int ag = 0;
            try
            {
                SqlDataReader reader;
                string sql = "select email,facebook,google,twiter,phone,nationality,address,brith_day,marriage_date,gender,age from customer where customer.customer_id= " + customer_id + " ";

                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                  //  email = reader.GetString(0);
                    facebok = reader.GetString(1);
                    //  googl = reader.GetString(2);
                    // twiter1 = reader.GetString(3);
                    phone = reader.GetString(4);
                    nation = reader.GetString(5);
                    addres = reader.GetString(6);
                    brith = reader.GetDateTime(7);
                    marr = reader.GetDateTime(8);
                    gende = reader.GetString(9);
                    ag = reader.GetInt32(10);
                }

                reader.Close();
                dal.dbc.conn.Close();


            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }


            var jsonData = new
            {
                usernam = facebok,
                phone = phone,
                nationality = nation,
                addrss = addres,
                brith_day = brith,
                marriage_dat = marr,
                gender = gende,
                age = ag

            };
            Context.Response.Write(sr.Serialize(jsonData));


        }


        [WebMethod(MessageName = "add_online", Description = "add  customer online ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void add_online(int customer_id,bool state)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            int result = 0;
            string mess = "";
            if (state == true)
            {
                try
                {
                    string sql = "insert into online (customertr_id,online) values (" + customer_id + "," + state + ")";
                    SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                    dal.dbc.conn.Open();
                    result = cmd.ExecuteNonQuery();
                    dal.dbc.conn.Close();
                    if (result > 0)
                        mess = "add online to succ";
                    else
                        mess = "try again";
                }
                catch (Exception ex)
                {

                    dal.dbc.conn.Close();
                }
            }

            if (state == false)
            {
                try
                {
                    string sql = "delete from online where customer_id="+ customer_id +"";
                    SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                    dal.dbc.conn.Open();
                    result = cmd.ExecuteNonQuery();
                    dal.dbc.conn.Close();
                    if (result > 0)
                        mess = "add logoff to succ";
                    else
                        mess = "try again";
                }
                catch (Exception ex)
                {

                    dal.dbc.conn.Close();
                }
            }

            var jsonData = new
            {
                Message = mess

            };
            Context.Response.Write( sr.Serialize(jsonData));

        }

        [WebMethod(MessageName = "add_trace_login", Description = "add  customer login ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void add_trace_login(int customer_id, DateTime date)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            int result = 0;
            string mess = "";
            DataTable rt1 = new DataTable();
            
               
                try
                {
                    string sql = "insert into online (customertr_id,date) values (" + customer_id + ",'" + date + "')";
                    SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                    dal.dbc.conn.Open();
                    result = cmd.ExecuteNonQuery();
                    dal.dbc.conn.Close();
                    if (result > 0)
                        mess = "add trace to succ";
                    else
                        mess = "try again";
                }
                catch (Exception ex)
                {

                    dal.dbc.conn.Close();
                }
            

           

            var jsonData = new
            {
                Message = mess

            };
            Context.Response.Write( sr.Serialize(jsonData));

        }



        [WebMethod(MessageName = "getdata_notification", Description = "this method return notification to customer ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void getdata_notification(int customer_id)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            int id = 0;
            string name = null;
            int not = 0;
            int imgdata = 0;
            try
            {
                SqlDataReader reader;
                string sql = "select name,offernot,newsnot,id from notification,flow,agent where agentnot_id=agentf_id and agentf_id=agent_id and customerf_id= "+ customer_id +"  ";

                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id = reader.GetInt32(1);
                    name = reader.GetString(0);
                    imgdata = reader.GetInt32(2);
                    not = reader.GetInt32(3);
                }

                reader.Close();
                dal.dbc.conn.Close();
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            var jsonData = new
            {
                notification_id=not,
               offer = id,
                agent_name = name,
                news = imgdata
            };
            Context.Response.Write(sr.Serialize(jsonData));
        }

        [WebMethod(MessageName = "getdata_new_offer_or_news", Description = "this method return offer after notification ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void getdata_newoffer_or_news(int offer_id=0,int news_id=0)//لاحقا لازم مسح النوتفكيشن
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            //  int id = 0;
            string name = null;
            string offer = null;
            decimal d = 0;
            int t = 0;
            DateTime s = default(DateTime);
            DateTime e = default(DateTime);
            byte[] imgdata = null;
            string newss = null;
            string sql = null;
            int id = 0;
            try
            {
                SqlDataReader reader;
                if (news_id !=0 )
                    sql = "select name,t_news,agent_id from agent,news where news.agent_id=agent.agent_id and news_id="+news_id+" ";
                else
                    if(offer_id !=0)
                    sql = "select name,offer_name,discount,time,start_time,end_time,picture,agent_id from agent,offers,picture where agentoff_id=agent_id  and offerpc_id= offer_id and offer_id="+offer_id+"";

                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();
                if (news_id != 0)
                {
                    while (reader.Read())
                    {
                        name = reader.GetString(0);
                        newss = reader.GetString(1);
                        id = reader.GetInt32(2);
                    }
                }
                else
                if (offer_id != 0)
                {
                    while (reader.Read())
                    {
                        name = reader.GetString(0);
                        offer = reader.GetString(1);
                        d = reader.GetDecimal(2);
                        t = reader.GetInt32(3);
                        s = reader.GetDateTime(4);
                        e = reader.GetDateTime(5);
                        imgdata = (byte[])reader.GetValue(6);
                        id = reader.GetInt32(7);
                    }

                }
                reader.Close();
                dal.dbc.conn.Close();
            }


            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            if (news_id != 0)
            {
                var jsonData = new
                {
                    agent_name = name,
                    news = newss,
                    agent_id=id
                };
                Context.Response.Write(sr.Serialize(jsonData));
            }
            else
            if (offer_id != 0)
            { 
                var jsonData = new
                {
                    agent_name = name,
                    offer_name = offer,
                    discount = d,
                    time = t,
                    start_time = s,
                    end_time = e,
                    picture = imgdata,
                    agent_id = id
                };
                Context.Response.Write(sr.Serialize(jsonData));
            }
            
        }


        [WebMethod(MessageName = "add_customer_entered_advert", Description = "add the customer entered advert ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void add_entered_advert(int customer_id,int advert_id,int n_of_second, DateTime date)//كل مايدخل الزبون الاعلان تستدعية 
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            int result = 0;
            string mess = "";
            DataTable rt1 = new DataTable();

           
            
                try
                {
                    string sql = "insert into statistic_advert (advertstat_id,customerstat_id,n_of_second,date) values (" + advert_id + "," + customer_id + "," + n_of_second+ ",'"+ date +"')";
                    SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                    dal.dbc.conn.Open();
                    result = cmd.ExecuteNonQuery();
                    dal.dbc.conn.Close();
                    if (result > 0)
                        mess = "add trace to succ";
                    else
                        mess = "try again";
                }
                catch (Exception ex)
                {

                    dal.dbc.conn.Close();
                }
            



            var jsonData = new
            {
                Message = mess

            };
            Context.Response.Write(sr.Serialize(jsonData));

        }

        [WebMethod(MessageName = "add_customer_entered_news", Description = "add the customer entered news ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void add_entered_news(int customer_id, int news_id, int n_of_second)//كل مايدخل الزبون الاعلان تستدعية 
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            int result = 0;
            string mess = "";
           



            try
            {
                string sql = "insert into statistic_news (newsstat_id,customerstat_id,n_of_second) values (" + news_id + "," + customer_id + "," + n_of_second + ")";
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                dal.dbc.conn.Open();
                result = cmd.ExecuteNonQuery();
                dal.dbc.conn.Close();
                if (result > 0)
                    mess = "add trace to succ";
                else
                    mess = "try again";
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }




            var jsonData = new
            {
                Message = mess

            };
            Context.Response.Write(sr.Serialize(jsonData));

        }
        [WebMethod(MessageName = "add_customer_entered_notification", Description = "add the customer entered notification ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void add_entered_notification(int customer_id, int notification_id, int n_of_second)//كل مايدخل الزبون الاعلان تستدعية 
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            int result = 0;
            string mess = "";




            try
            {
                string sql = "insert into statistic_notification (notification_id,customerstat_id,n_of_second) values (" + notification_id + "," + customer_id + "," + n_of_second + ")";
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                dal.dbc.conn.Open();
                result = cmd.ExecuteNonQuery();
                dal.dbc.conn.Close();
                if (result > 0)
                    mess = "add trace to succ";
                else
                    mess = "try again";
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }




            var jsonData = new
            {
                Message = mess

            };
            Context.Response.Write(sr.Serialize(jsonData));

        }

        [WebMethod(MessageName = "add_customer_posted_offer_and_advert", Description = "add the customer posted_offer and advert ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void add_posted_offer(int customer_id, int offer_id=0, int advert_id=0)//كل ماينشر الزبون العرض او الاعلان  
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            int result = 0;
            string mess = "";




            try
            {
                string sql = "insert into post_offer_news (customerp_id,offerp_id,advertp_id) values (" + customer_id + "," + offer_id + "," + advert_id + ")";
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                dal.dbc.conn.Open();
                result = cmd.ExecuteNonQuery();
                dal.dbc.conn.Close();
                if (result > 0)
                    mess = "add trace to succ";
                else
                    mess = "try again";
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }




            var jsonData = new
            {
                Message = mess

            };
            Context.Response.Write(sr.Serialize(jsonData));

        }

        [WebMethod(MessageName = "add_customer_entered_offer", Description = "add the customer entered news ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void add_entered_offer(int customer_id, int offer_id, DateTime date)//كل مايدخل الزبون الاعلان تستدعية 
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            int result = 0;
            string mess = "";




            try
            {
                string sql = "insert into statistic_offer(offerstat_id,customerstat_id,date) values (" + offer_id + "," + customer_id + ",'" + date + "')";
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                dal.dbc.conn.Open();
                result = cmd.ExecuteNonQuery();
                dal.dbc.conn.Close();
                if (result > 0)
                    mess = "add trace to succ";
                else
                    mess = "try again";
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }




            var jsonData = new
            {
                Message = mess

            };
            Context.Response.Write(sr.Serialize(jsonData));

        }



        [WebMethod(MessageName = "getdata_offers", Description = "this method return  offers to customer ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void getdata_offers(int customer_id)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            List<offers> offer = new List<offers>();

            try
            {
                SqlDataReader reader;
                string sql = "select offer_id,agentoff_id,name,offer_name,offers.descr,start_time,end_time,offers.url from offers,flow,agent where customerf_id="+ customer_id + " and agentf_id=agentoff_id and agentf_id=agent_id ";

                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
              //  cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    offers h = new offers();
                    h.offer_name = reader["offer_name"].ToString();
                    h.offer_id = Convert.ToInt32(reader["offer_id"]);
                    h.agent_id = Convert.ToInt32(reader["agentoff_id"]);
                    h.descr = reader["descr"].ToString();
                    h.url = reader["url"].ToString();
                    //  h.time = Convert.ToInt32(reader["time"]);
                    //   h.start_time = Convert.ToDateTime(reader["start_time"]);
                    //  h.end_time = Convert.ToDateTime(reader["end_time"]);
                    h.agent_name = reader["name"].ToString();

                    offer.Add(h);
                }

                reader.Close();
                dal.dbc.conn.Close();
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            /*  var jsonData = new
              {
                  name_hotoffer = name,
                  picture = imgdata
              };*/
            Context.Response.Write(sr.Serialize(offer));
        }


        [WebMethod(MessageName = "getdata_offerpictur", Description = "this method return offer picture to customer ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void getdata_offerpicture(int offer_id) 
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            List<hotevent> hot = new List<hotevent>();


            string mess = null;
            // string add = null;
            try
            {
                SqlDataReader reader;
                string sql = "select picture,url from picture where offerpc_id = " + offer_id + "";

                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    hotevent h = new hotevent();
                    h.image = (byte[])reader.GetValue(0);
                    h.url = reader["url"].ToString();
                    hot.Add(h);
                    //add = reader.GetString(4);
                }

                reader.Close();
                dal.dbc.conn.Close();


            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            /*  var jsonData = new
              {
                  picture=imgdata
                  //type_buy = mess
              };*/
            Context.Response.Write(sr.Serialize(hot));
        }

        [WebMethod(MessageName = "getdata_news", Description = "this method return news dtails to customer ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void getdata_news(int customer_id)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            List<news> offer = new List<news>();

            try
            {
                SqlDataReader reader;
                string sql = "select news.agent_id,t_news,news_name,new_id,name,picture,cat_id,news.url from news,flow,agent where customerf_id=" + customer_id + " and agentf_id=news.agent_id and agent.agent_id=news.agent_id  order by new_id desc";

                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                //  cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    news h = new news();
                    h.news_id = Convert.ToInt32(reader["new_id"]);
                    h.news_name = reader["news_name"].ToString();
                    h.agent_id = Convert.ToInt32(reader["agent_id"]);
                    h.text_news = reader["t_news"].ToString();
                    h.agent_name = reader["name"].ToString();
                    h.image = (byte[])reader.GetValue(5);
                    h.url_picture = reader["url"].ToString();
                    offer.Add(h);
                }

                reader.Close();
                dal.dbc.conn.Close();
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            /*  var jsonData = new
              {
                  name_hotoffer = name,
                  picture = imgdata
              };*/
            Context.Response.Write(sr.Serialize(offer));
        }

        [WebMethod(MessageName = "getdata_category", Description = "this method return category dtails to customer ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void categories( )
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            List<catgory> offer = new List<catgory>();

            try
            {
                SqlDataReader reader;
                string sql = "select cat_id,cat_name from categories";

                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                //  cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    catgory h = new catgory();
                    h.name = reader["cat_name"].ToString();
                    h.id = Convert.ToInt32(reader["cat_id"]);
                   
                    offer.Add(h);
                }

                reader.Close();
                dal.dbc.conn.Close();
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            /*  var jsonData = new
              {
                  name_hotoffer = name,
                  picture = imgdata
              };*/
            Context.Response.Write(sr.Serialize(offer));
        }

        [WebMethod(MessageName = "getdata_sub_category", Description = "this method return sub_category dtails to customer ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void sub_categories(int category_id)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            List<sub_cat> offer = new List<sub_cat>();

            try
            {
                SqlDataReader reader;
                string sql = "select sub_id,catsub_name,url from sub_categorie where catsub_id=" + category_id + "";

                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                //  cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    sub_cat h = new sub_cat();
                    h.cat_sub_name = reader["catsub_name"].ToString();
                    h.cat_sub_id = Convert.ToInt32(reader["sub_id"]);
                    h.url = reader["url"].ToString();
                    offer.Add(h);
                }

                reader.Close();
                dal.dbc.conn.Close();
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            /*  var jsonData = new
              {
                  name_hotoffer = name,
                  picture = imgdata
              };*/
           Context.Response.Write(sr.Serialize(offer));
       }


        [WebMethod(MessageName = "getdata_agent", Description = "this method return agent dtails  ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void getdata_agent(int category_id,int subcategory_id)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            List<agent> offer = new List<agent>();
            string sql = null;
          
            try
            {
                SqlDataReader reader;
                if(subcategory_id !=0)
             sql    = "select agent_id,name,phone,address,city,descr,urla,latitude,longitude from agent where cat_id=" + category_id + " and sub_id="+ subcategory_id+" ";
                else
                    sql = "select agent_id,name,phone,address,city,descr,urla,latitude,longitude from agent where cat_id=" + category_id + " ";
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                  cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    agent h = new agent();
                    h.name = reader["name"].ToString();
                   h.agent_id = Convert.ToInt32(reader["agent_id"]);
                   string phone = reader["phone"].ToString();
                    h.address = reader["address"].ToString();
                    h.city = reader["city"].ToString();
                   h.descr = reader["descr"].ToString();
                    h.url= reader["urla"].ToString();
                    h.latitude = Convert.ToDecimal(reader["latitude"]);
                    h.longitude = Convert.ToDecimal(reader["longitude"]);
                    offer.Add(h);
                }

                reader.Close();
                dal.dbc.conn.Close();
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            /*  var jsonData = new
              {
                  name_hotoffer = name,
                  picture = agent_id
              };*/
            Context.Response.Write(sr.Serialize(offer));
        }

        [WebMethod(MessageName = "getdata_branches_agent", Description = "this method return branches agent dtails  ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void branches_agent(int agent_id)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            List<branches_agent> offer = new List<branches_agent>();

            try
            {
                SqlDataReader reader;
                string sql = "select branch_name,phone,latitude,longitude from branches_agent where agentch_id=" + agent_id + "";

                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                //  cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    branches_agent h = new branches_agent();
                    h.branch_name = reader["branch_name"].ToString();
                    h.phone = reader["phone"].ToString();
                    h.latitude = Convert.ToDecimal(reader["latitude"]);
                    h.longitude = Convert.ToDecimal(reader["longitude"]);
                    offer.Add(h);
                }

                reader.Close();
                dal.dbc.conn.Close();
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            /*  var jsonData = new
              {
                  name_hotoffer = name,
                  picture = imgdata
              };*/
            Context.Response.Write(sr.Serialize(offer));
        }

        [WebMethod(MessageName = "getdata_offers_agent", Description = "this method return  offers to customer ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void getdata_offers_agent(int agent_id)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            List<offers> offer = new List<offers>();

            try
            {
                SqlDataReader reader;
                string sql = "select offer_id,offer_name,descr,start_time,end_time,url from offers where agentoff_id=" + agent_id + " ";

                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                //  cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    offers h = new offers();
                    h.offer_name = reader["offer_name"].ToString();
                    h.offer_id = Convert.ToInt32(reader["offer_id"]);
                   // h.agent_id = Convert.ToInt32(reader["agentoff_id"]);
                    h.descr = reader["descr"].ToString();
                    h.url = reader["url"].ToString();
                    //   h.time = Convert.ToInt32(reader["time"]);
                    //    h.start_time = Convert.ToDateTime(reader["start_time"]);
                    //      h.end_time = Convert.ToDateTime(reader["end_time"]);


                    offer.Add(h);
                }

                reader.Close();
                dal.dbc.conn.Close();
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            /*  var jsonData = new
              {
                  name_hotoffer = name,
                  picture = imgdata
              };*/
            Context.Response.Write(sr.Serialize(offer));
        }


        [WebMethod(MessageName = "getdata_news_agent", Description = "this method return news dtails to customer ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void getdata_news_agent(int agent_id)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            List<news> offer = new List<news>();

            try
            {
                SqlDataReader reader;
                string sql = "select news.agent_id,name,t_news,news_name,news.url,new_id from news,agent where news.agent_id=" + agent_id + " and news.agent_id=agent.agent_id ";

                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                //  cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    news h = new news();
                    h.news_name = reader["news_name"].ToString();
                    h.agent_id = Convert.ToInt32(reader["agent_id"]);
                    h.text_news = reader["t_news"].ToString();
                    h.agent_name = reader["name"].ToString();
                    h.url_picture = reader["url"].ToString();
                    h.news_id = Convert.ToInt32(reader["new_id"]);
                    offer.Add(h);
                }

                reader.Close();
                dal.dbc.conn.Close();
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            /*  var jsonData = new
              {
                  name_hotoffer = name,
                  picture = imgdata
              };*/
            Context.Response.Write(sr.Serialize(offer));
        }


        [WebMethod(MessageName = "add_interests_of_customer", Description = "add the interests of customer ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void add_interests_of_customer(int customer_id,int cat_id)//اضافة اهتمامت الزبون  
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            int result = 0;
            string mess = "";
            DataTable rt1 = new DataTable();



            try
            {
                string sql = "insert into interests_of_customer (customerinterst_id,cat_id) values (" + customer_id + "," + cat_id + ")";
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                dal.dbc.conn.Open();
                result = cmd.ExecuteNonQuery();
                dal.dbc.conn.Close();
                if (result > 0)
                    mess = "add interests to succ";
                else
                    mess = "try again";
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }




            var jsonData = new
            {
                Message = mess

            };
            Context.Response.Write(sr.Serialize(jsonData));

        }

        [WebMethod(MessageName = "add_flow", Description = "add the flow of customer ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void flow(int customer_id, int agent_id)//اضافة اهتمامت الزبون  
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            int result = 0;
            string mess = "";
            DataTable rt1 = new DataTable();



            try
            {
                string sql = "insert into flow (customerf_id,agentf_id) values (" + customer_id + "," + agent_id + ")";
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                dal.dbc.conn.Open();
                result = cmd.ExecuteNonQuery();
                dal.dbc.conn.Close();
                if (result > 0)
                    mess = "add flow to succ";
                else
                    mess = "try again";
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }




            var jsonData = new
            {
                Message = mess

            };
            Context.Response.Write(sr.Serialize(jsonData));

        }
        [WebMethod(MessageName = "getdata_folw", Description = "this method return agent  ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void getdata_folw(int customer_id)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            List<flowagent> flow = new List<flowagent>();

            try
            {
                SqlDataReader reader;
                string sql = "select agent_id,name from flow,agent where customerf_id=" + customer_id + " and agent_id=agentf_id ";

                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                //  cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    flowagent h = new flowagent();
                    h.name = reader["name"].ToString();
                    h.agent_id = Convert.ToInt32(reader["agent_id"]);
                   //h.text_news = reader["t_news"].ToString();
                    flow.Add(h);
                }

                reader.Close();
                dal.dbc.conn.Close();
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            /*  var jsonData = new
              {
                  name_hotoffer = name,
                  picture = imgdata
              };*/
            Context.Response.Write(sr.Serialize(flow));
        }

        [WebMethod(MessageName = "brithday", Description = "congratulations")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void brithday(int customer_id)//  
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            DateTime d = DateTime.Now.Date;
            string m= null;
            int id = 0;
            DateTime b = default(DateTime);
            try
            {
                SqlDataReader reader;
                string sql = "select customer_id,brith_day from customer where customer_id="+customer_id+"";

                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                //  cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    
                     b = Convert.ToDateTime (reader["customer_id"]);
                    id = Convert.ToInt32(reader["customer_id"]);

                    
                }

                reader.Close();
                dal.dbc.conn.Close();
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            DateTime n = b.Date;
            if (n == d)
            { m = "كل سنة وانت بخيير بمناسبة عيد ميلادك "; }
            else m = "nonnnnn";
             var jsonData = new
              {
                  message=m,
                  customer_id=id
              };
            Context.Response.Write(sr.Serialize(jsonData));
        }


        [WebMethod(MessageName = "getdata_offers_based_location", Description = "this method return  offers to customer based location ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void getdata_offers_based_location(double latitude,double longitude)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            List<offers> offer = new List<offers>();
            double maxla = latitude + 0.013;
            double minla = latitude - 0.013;
            double maxlo = longitude + 0.013;
            double minlo = longitude - 0.013;

            try
            {
                SqlDataReader reader;
                string sql = "select offer_id,agentoff_id,name,offer_name,offers.descr,start_time,end_time,offers.url from offers,agent where type=1 and agent_id=agentoff_id and latitude>="+minla+ " and latitude<="+maxla+ " and longitude<="+maxlo+ " and longitude>="+minlo+" ";

                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                //  cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    offers h = new offers();
                    h.offer_name = reader["offer_name"].ToString();
                    h.offer_id = Convert.ToInt32(reader["offer_id"]);
                    h.agent_id = Convert.ToInt32(reader["agentoff_id"]);
                    h.descr = reader["descr"].ToString();
                    //  h.time = Convert.ToInt32(reader["time"]);
                    //   h.start_time = Convert.ToDateTime(reader["start_time"]);
                    //   h.end_time = Convert.ToDateTime(reader["end_time"]);

                    h.url = reader["url"].ToString();
                    offer.Add(h);
                }

                reader.Close();
                dal.dbc.conn.Close();
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            /*  var jsonData = new
              {
                  name_hotoffer = name,
                  picture = imgdata
              };*/
            Context.Response.Write(sr.Serialize(offer));
        }

        [WebMethod(MessageName = "getdata_news_based_location", Description = "this method return  news to customer based location ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void getdata_news_based_location(double latitude, double longitude)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            List<news> offer = new List<news>();
            double maxla = latitude + 0.013;
            double minla = latitude - 0.013;
            double maxlo = longitude + 0.013;
            double minlo = longitude - 0.013;

            try
            {
                SqlDataReader reader;
              
                string sql = "select agent_id,t_news,news_name,new_id,name,url from news,agent where   agent.agent_id=news.agent_id and type=1 and latitude>=" + minla + " and latitude<=" + maxla + " and longitude<=" + maxlo + " and longitude>=" + minlo + " ";               
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                //  cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    news h = new news();
                    h.news_id = Convert.ToInt32(reader["new_id"]);
                    h.news_name = reader["news_name"].ToString();
                    h.agent_id = Convert.ToInt32(reader["agent_id"]);
                    h.text_news = reader["t_news"].ToString();
                    h.url_picture = reader["url"].ToString();

                    offer.Add(h);
                }

                reader.Close();
                dal.dbc.conn.Close();
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            /*  var jsonData = new
              {
                  name_hotoffer = name,
                  picture = imgdata
              };*/
            Context.Response.Write(sr.Serialize(offer));
        }

        [WebMethod(MessageName = "update_customer_location", Description = "this method update location")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void update_customer_location(int customer_id, double latitude, double longitude)
        {
           
            JavaScriptSerializer sr = new JavaScriptSerializer();
            
            string Message = "";
            int result = 0;

            try
            {
                string sql = "update customer  set latitude =" + latitude + ",longitude="+longitude+" where customer_id="+customer_id+" ";
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                dal.dbc.conn.Open();
                result = cmd.ExecuteNonQuery();
                dal.dbc.conn.Close();
                if (result != 0)
                    Message = "location changed Successfully";
                else
                    Message = "Please enter correct location";
            }
            catch (Exception ex)
            {
                dal.dbc.conn.Close();
                Message = "can not access data";
            }

            var jsonData = new
            {
                message = Message
            };
            Context.Response.Write(sr.Serialize(jsonData));
        }


        [WebMethod(MessageName = "check_facebook", Description = "this method login to facebook")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void check_facebook(string email)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            int UserID = 0;
            string Message = "";
           
            try
            {
                SqlDataReader reader;
                string sql = "select customer_id from customer where facebook='" + email + "' ";
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UserID = reader.GetInt32(0);

                }
                if (UserID == 0)
                {
                    Message = " user name  in correct";
                }
                else
                    Message = "login succ";
                reader.Close();

                dal.dbc.conn.Close();


            }
            catch (Exception ex)
            {
                Message = " cannot access to the data";
                dal.dbc.conn.Close();

            }

            var jsonData = new
            {
                id = UserID,
                message = Message
            };
            Context.Response.Write(sr.Serialize(jsonData));
        }


        [WebMethod(MessageName = "getdata_agentpicture", Description = "this method return agent picture to customer ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void getdata_agentpicture(int agent_id)//التعديل على جملة السيلكت 
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            List<hotevent> hot = new List<hotevent>();


            string mess = null;
            // string add = null;
            try
            {
                SqlDataReader reader;
                string sql = "select picture,url from picture where agentpc_id = " + agent_id + "";

                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    hotevent h = new hotevent();
                    h.image = (byte[])reader.GetValue(0);
                    h.url = reader["url"].ToString();
                    hot.Add(h);
                    //add = reader.GetString(4);
                }

                reader.Close();
                dal.dbc.conn.Close();


            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            /*  var jsonData = new
              {
                  picture=imgdata
                  //type_buy = mess
              };*/
            Context.Response.Write(sr.Serialize(hot));
        }

        [WebMethod(MessageName = "getdata_agent_location", Description = "this method return agent location  ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void getdata_agent_location(int category_id)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            List<agentloc> offer = new List<agentloc>();
            string sql = null;

            try
            {
                SqlDataReader reader;
             //   if (subcategory_id != 0)
             //       sql = "select agent_id,name,phone,address,city,descr from agent where cat_id=" + category_id + " and sub_id=" + subcategory_id + " ";
             //   else
                    sql = "select agent_id,name,latitude,longitude from agent where cat_id=" + category_id + " ";
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    agentloc h = new agentloc();
                    h.name = reader["name"].ToString();
                    h.agent_id = Convert.ToInt32(reader["agent_id"]);
                    h.latitude = Convert.ToDecimal(reader["latitude"]);
                    h.longitude = Convert.ToDecimal(reader["longitude"]);
         
                    offer.Add(h);
                }

                reader.Close();
                dal.dbc.conn.Close();
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            /*  var jsonData = new
              {
                  name_hotoffer = name,
                  picture = agent_id
              };*/
            Context.Response.Write(sr.Serialize(offer));
        }


        [WebMethod(MessageName = "getdata_branches_agent_location", Description = "this method return branches agent dtails  ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void branches_agent_loc(int agent_id)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            List<branches_agent> offer = new List<branches_agent>();

            try
            {
                SqlDataReader reader;
                string sql = "select branch_name,phone,latitude,longitude from branches_agent where agentch_id=" + agent_id + "";

                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                //  cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    branches_agent h = new branches_agent();
                    h.branch_name = reader["branch_name"].ToString();
                    h.phone = reader["phone"].ToString();
                    h.latitude = Convert.ToDecimal(reader["latitude"]);
                    h.longitude = Convert.ToDecimal(reader["longitude"]);
                    offer.Add(h);
                }

                reader.Close();
                dal.dbc.conn.Close();
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            /*  var jsonData = new
              {
                  name_hotoffer = name,
                  picture = imgdata
              };*/
            Context.Response.Write(sr.Serialize(offer));
        }

        [WebMethod(MessageName = "remove_flow", Description = "this method remove  flow ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void remove_flow(int customer_id,int agent_id)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            int result = 0;
            string mess = "remove faild";
            try
            {
                string sql = "delete from flow where customerf_id= " + customer_id + " and agentf_id="+agent_id+"";
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                dal.dbc.conn.Open();
                result = cmd.ExecuteNonQuery();
                dal.dbc.conn.Close();
                if (result != 0)
                    mess = "remove succ";
                else mess = "try again";
            }

            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            var jsonData = new
            {
                Message = mess

            };
            Context.Response.Write(sr.Serialize(jsonData));
        }
        [WebMethod(MessageName = "getdata_agentpic", Description = "this method return one agent with picture")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void getdata_agentpic(int agent_id)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            List<agent> offer = new List<agent>();
            string sql = null;

            try
            {
                SqlDataReader reader;
              
                    sql = "select agent_id,name,phone,address,city,descr,urla from agent where agent_id=" + agent_id + " ";
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    agent h = new agent();
                    h.name = reader["name"].ToString();
                    h.agent_id = Convert.ToInt32(reader["agent_id"]);
                    string phone = reader["phone"].ToString();
                    h.address = reader["address"].ToString();
                    h.city = reader["city"].ToString();
                    h.descr = reader["descr"].ToString();
                    h.url = reader["urla"].ToString();
                    offer.Add(h);
                }

                reader.Close();
                dal.dbc.conn.Close();
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            /*  var jsonData = new
              {
                  name_hotoffer = name,
                  picture = agent_id
              };*/
            Context.Response.Write(sr.Serialize(offer));
        }


        [WebMethod(MessageName = "remove_notfication", Description = "this method remove  notfication ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void remove_notfication(int customer_id, bool state )
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            int result = 0;
            string mess = "remove faild";
            string sql = null;
            try
            {
                if (state == true)
                {
                    sql = "insert into  notification (customer_id,notfication)values(" + customer_id + ",'" + state + "') ";
                    mess = "remove succ";
                }
                else if (state == false)
                {
                    sql = "delete from notification where customer_id=" + customer_id + "";
                    mess = "on";
                }
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                dal.dbc.conn.Open();
                result = cmd.ExecuteNonQuery();
                dal.dbc.conn.Close();
                if (result == 0)
                    mess = "try again";
               // else mess = "try again";
            }

            catch (Exception ex)
            {
                mess = "can not access data";
                dal.dbc.conn.Close();
            }

            var jsonData = new
            {
                Message = mess

            };
            Context.Response.Write(sr.Serialize(jsonData));
        }


        [WebMethod(MessageName = "getdata_notficate", Description = "ret")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void getdata_notficat(int customer_id)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            int UserID = 0;
            string Message = "";
            bool s = false;

            try
            {
                SqlDataReader reader;
                string sql = "select customer_id,notfication from notification where customer_id='" + customer_id + "' ";
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UserID = reader.GetInt32(0);
                    s = reader.GetBoolean(1);

                }
                if (UserID == 0)
                {
                    Message = " notfication is turn_on";
                }
                else
                    Message = "notification turn of";
                reader.Close();

                dal.dbc.conn.Close();


            }
            catch (Exception ex)
            {
                Message = " cannot access to the data";
                dal.dbc.conn.Close();

            }

            var jsonData = new
            {
                id = UserID,
                message = Message,
                state=s
            };
            Context.Response.Write(sr.Serialize(jsonData));
        }

        [WebMethod(MessageName = "improve", Description = "this method Suggestions improve app ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void improve(int customer_id, string text)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            int result = 0;
            string mess = "remove faild";
            string sql = null;
            try
            {
                
                    sql = "insert into  improve (customer_id,text)values(" + customer_id + ",'" + text + "')";
                
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                dal.dbc.conn.Open();
                result = cmd.ExecuteNonQuery();
                dal.dbc.conn.Close();
                if (result != 0)
                    mess = "add succ";
                else mess = "try again";
            }

            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            var jsonData = new
            {
                Message = mess

            };
            Context.Response.Write(sr.Serialize(jsonData));
        }


        [WebMethod(MessageName = "getdata_product", Description = "this method return product to customer ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void getdata_product()
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            List<product> hot = new List<product>();

            try
            {
                SqlDataReader reader;
                string sql = "select product_id,product_name,descr,price,url from product  ";

                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                // cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    product h = new product();
                    h.product_id = Convert.ToInt32(reader["product_id"]);
                    h.name = reader["product_name"].ToString();
                    h.price = Convert.ToDecimal(reader["price"]);
                    h.text_information = reader["descr"].ToString();
                    h.url_picture = reader["url"].ToString();
                    hot.Add(h);
                }

                reader.Close();
                dal.dbc.conn.Close();
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            /*  var jsonData = new
              {
                  name_hotoffer = name,
                  picture = imgdata
              };*/
            Context.Response.Write(sr.Serialize(hot));
        }



        [WebMethod(MessageName = "add_product_order", Description = "this method add  product order ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void add_product_order(int customer_id, int product_id , string name,string phone,string address)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();

            string mess = "";
            int result = 0;
            string sql = "";
            DataTable rt1 = new DataTable();
            try
            {
                
               sql = "insert into product_order (product_id,customer_id,phone,address,name) values ("+product_id+"," + customer_id + ",'" + phone + "','"+address+"','"+name+"')";
                    
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                dal.dbc.conn.Open();
                result = cmd.ExecuteNonQuery();
                dal.dbc.conn.Close();
                if (result > 0)
                    mess = "add order to succ";
                else
                    mess = "try again";
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            var jsonData = new
            {
                Message = mess

            };
            Context.Response.Write(sr.Serialize(jsonData));
        }

        [WebMethod(MessageName = "getdata_agentid_sub", Description = "this method return agent id  ")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void getdata_agentid_subs(int customer_id)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            List<agent> offer = new List<agent>();
            string sql = null;

            try
            {
                SqlDataReader reader;
               
                    sql = "select agentf_id from flow where customerf_id="+customer_id+"  ";
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    agent h = new agent();
                  
                    h.agent_id = Convert.ToInt32(reader["agentf_id"]);
                   
                    offer.Add(h);
                }

                reader.Close();
                dal.dbc.conn.Close();
            }
            catch (Exception ex)
            {

                dal.dbc.conn.Close();
            }

            Context.Response.Write(sr.Serialize(offer));
        }

    }


}
//(select picture from picture where hoteventpc_id="+ hotevent_id +")