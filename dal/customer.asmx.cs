using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;
using System.Web.Script.Serialization;
using System.Web.Script.Services;

namespace orgproject.dal
{
    /// <summary>
    /// Summary description for customer
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class customer : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod(MessageName = "add_admin", Description = "this method add admin")]
        [System.Xml.Serialization.XmlInclude(typeof(ReturnData))]
        //customer
        public int add_admin(string name, string password)
        {
          // ReturnData rt = new ReturnData();
            int result = 0;
            string UNid = Convert.ToString(Guid.NewGuid());
            string mess = "add faild";
            string sql = "insert into admin (admin_name,password,unid) values ('" + name + "','" + password + "','"+UNid+"')";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
         //   dal.dbc.conn.Close();

            string sql2 = "insert into admin_permissions (admin_id,per_name,state)select admin_id,permissions.name,admin_id*0 from admin,permissions where admin_name='"+ name +"' ";
            SqlCommand cmd2 = new SqlCommand(sql2, dbc.conn);
           // dal.dbc.conn.Open();
             cmd2.ExecuteNonQuery();
            dal.dbc.conn.Close();
             // if (result != 0)
               // mess = "add succ";

         // rt.message = mess;
          //  rt.id = result;
            return result;
        }

        [WebMethod(MessageName = "remove_admin", Description = "this method remove admin")]
        [System.Xml.Serialization.XmlInclude(typeof(ReturnData))]

        public int remove_admin(int id)
        {

            int result = 0;
            string ms = "";
            string sql = "delete from admin where admin_id=" + id + " ";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();
            ReturnData rt = new ReturnData();
            rt.id = result;
            rt.message = ms;
            return result;

          //  return result ;
        }

        [WebMethod(MessageName = "Login admin", Description = "Login new admin")]

        [System.Xml.Serialization.XmlInclude(typeof(ReturnData))]
        public ReturnData loginadmin (string name, string password)  /// get list of notes
        {

            int UserID = 0;
            string Message = "";
            string Unid = null;

            try
            {
                SqlDataReader reader;
                string sql = "select admin_id,unid from admin where admin_name='" + name + "'and password='" + password + "' ";
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UserID = reader.GetInt32(0);
                    Unid = reader.GetString(1);
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
                dal.dbc.conn.Close();

            }
            ReturnData rt = new ReturnData();
            rt.id = UserID;
            rt.message = Message;
            rt.unid = Unid;

            return rt;
        }

            public DataTable getData_admin(int admin_id = 0, string name = null)
        {
            DataTable table = new DataTable();
            string sql = "select admin_id,admin_name from admin where 1=1 ";

            if (admin_id != 0)
                sql = sql + " and admin_id =" + admin_id;

            if (name != null)
                sql = sql + " and admin_name ='" + name + "' ";
            
            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbc.conn);
            adapter.Fill(table);
            return table;
        }



        // favorate


        [WebMethod(MessageName = "add_fav", Description = "this method add  favorate to costomer")]
        [System.Xml.Serialization.XmlInclude(typeof(ReturnData))]
      
        public ReturnData add_fav(int castomer_id, int offer_id, int news_id)
        {
            ReturnData rt = new ReturnData();
            int result = 0;
            string mess = "add faild";
            string sql = "insert into fav (customerfav_id,offerfav_id,newfav_id) values (" + castomer_id + "," + offer_id + "," + news_id + ")";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();
            if (result != 0)
                mess = "add succ";

            rt.message = mess;
            rt.id = result;
            return rt;
        }


        [WebMethod(MessageName = "remove_fav", Description = "this method remove  favorate ")]
        [System.Xml.Serialization.XmlInclude(typeof(ReturnData))]

        public ReturnData remove_fav(int fav_id)
        {
            ReturnData rt = new ReturnData();
            int result = 0;
            string mess = "remove faild";
            string sql = "delete from fav where fav_id= " + fav_id + "";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();
            if (result != 0)
                mess = "remove succ";

            rt.message = mess;
            rt.id = result;
            return rt;
        }




        [WebMethod(MessageName = "select id fav", Description = "this method allow know id_fav")]

        [System.Xml.Serialization.XmlInclude(typeof(ReturnData))]
        public ReturnData select_fav(int customer_id,int offer_id=0,int news_id=0)  
        {

            int id = 0;
            string Message = "";

            try
            {
                SqlDataReader reader;
                string sql = "select fav_id from fav where customerfav_id=" + customer_id +"";
                if (offer_id !=0)
               sql= sql  + " and offerfav_id=" + offer_id + " ";
                if(news_id !=0)
                    sql= sql + "and newfav_id=" + news_id + " ";
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


            }


            ReturnData rt = new ReturnData();
            rt.id = id;
            rt.message = Message;

            return rt;
        }



        [WebMethod(MessageName = "add_tracking ", Description = "this method add page tracking customer")]
        [System.Xml.Serialization.XmlInclude(typeof(ReturnData))]

        public ReturnData add_trac(int castomer_id, string pagename,DateTime time)
        {
            ReturnData rt = new ReturnData();
            int result = 0;
           
            string sql = "insert into Tracking (customertrac_id,pagenam,time) values (" + castomer_id + ",'" + pagename + "','" + time + "')";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();
            rt.id = result;
            return rt;
           
        }



        [WebMethod(MessageName = "add_customer reg", Description = "this method add costomer")]
        [System.Xml.Serialization.XmlInclude(typeof(ReturnData))]
        //customer
        public ReturnData add_customer( string email, string password, string phone, string nationality, string address, string brith_day, string marriage_date, string gender, int age, string network_type, string device_type)
        {
            string mess = null;
            int result = 0;
            DataTable rt1 = new DataTable();
            ReturnData rt = new ReturnData();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from customer where email like '" + email +"'", dbc.conn);
            adapter.Fill(rt1);
            if (rt1 != null && rt1.Rows.Count > 0)
            {
                mess = "User already exists";
                result = 0;
            }
            else
            {


                string sql = "insert into customer (email,password,phone,nationality,address,brith_day,marriage_date,gender,age,network_type,device_type) values ('" + email + "','" + password + "','" + phone + "','" + nationality + "','" + address + "','" + brith_day + "','" + marriage_date + "','" + gender + "'," + age + ",'" + network_type + "','" + device_type + "')";
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                dal.dbc.conn.Open();
                result = cmd.ExecuteNonQuery();
                dal.dbc.conn.Close();
                if (result != 0)
                    mess = "add succ";
            }
             rt.message = mess;
              rt.id = result;
            return rt;
        }


        
        /*
        [WebMethod]

        public int edit_customer(int customer_id=0,string email=null,string phone=null) //للتعديل لاحقا
        {
            int result = 0;
          string sql = "update customer  set  email= '" + email + "',password='" + password + "', phone='"+ phone+ "',address='"+ address+ "',network_type'"+ network_type + "',device_type'"+ device_type + "' where customer_id=" + customer_id + ")";

            string sql = "delete from offers where 1=1 ";
            if (agentoff_id != 0)
                sql = sql + " and agentoff_id =" + agentoff_id + " ";

            if (offer_name != null)
                sql = sql + " and offer_name ='" + offer_name + "' ";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result; 
        }   */
        [WebMethod(MessageName = "remove_customer", Description = "this method remove costomer")]
        [System.Xml.Serialization.XmlInclude(typeof(ReturnData))]

        public ReturnData remove_customer(int customer_id)
        {

            int result = 0;
            string ms = "";
            string sql = "delete from customer where customer_id=" + customer_id + " ";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();
            ReturnData rt = new ReturnData();
            if (result != 0)
                ms = "remove succ";
            else
                ms = "not remove ";

            rt.id = result;
            rt.message = ms;
            return rt;
        }
  /*      [WebMethod]
        public DataTable change_password(string old_pass,string new_pass)
        {
            DataTable table = new DataTable();
            string sql1 = "select * from customer where password=" + old_pass + "";
            SqlDataAdapter adapter = new SqlDataAdapter(sql1, dbc.conn);
            adapter.Fill(table);

            int result = 0;
            string sql = "update customer  set  password=" + new_pass + "";

        }*/



        [WebMethod]


         public DataTable getData_customer(int customer_id = 0, string email = null, string phone = null, string nationality = null, string address = null, string brith_day = null, string marriage_date = null, string gender = null, int age = 0, string network_type = null, string device_type = null)
         {
             DataTable table = new DataTable();
             string sql = "select * from customer where 1=1 ";

             if (customer_id != 0)
                 sql = sql + " and customer_id =" + customer_id;

             if (email != null)
                 sql = sql + " and email ='" + email + "' ";

             if (phone != null)
                 sql = sql + " and phone ='" + phone + "' ";
             if (nationality != null)
                 sql = sql + " and nationality ='" + nationality + "' ";

             if (address != null)
                 sql = sql + " and address ='" + address + "' ";

             if (gender != null)
                 sql = sql + " and gender ='" + gender + "' ";

             if (age != 0)
                 sql = sql + " and age =" + age;

            if (brith_day != null)
                sql = sql + " and brith_day ='" + brith_day + "' ";

            if (network_type != null)
                 sql = sql + " and network_type ='" + network_type + "' ";

             if (device_type != null)
                 sql = sql + " and device_type ='" + device_type + "' ";





             SqlDataAdapter adapter = new SqlDataAdapter(sql, dbc.conn);
             adapter.Fill(table);
             return table;
         }








        [WebMethod(MessageName = "Login", Description = "Login new user")]

        [System.Xml.Serialization.XmlInclude(typeof(ReturnData))]
      //  [WebMethod]
       // [ScriptMethod(ResponseFormat=ResponseFormat.Json)]
          public ReturnData Login(string email, string password)  /// get list of notes
        {
          //  JavaScriptSerializer sr = new JavaScriptSerializer();
            int UserID = 0;
            string Message = "";

            try
            {
                    SqlDataReader reader;
                    string sql = "select customer_id from customer where email='" + email + "'and password='" + password + "' ";
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
            
           /* var jsonData = new
            {
                id = UserID,
                message = Message
              };*/
        ReturnData rt = new ReturnData();
      rt.id = UserID;
           rt.message = Message;
            return rt;

          //  return sr.Serialize(jsonData);
        }



        


        //children brith

        [WebMethod]
        public int add_childbrith(int customerch_id, string name_baby, string brith_day)
        {
            int result = 0;
            string sql = "insert into children_brith (customerch_id,name_baby,brith_day) values (" + customerch_id + ",'" + name_baby + "','" + brith_day + "')";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }

        /* [WebMethod]

         public int edit_childbrith(int customerch_id) //للتعديل لاحقا
         {
             int result = 0;
             // string sql = "update children_brith  set  name_baby= '" + name_baby + "',brith_day='" + brith_day + "' where customerch_id=" + customerch_id + ")";
             SqlCommand cmd = new SqlCommand(sql, dbc.conn);
             dal.dbc.conn.Open();
             result = cmd.ExecuteNonQuery();
             dal.dbc.conn.Close();

             return result;
         }   */
        [WebMethod]

        public int remove_childbrith(int customerch_id)
        {
            int result = 0;
            string sql = "delete from children_brith where customerch_id=" + customerch_id + "";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
             result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }
        [WebMethod]

        public DataTable getData_childbrith(int customerch_id = 0, string name_baby = null, string brith_day = null)
        {
            DataTable table = new DataTable();
            string sql = "select * from children_brith where 1=1 ";

            if (customerch_id != 0)
                sql = sql + " and customerch_id =" + customerch_id;

            if (name_baby != null)
                sql = sql + " and name_baby ='" + name_baby + "' ";

            if (brith_day != null)
                sql = sql + " and brith_day ='" + brith_day + "' ";


            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbc.conn);
            adapter.Fill(table);
            return table;
        }

        //agent

        [WebMethod(MessageName = "add_agent", Description = "this method add agent")]
        [System.Xml.Serialization.XmlInclude(typeof(ReturnData))]


        public int add_agent( string name, string password, string phone, string address, string city, int cat_id,int sub_id,string desc)
        {
            int result = 0;
           string UNid = Convert.ToString(Guid.NewGuid());
            string sql = null;
            if(sub_id!=0)
             sql = "insert into agent (name,password,phone,address,city,cat_id,UNid,sub_id,descr) values ('" + name + "','" + password + "','" + phone + "','" + address + "','" + city + "'," + cat_id + ",'"+ UNid + "'," + sub_id + ",'" + desc + "')";
            else
                sql = "insert into agent (name,password,phone,address,city,cat_id,UNid,descr) values ('" + name + "','" + password + "','" + phone + "','" + address + "','" + city + "'," + cat_id + ",'" + UNid + "','" + desc + "')";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            //  dal.dbc.conn.Close();
            string sql2 = "insert into agent_permissions (agent_id,per_name,state)select agent_id,permissions_agent.name,agent_id*0 from agent,permissions_agent where agent.name='" + name + "' ";
            SqlCommand cmd2 = new SqlCommand(sql2, dbc.conn);
            // dal.dbc.conn.Open();
            cmd2.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }
        /*
          [WebMethod]

          public int edit_agent(int agent_id,string name=null,string password=null,string phone=null,string brith_day=null,string address=null,string city=null,int cat_id=0) //للتعديل لاحقا
          {
              int result = 0; 
             // string sql = "update agent  set  name= '" + name + "',password='" + password + "', phone='" + phone + "',brith_day='" + brith_day + "',address'" + address + "',city'" + city + "',cat_id " + cat_id + " where agent_id=" + agent_id + ")";
            string x = "";

            string sql = "update agent  set  name= '" + name + "',password='" + password + "', phone='" + phone + "',brith_day='" + brith_day + "',address'" + address + "',city'" + city + "',cat_id " + cat_id + " where agent_id=" + agent_id + ")";

            if (name != null)
                "update agent  set  name= '" + name + "'" where agent_id = " + agent_id + )";

            if (password != null)
                sql = sql + " and password ='" + password + "' ";

            if (phone != null)
                sql = sql + " and phone ='" + phone + "' ";

            if (brith_day != null)
                sql = sql + " and brith_day ='" + brith_day + "' ";

            if (address != null)
                sql = sql + " and address ='" + address + "' ";

            if (city != null)
                sql = sql + " and city =" + city;

            if (cat_id != 0)
                sql = sql + " and cat_id = " + cat_id;
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
              dal.dbc.conn.Open();
              result = cmd.ExecuteNonQuery();
              dal.dbc.conn.Close();

              return result;
          }  */
        [WebMethod]

        public int remove_agent(int agent_id)
        {
            int result = 0;
            string sql = "delete from agent where agent_id=" + agent_id + " ";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }
        [WebMethod(MessageName = "view_agent", Description = "this method view agent")]
        [System.Xml.Serialization.XmlInclude(typeof(DataTable))]

        public DataTable getData_agent(int id = 0, string name = null , int cat_id = 0)
        {
            DataTable table = new DataTable();
            string sql = "select name,agent_id,phone,address,city,cat_name from agent,categories where agent.cat_id=categories.cat_id  ";

         /*   if (id !=0)
                sql = sql + " and id =" + id + " ";
            if (name != "")
                sql = sql + " and name ='" + name + "' ";
            else
            if (cat_id != 0)
                sql = sql + " and cat_id = " + cat_id;*/
            
            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbc.conn);
            adapter.Fill(table);
            return table;
        }

        [WebMethod(MessageName = "Login agent", Description = "Login new agent")]

        [System.Xml.Serialization.XmlInclude(typeof(ReturnData))]
        public ReturnData LoginAgent(string name, string password)  /// get list of notes
        {

            int UserID = 0;
            string Message = "";

            try
            {
                SqlDataReader reader;
                string sql = "select agent_id from agent where name='" + name + "'and password='" + password + "' ";
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


            ReturnData rt = new ReturnData();
            rt.id = UserID;
            rt.message = Message;

            return rt;
        }


        //Interests of agent

        [WebMethod]
        public int add_interest(int agentinterst_id, string name)
        {
            int result = 0;
            string sql = "insert into interests_of_agent (agentinterst_id,name) values (" + agentinterst_id + ",'" + name + "')";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }

        /* [WebMethod]

         public int edit_interest(int agentinterst_id) //للتعديل لاحقا
         {
             int result = 0;
             // string sql = "update interests_of_agent  set  name= '" + name + "' where agentinterst_id=" + agentinterst_id + ")";
             SqlCommand cmd = new SqlCommand(sql, dbc.conn);
             dal.dbc.conn.Open();
             result = cmd.ExecuteNonQuery();
             dal.dbc.conn.Close();

             return result;
         }   */
        [WebMethod]

        public int remove_interest(int agentinterst_id)
        {
            int result = 0;
            string sql = "delet from interests_of_agent where agentinterst_id=" + agentinterst_id + ")";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }
        [WebMethod]

        public DataTable getData_interest(int agentinterst_id = 0, string name = null)
        {
            DataTable table = new DataTable();
            string sql = "select * from interests_of_agent where 1=1 ";

            if (agentinterst_id != 0)
                sql = sql + " and agentinterst_id =" + agentinterst_id;

            if (name != null)
                sql = sql + " and name ='" + name + "' ";

            

            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbc.conn);
            adapter.Fill(table);
            return table;
        }


        //comments
        [WebMethod(MessageName = "add_comment from user", Description = "this method add comments")]
        [System.Xml.Serialization.XmlInclude(typeof(int))]
        public int add_comment(int customercom_id, int star,string comment,DateTime history,int agent_id,int offer_id)
        {
            int result = 0;
            string sql = "insert into comments (customercom_id,star,comment,history,agent_id,offer_id) values (" + customercom_id + "," + star + ",'" + comment + "','" + history + "',"+ agent_id +","+ offer_id +")";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }

        [WebMethod(MessageName = "add_comment ", Description = "this method add comments")]
        [System.Xml.Serialization.XmlInclude(typeof(int))]
        public int comment_ok(int comment_id)
        {
            int result = 0;
            string sql = "INSERT INTO comment_ok(customercom_id, star, comment, history, agent_id, offer_id) SELECT customercom_id, star, comment, history, agent_id, offer_id FROM comments AS comments_1 WHERE comment_id = "+ comment_id +"";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }


        [WebMethod]

        public int remove_comment(int comment_id)
        {
            int result = 0;
            string sql = "delete from comments where comment_id=" + comment_id + "";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }
        [WebMethod(MessageName = "return comment", Description = "this method return comment to customer ")]

        [System.Xml.Serialization.XmlInclude(typeof(returncomments))]
        public returncomments getdata_comment(int customer_id,int agent_id,int offer_id)
        {

            int id = 0;
            string comm = null;
            DateTime t = default(DateTime);
            int st = 0;
            int ag = 0;
            int off = 0;

            try
            {
                SqlDataReader reader;
                string sql = "select customercom_id,star,comment,history,agent_id,offer_id from comments where customercom_id =" + customer_id + " and offer_id= "+ offer_id +" and agent_id= "+ agent_id +"";

                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                    st = reader.GetInt32(1);
                    comm = reader.GetString(2);
                    t = reader.GetDateTime(3);
                    ag = reader.GetInt32(4);
                    off = reader.GetInt32(5);



                }

                reader.Close();

                dal.dbc.conn.Close();


            }
            catch (Exception ex)
            {
                throw;


            }


            returncomments com = new returncomments();
            com.customer_id = id;
            com.star = st;
            com.comment = comm;
            com.history = t;
            com.agent_id = ag;
            com.offer_id = off;

            return com;
        }


        //branch agent

        [WebMethod]

        public int add_branchagent(int agentch_id, string branch_name, string phone)
        {
            int result = 0;
            string sql = "insert into branches_agent (agentch_id,branch_name,phone) values (" + agentch_id + ",'" + branch_name + "','" + phone + "')";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }

        /*
                [WebMethod]

                public int edit_coment(int customercom_id) //للتعديل لاحقا
                {
                    int result = 0; string email = null;
                    string sql = "update comments  set  star1= '" + star1 + "',star2='" + star2 + "', star3='" + star3 + "',star4='" + star4 + "',star5'" + star5 + "',comment'" + comment + "',history " + DateTime.Now + " where customercom_id=" + customercom_id + ")";
                    SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                    dal.dbc.conn.Open();
                    result = cmd.ExecuteNonQuery();
                    dal.dbc.conn.Close();

                    return result;
                }*/

        [WebMethod]

        public int remove_branchagent(int agentch_id=0 ,string branch_name=null )
        {
            int result = 0;
            string sql = "delete from branches_agent where 1=1 ";
                if(agentch_id !=0)
                sql= sql + " and agentch_id =" + agentch_id + "";

            if (branch_name != null)
                sql = sql + " and branch_name ='" + branch_name + "' ";


            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }
        [WebMethod]

        public DataTable getData_branchagent(int agentch_id = 0, string branch_name = null, string phone = null, decimal latiude=0, decimal longitude=0)
        {
            DataTable table = new DataTable();
            string sql = "select * from branches_agent where 1=1 ";

            if (agentch_id != 0)
                sql = sql + " and agentch_id =" + agentch_id;

            if (branch_name != null)
                sql = sql + " and branch_name ='" + branch_name + "' ";

            if (phone != null)
                sql = sql + " and phone ='" + phone + "' ";

            if (latiude != 0 && latiude != 0)
                sql = sql + " and latiude =" + latiude + " and latiude ="+ latiude +" ";

        
            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbc.conn);
            adapter.Fill(table);
            return table;
        }




        //complaints

        [WebMethod]

        public int add_complaint(int complaint_id, int customercomp_id, string email, string complaint)
        {
            int result = 0;
            string sql = "insert into complaints (complaint_id,customercomp_id,email,complaint) values (" + complaint_id + "," + customercomp_id + ",'" + email + "','" + complaint + "')";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }

        /*
                [WebMethod]

                public int edit_coment(int customercom_id) //للتعديل لاحقا
                {
                    int result = 0; string email = null;
                    string sql = "update comments  set  star1= '" + star1 + "',star2='" + star2 + "', star3='" + star3 + "',star4='" + star4 + "',star5'" + star5 + "',comment'" + comment + "',history " + DateTime.Now + " where customercom_id=" + customercom_id + ")";
                    SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                    dal.dbc.conn.Open();
                    result = cmd.ExecuteNonQuery();
                    dal.dbc.conn.Close();

                    return result;
                }*/

        [WebMethod]

        public int remove_complaint()
        {
            int result = 0;
            string sql = "delete from complaints  ";
               


            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }
        [WebMethod]

        public DataTable getData_complaint(int complaint_id = 0, int customercomp_id = 0, string email = null, string complaint = null)
        {
            DataTable table = new DataTable();
            string sql = "select * from complaints where 1=1 ";

            if (complaint_id != 0)
                sql = sql + " and complaint_id =" + complaint_id;

            if (customercomp_id != 0)
                sql = sql + " and customercomp_id =" + customercomp_id + " ";

            if (email != null)
                sql = sql + " and email ='" + email + "' ";

            if (complaint != null )
                sql = sql + " and complaint ='" + complaint + "'  ";


            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbc.conn);
            adapter.Fill(table);
            return table;
        }

        //suggestions

        [WebMethod(MessageName = "add suggest ", Description = "add suggest for agent")]

        [System.Xml.Serialization.XmlInclude(typeof(int))]

        public int add_suggest(int customersugg_id, string nameagent,string phoneage,string emailage,string customer_phone,string customer_email)
        {
            int result = 0;
            string sql = "insert into suggestions (customersugg_id,name,phone,email,customer_phone,customer_emil) values (" + customersugg_id + ",'" + nameagent + "','" + phoneage + "','" + emailage + "','" + customer_phone + "','" + customer_email + "')";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }

        /*
                [WebMethod]

                public int edit_coment(int customercom_id) //للتعديل لاحقا
                {
                    int result = 0; string email = null;
                    string sql = "update comments  set  star1= '" + star1 + "',star2='" + star2 + "', star3='" + star3 + "',star4='" + star4 + "',star5'" + star5 + "',comment'" + comment + "',history " + DateTime.Now + " where customercom_id=" + customercom_id + ")";
                    SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                    dal.dbc.conn.Open();
                    result = cmd.ExecuteNonQuery();
                    dal.dbc.conn.Close();

                    return result;
                }*/

        [WebMethod]

        public int remove_suggest()
        {
            int result = 0;
            string sql = "delete from suggestions ";
           


            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }
        [WebMethod]

        public DataTable getData_suggest(int customersugg_id = 0, string name = null, string phone = null, string email = null)
        {
            DataTable table = new DataTable();
            string sql = "select * from suggestions where 1=1 ";

            if (customersugg_id != 0)
                sql = sql + " and customersugg_id =" + customersugg_id;

            if (name != null)
                sql = sql + " and name ='" + name + "' ";

            if (phone != null)
                sql = sql + " and phone ='" + phone + "' ";

            if (email != null)
                sql = sql + " and email ='" + email + "'  ";


            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbc.conn);
            adapter.Fill(table);
            return table;
        }

        //advert

        [WebMethod]

        public int add_advert( string advert, string time,string period,string picture)//للتعديل لاحقا اضافة صوره
        {
            int result = 0;
            string sql = "insert into advert (advert,time,period,picture) values ('" + advert + "','" + time + "','"+ period +"','"+ picture +"')";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }

        /*
                [WebMethod]

                public int edit_coment(int customercom_id) //للتعديل لاحقا
                {
                    int result = 0; string email = null;
                    string sql = "update comments  set  star1= '" + star1 + "',star2='" + star2 + "', star3='" + star3 + "',star4='" + star4 + "',star5'" + star5 + "',comment'" + comment + "',history " + DateTime.Now + " where customercom_id=" + customercom_id + ")";
                    SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                    dal.dbc.conn.Open();
                    result = cmd.ExecuteNonQuery();
                    dal.dbc.conn.Close();

                    return result;
                }*/

        [WebMethod]

        public int remove_advert(int advert_id=0,string name=null )
        {
            int result = 0;
            string sql = "delete from advert where 1=1 ";
            if (advert_id != 0)
                sql = sql + " and advert_id =" + advert_id + " ";

            if (name != null)
                sql = sql + " and name ='" + name + "' ";


            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }
       




        [WebMethod(MessageName = "select advert to customer", Description = "this method show advert ")]

        [System.Xml.Serialization.XmlInclude(typeof(advert_ret_data))]
        public advert_ret_data getdata_advertcust(int customer_id)
        {

            int id = 0;
            string adv = null;
            string t = null;
            string per = null;
            string pic = null;

            try
            {
                SqlDataReader reader;
                string sql = "select cus_adv.advert_id,advert,time,period,picture from cus_adv,advert where cus-adv.advert_id=advert.advert_id and cus_adv.customer_id =" + customer_id + "";
                
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
                    pic= reader.GetString(4);



                }
               
                reader.Close();

                dal.dbc.conn.Close();


            }
            catch (Exception ex)
            {
                throw;


            }


            advert_ret_data art = new advert_ret_data();
            art.advert_id = id;
            art.advert = adv;
            art.time = t;
            art.period = per;
            art.picture = pic;

            return art;
        }


        [WebMethod]
        public DataTable getData_advert( string name = null)
        {
            DataTable table = new DataTable();
            string sql = "select advert,name,time,period from advert where 1=1 ";

            
            if (name != null)
                sql = sql + " and name ='" + name + "' ";


            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbc.conn);
            adapter.Fill(table);
            return table;
        }

        //Tracking

        [WebMethod]

        public int add_track(int customertrac_id, string pagename)
        {
            int result = 0;
            string sql = "insert into Tracking (customertrac_id,pagename) values (" + customertrac_id + ",'" + pagename + "')";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }

        /*
                [WebMethod]

                public int edit_coment(int customercom_id) //للتعديل لاحقا
                {
                    int result = 0; string email = null;
                    string sql = "update comments  set  star1= '" + star1 + "',star2='" + star2 + "', star3='" + star3 + "',star4='" + star4 + "',star5'" + star5 + "',comment'" + comment + "',history " + DateTime.Now + " where customercom_id=" + customercom_id + ")";
                    SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                    dal.dbc.conn.Open();
                    result = cmd.ExecuteNonQuery();
                    dal.dbc.conn.Close();

                    return result;
                }*/

        [WebMethod]

        public int remove_track(int customertrac_id = 0, string pagename = null)
        {
            int result = 0;
            string sql = "delete from Tracking where 1=1 ";
            if (customertrac_id != 0)
                sql = sql + " and customertrac_id =" + customertrac_id + " ";

            if (pagename != null)
                sql = sql + " and pagename ='" + pagename + "' ";


            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }
        [WebMethod]

        public DataTable getData_track(int customertrac_id = 0, string pagename = null)
        {
            DataTable table = new DataTable();
            string sql = "select * from Tracking where 1=1 ";

            if (customertrac_id != 0)
                sql = sql + " and customertrac_id =" + customertrac_id;

            if (pagename != null)
                sql = sql + " and pagename ='" + pagename + "' ";


            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbc.conn);
            adapter.Fill(table);
            return table;
        }


        

        //offers

        [WebMethod]


        public int add_offer(int agentoff_id, string offer_name,string descr, string start_time, string end_time)//للتعديل لاحقا صوره
        {
            int result = 0;
            string sql = "insert into offers (agentoff_id,offer_name,descr,start_time,end_time,ch) values (" + agentoff_id + ",'" + offer_name + "','" + descr + "','" + start_time + "','" + end_time + "',1)";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }

        public int add_notification(int agentoff_id, int offernotf,int newsnotf,string offername)//للتعديل لاحقا صوره
        {
            int result = 0;
            string sql = "insert into notification (agentnot_id,offernot,newsnot,offername) values (" + agentoff_id + "," + offernotf + "," + newsnotf + ",'"+offername+"')";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }

        /*  [WebMethod]

          public int edit_agent(int agent_id) //للتعديل لاحقا
          {
              int result = 0; string email = null;
              string sql = "update agent  set  name= '" + name + "',password='" + password + "', phone='" + phone + "',brith_day='" + brith_day + "',address'" + address + "',city'" + city + "',cat_id " + cat_id + " where agent_id=" + agent_id + ")";
              SqlCommand cmd = new SqlCommand(sql, dbc.conn);
              dal.dbc.conn.Open();
              result = cmd.ExecuteNonQuery();
              dal.dbc.conn.Close();

              return result;
          }  */
        [WebMethod]

        public int remove_offer(int agentoff_id=0 ,string offer_name=null)
        {
            int result = 0;
            string sql = "delete from offers where 1=1 ";
            if (agentoff_id != 0)
                sql = sql + " and agentoff_id =" + agentoff_id + " ";

            if (offer_name != null)
                sql = sql + " and offer_name ='" + offer_name + "' ";

            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }
        [WebMethod]

       
        public DataTable getData_offer(int agentoff_id = 0, string name = null, string offer_name = null,DateTime end_time=default(DateTime))// للتعديل لاحقا تاريخ فقط
        {
            DataTable table = new DataTable();
            string sql = "select * from offers where 1=1 ";

            if (agentoff_id != 0)
                sql = sql + " and agentoff_id =" + agentoff_id;

            if (name != null)
                sql = sql + " and name ='" + name + "' ";

            if (offer_name != null)
                sql = sql + " and offer_name ='" + offer_name + "' ";

           

            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbc.conn);
            adapter.Fill(table);
            return table;
        }

        //categories

        [WebMethod]

        public int add_category( string cat_name)
        {
            int result = 0;
            string sql = "insert into categories (cat_name) values ('" + cat_name + "')";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }

        /*
                [WebMethod]

                public int edit_coment(int customercom_id) //للتعديل لاحقا
                {
                    int result = 0; string email = null;
                    string sql = "update comments  set  star1= '" + star1 + "',star2='" + star2 + "', star3='" + star3 + "',star4='" + star4 + "',star5'" + star5 + "',comment'" + comment + "',history " + DateTime.Now + " where customercom_id=" + customercom_id + ")";
                    SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                    dal.dbc.conn.Open();
                    result = cmd.ExecuteNonQuery();
                    dal.dbc.conn.Close();

                    return result;
                }*/

        [WebMethod]

        public int remove_category(int cat_id = 0, string cat_name = null)
        {
            int result = 0;
            string sql = "delete from categories where 1=1 ";
            if (cat_id != 0)
                sql = sql + " and cat_id =" + cat_id + " ";

            if (cat_name != null)
                sql = sql + " and cat_name ='" + cat_name + "' ";


            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }
        [WebMethod]

        public DataTable getData_category(int cat_id = 0, string cat_name = null)
        {
            DataTable table = new DataTable();
            string sql = "select * from categories where 1=1 ";

            if (cat_id != 0)
                sql = sql + " and cat_id =" + cat_id;

            if (cat_name != null)
                sql = sql + " and cat_name ='" + cat_name + "' ";


            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbc.conn);
            adapter.Fill(table);
            return table;
        }


        //sub_categorie

        [WebMethod]

        public int add_subcategory(int catsub_id, string catsub_name)
        {
            int result = 0;
            string sql = "insert into sub_categorie (catsub_id,catsub_name) values (" + catsub_id + ",'" + catsub_name + "')";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }

        /*
                [WebMethod]

                public int edit_coment(int customercom_id) //للتعديل لاحقا
                {
                    int result = 0; string email = null;
                    string sql = "update comments  set  star1= '" + star1 + "',star2='" + star2 + "', star3='" + star3 + "',star4='" + star4 + "',star5'" + star5 + "',comment'" + comment + "',history " + DateTime.Now + " where customercom_id=" + customercom_id + ")";
                    SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                    dal.dbc.conn.Open();
                    result = cmd.ExecuteNonQuery();
                    dal.dbc.conn.Close();

                    return result;
                }*/

        [WebMethod]

        public int remove_subcategory(int catsub_id = 0, string catsub_name = null)
        {
            int result = 0;
            string sql = "delete from sub_categorie where 1=1 ";
            if (catsub_id != 0)
                sql = sql + " and catsub_id =" + catsub_id + " ";

            if (catsub_name != null)
                sql = sql + " and catsub_name ='" + catsub_name + "' ";


            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }
        [WebMethod]

        public DataTable getData_subcategory(int catsub_id = 0, string catsub_name = null)
        {
            DataTable table = new DataTable();
            string sql = "select * from sub_categorie where 1=1 ";

            if (catsub_id != 0)
                sql = sql + " and catsub_id =" + catsub_id;

            if (catsub_name != null)
                sql = sql + " and catsub_name ='" + catsub_name + "' ";


            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbc.conn);
            adapter.Fill(table);
            return table;
        }

        [WebMethod]

        public int add_news(int agent_id, string t_news,string name)
        {
            int result = 0;
            string sql = "insert into news (agent_id,t_news,news_name) values (" + agent_id + ",'" + t_news + "','"+name+"')";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }

        [WebMethod]

        public int add_picture(int offerpc_id, string picture)
        {
            int result = 0;
            string sql = "insert into picture (agent_id,t_news) values (" + offerpc_id + ",'" + picture + "')";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }

        [WebMethod]

        public int add_brithoffer(int agent_id, string offer,object picture,DateTime first_time,DateTime las_time)
        {
            int result = 0;
            int result2 = 0;
            string sql = "insert into brith_offer (agentbo_id,,offer,picture,first_time,last_time) values (" + agent_id + ",'" + offer + "','"+ picture +"','"+ first_time+"','"+ las_time +"')";
            string sql2 = "insrt into cus_brithoffer (customerb_id,brithoffer_id)select customer_id,id from customer,brith_offer where brith_day between first_time and last_time ";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            SqlCommand cmd2= new SqlCommand(sql2, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            result2= cmd2.ExecuteNonQuery();         
            dal.dbc.conn.Close();

            return result;
        }

        [WebMethod]

        public int add_marriageoffer(int agent_id, string offer, string picture, DateTime first_time, DateTime las_time)
        { //للتعديل اغلاق ثم فتح ثم اغلاق 
            int result = 0;
            int result2 = 0;
            string sql = "insert into marriage_offer (agentma_id,,offer,picture,first_time,last_time) values (" + agent_id + ",'" + offer + "','" + picture + "','" + first_time + "','" + las_time + "')";
            string sql2 = "insrt into cus_marriagoffer (customerb_id,marriagoffer_id)select customer_id,id from customer,marriage_offer where brith_day between first_time and last_time ";
            SqlCommand cmd = new SqlCommand(sql, dbc.conn);
            SqlCommand cmd2 = new SqlCommand(sql2, dbc.conn);
            dal.dbc.conn.Open();
            result = cmd.ExecuteNonQuery();
            result2 = cmd2.ExecuteNonQuery();
            dal.dbc.conn.Close();

            return result;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string get_brithoffer(int customer_id)  /// get list of notes
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            string name ="";
            string t = "";
            string off = "";
            string Message = ""; 

            try
            {
                SqlDataReader reader;
                string sql = "select name,offer,picture from agent,brith_offer,cus_brithoffer where agentbo_id =agent_id and id = brithoffer_id and customerb_id =" + customer_id + " ";
                SqlCommand cmd = new SqlCommand(sql, dbc.conn);
                cmd.CommandType = CommandType.Text;

                dal.dbc.conn.Open();

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    
                    name = reader.GetString(0);
                    off = reader.GetString(1);                 
                    t = reader.GetString(2);

                }
               
                reader.Close();

                dal.dbc.conn.Close();


            }
            catch (Exception ex)
            {
                Message = " cannot access to the data";


            }

            var jsonData = new
            {
                name_agent = name,
                offer=off,
                picture=t,
                message = Message
            };
            //  ReturnData rt = new ReturnData();
            //  rt.id = UserID;
            //   rt.message = Message;

            return sr.Serialize(jsonData);
        }
    }
}
