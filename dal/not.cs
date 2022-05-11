using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace orgproject.dal
{
    public class not
    {
        public void SendNotificationFromFirebaseCloud()
        {
            /*      var result = "-1";
                  var webAddr = "https://fcm.googleapis.com/fcm/send";
                  var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
                  httpWebRequest.ContentType = "application/json";
                  httpWebRequest.Headers.Add("AAAAMmyrjRs:APA91bFSONUwykLrX5ZwllFTapXgYWq4R7Xcn1Joi_By4d0vg4D_Su3Cylnes4M9B-e-ZZ8jrSPGS1Sv7rpHEuCQ0cm2bQZYZMbGtrPP8nwg34fTzXILR5nfDKKwZZG6eGerpmVK022J");
                  httpWebRequest.Method = "POST";

                  using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                  {
                      string json = "{\"to\": \"/topics/news\",\"notification\": {\"body\": \"New news added in application!\",\"title\":\" nnnnnnn \",}}";
                      streamWriter.Write(json);
                      streamWriter.Flush();
                  }

                  var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                  using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                  {
                      result = streamReader.ReadToEnd();
                  }
                  // return result;
                  var json = Newtonsoft.Json.JsonConvert.SerializeObject(new
                  {
                      name = "new ",
                      value = "16",
                  }
                      );
                  var request = WebRequest.CreateHttp("https://awfrli-187600.firebaseio.com/,json");
                  request.Method = "POST";
                  request.ContentType = "application/json";
                  var buffer = Encoding.UTF8.GetBytes(json);
                  request.ContentLength = buffer.Length;
                  request.GetRequestStream().Write(buffer, 0, buffer.Length);
                  var response = request.GetResponse();
                  json = (new StreamReader(response.GetResponseStream())).ReadToEnd();
              }*/
        }
    }
}