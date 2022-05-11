using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace orgproject
{
    public partial class test4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //  string applicationID = "AAAAL0UljIA:APA91bE8BuI1GIRoOAxho3C9bQNmIeCzTTROXomlPUaUGyMZhPG0OWsE94etBvFsgc6IwNA8e6LsniI5PtM87Sa_S2EvOzLnj3FuoGKE0YPMKckBlZYHlINA3DE1dmU4XhkHEjMLpj08";
                string applicationID = " AAAAMmyrjRs:APA91bFSONUwykLrX5ZwllFTapXgYWq4R7Xcn1Joi_By4d0vg4D_Su3Cylnes4M9B-e-ZZ8jrSPGS1Sv7rpHEuCQ0cm2bQZYZMbGtrPP8nwg34fTzXILR5nfDKKwZZG6eGerpmVK022J";
                string senderId = "216571546907";
                WebRequest tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");
                tRequest.Method = "post";
                tRequest.ContentType = "application/json";
                /*   var data = new
                   {
                       //    to=" / topics / foo - bar"
                       to = "/ topics /" + news",
                     notification = new
                     {
                         body = "aaaaa",
                         title = "bbbbbb",
                     }
                   };*/
                string json = "{\"to\": \"/topics/news\",\"notification\": {\"body\": \"New news added in application!\",\"title\":\" nnnnnnn \",}}";

                var serializer = new JavaScriptSerializer();
                //  var json = serializer.Serialize(data);
                Byte[] byteArray = Encoding.UTF8.GetBytes(json);
                tRequest.Headers.Add(string.Format("Authorization: key={0}", applicationID));
                tRequest.Headers.Add(string.Format("Sender: id={0}", senderId));
                tRequest.ContentLength = byteArray.Length;
                using (Stream dataStream = tRequest.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                    using (WebResponse tResponse = tRequest.GetResponse())
                    {
                        using (Stream dataStreamResponse = tResponse.GetResponseStream())
                        {
                            using (StreamReader tReader = new StreamReader(dataStreamResponse))
                            {
                                String sResponseFromServer = tReader.ReadToEnd();
                                string str = sResponseFromServer;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }
            Response.Write("succ");
        }
    }
}
        



        /*

            //   public AndroidFCMPushNotificationStatus SendNotification(string serverApiKey, string senderId, string deviceId, string message)
            //    {
        //    FirebaseMessaging.getInstance().subscribeToTopic("news");

         //   public String SendNotificationFromFirebaseCloud()
          //  {
                var result = "-1";
                var webAddr = "https://fcm.googleapis.com/fcm/send";

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Headers.Add("Authorization:key=" + "AAAAq5C8lR0:APA91bG08lmhVu0pP4BOG770ASy87XIcrCcAk5FpuKWe1t2UC0xaxGdWReQqCriFj4MDI0FkawNFXecQvLcqEBxxC-MjKXX61PHYp1FRu57BjXlUngV1i-aNTfFjeOJ81xu9_yJ80Dp3");
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"to\": \"/topics/news\",\"data\": {\"message\": \"This is a Firebase Cloud Messaging Topic Message!\",}}";


                    streamWriter.Write(json);
                    streamWriter.Flush();
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

            //    return result;
            } }  }*/