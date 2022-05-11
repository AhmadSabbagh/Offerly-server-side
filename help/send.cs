using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace orgproject.help
{
    public class send
    {
        //string fromaddr = "Offerly2017@gmail.com";
        //   string toaddr = email;//TO ADDRESS HERE
        //  string password = "pa$$word";
        /*   if (ds.Tables[0].Rows.Count > 0)
           {

               MailMessage msg = new MailMessage();
               msg.Subject = "Username &password";
               msg.From = new MailAddress(fromaddr);
               msg.Body = "Hi, <br/>Please check your Login Detailss<br/><br/>Your Username: " + ds.Tables[0].Rows[0]["email"] + "<br/><br/>Your new Password: " + new_password + "<br/><br/>";
               msg.To.Add(new MailAddress(email));
               SmtpClient smtp = new SmtpClient();
               smtp.Host = "smtp.gmail.com";
               smtp.Port = 587;
               smtp.UseDefaultCredentials = false;
               smtp.EnableSsl = true;
               NetworkCredential nc = new NetworkCredential(fromaddr, password);
               smtp.Credentials = nc;
               smtp.Send(msg);
             /*  SHA512Managed SHA512 = new SHA512Managed();
               byte[] Hash3 = System.Text.Encoding.UTF8.GetBytes(new_password.ToString());
               Hash3 = SHA512.ComputeHash(Hash3);
               StringBuilder sb2 = new StringBuilder();
               foreach (byte p in Hash3)
               {
                   sb2.Append(p.ToString("x2").ToLower());
               }
               string newpass = sb2.ToString();*/

        /*  int result = 0;                                       
              string sql = "update customer  set password ='" + newpass + "' where email='" + email + "' ";
              SqlCommand cmd2 = new SqlCommand(sql, dbc.conn);
              dal.dbc.conn.Open();
              result = cmd2.ExecuteNonQuery();
              dal.dbc.conn.Close();
              if (result != 0)
                  Message = "check your mail send new password";
              else
                  Message = "Please enter correct mail";
          }*/
    }
}