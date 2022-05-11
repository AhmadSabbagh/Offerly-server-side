using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace orgproject.dal
{
    public class advert_ret_data
    {
        public int advert_id { set; get; }

              public string advert { set; get; }

              public string time { set; get; }

              public string period { set; get; }

              public string picture { set; get; }


     
          
    }
}


// if(ds.Tables[0].Rows.Count>0)
//  {
/*
   MailMessage Msg = new MailMessage();
   // Sender e-mail address.
   Msg.From = new MailAddress("haleem30030@gmail.com");
   // Recipient e-mail address.
   Msg.To.Add(email);
   Msg.Subject = "Your Password Details";
   Msg.Body = "Hi, <br/>Please check your Login Detailss<br/><br/>Your Username: " + ds.Tables[0].Rows[0]["email"] + "<br/><br/>Your Password: " + ds.Tables[0].Rows[0]["Password"] + "<br/><br/>";
   Msg.IsBodyHtml = true;
   // your remote SMTP server IP.
   SmtpClient smtp = new SmtpClient();
   // Dim smtp As New SmtpClient()
    smtp.Host = "smtp.gmail.com";
    smtp.Port = 587;
    smtp.Credentials = new System.Net.NetworkCredential("haleem30030@gmail.com", "777082221");
    smtp.EnableSsl = true;
    smtp.Send(Msg);
    //Msg = null;

  /* SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", Convert.ToInt32(587));
   System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("joe@contoso.com", "XXXXXX");
   smtpClient.Credentials = credentials;
   smtpClient.EnableSsl = true;
   smtpClient.Send(Msg);*/
/*  mess = "Your Password Details Sent to your mail";
  // Clear the textbox valuess
  */
/*             MailMessage mm = new MailMessage("haleem30030@gmail.com",email);
             mm.Subject = "Password Recovery";
             mm.Body = string.Format("Hi {0},<br /><br />Your password is {1}.<br /><br />Thank You.", email, ds.Tables[0].Rows[0]["Password"]);
             mm.IsBodyHtml = true;
             SmtpClient smtp = new SmtpClient();
             smtp.Host = "smtp.gmail.com";
             smtp.EnableSsl = true;
             NetworkCredential NetworkCred = new NetworkCredential();
             NetworkCred.UserName = "haleem30030@gmail.com";
             NetworkCred.Password = "777082221";
             smtp.UseDefaultCredentials = true;
             smtp.Credentials = NetworkCred;
             smtp.Port = 587;
             smtp.Send(mm);
            // lblMessage.ForeColor = Color.Green;
            mess = "Password has been sent to your email address.";

         }
             else
             {
             mess = "The Email you entered not exists.";
             }
             }
             catch (Exception ex)
             {
             Console.WriteLine("{0} Exception caught.", ex);
             }
     var jsonData = new
     {
         message = mess
     };
     return sr.Serialize(jsonData);
 }*/

/*   DataSet ds = new DataSet();

      dal.dbc.conn.Open();
      SqlCommand cmd = new SqlCommand("SELECT email,password FROM customer Where email= '" + email + "'", dbc.conn);
      SqlDataAdapter da = new SqlDataAdapter(cmd);
      da.Fill(ds);
      dbc.conn.Close();



      string smtpAddress = "smtp.gmail.com"; //"
      int portNumber = 587;
      bool enableSSL = false;

      string emailFrom = "haleem20020@gmail.com";
      string password = "777082221";
      string emailTo = email;

      using (MailMessage mail = new MailMessage())
      {
          mail.From = new MailAddress(emailFrom);
          mail.To.Add(emailTo);

          mail.Subject = " Your Password Details";
          mail.Body = "aaaaaa";
         // mail.Body = "Hi, <br/>Please check your Login Detailss<br/><br/>Your Username: " + ds.Tables[0].Rows[0]["email"] + "<br/><br/>Your Password: " + ds.Tables[0].Rows[0]["Password"] + "<br/><br/>";
          mail.IsBodyHtml = true;
          // Can set to false, if you are sending pure text.

          //  mail.Attachments.Add(new Attachment("C:\\SomeFile.txt"));
          //  mail.Attachments.Add(new Attachment("C:\\SomeZip.zip"));

          using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
          {
              smtp.Credentials = new NetworkCredential(emailFrom, password);
              smtp.EnableSsl = enableSSL;
              smtp.Send(mail);
          }
      }*/
