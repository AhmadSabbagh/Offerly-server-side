using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace orgproject.dal
{
    public class send
    {
        public void SendNotification()
               {


        string returnMessage = null;
        var jFCMData = new JObject();
        var jData = new JObject();
        jData.Add("message", "new hot offer");
            jData.Add("body", "new hot offer");
            jData.Add("title", "new hot offer");
            jFCMData.Add("to", "/topics/news");
            jFCMData.Add("data", jData);
            var url = new Uri("https://fcm.googleapis.com/fcm/send");
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.TryAddWithoutValidation(
                    "Authorization", "key=" + "AAAAMmyrjRs:APA91bFSONUwykLrX5ZwllFTapXgYWq4R7Xcn1Joi_By4d0vg4D_Su3Cylnes4M9B-e-ZZ8jrSPGS1Sv7rpHEuCQ0cm2bQZYZMbGtrPP8nwg34fTzXILR5nfDKKwZZG6eGerpmVK022J");
                    Task.WaitAll(client.PostAsync(url,
                    new StringContent(jFCMData.ToString(), Encoding.Default, "application/json"))
                    .ContinueWith(response =>
                    {
            returnMessage = response + "\nMessage sent";
            Console.WriteLine(jFCMData.ToString());
        }));
                }
}
            catch (Exception ex)
            {
                throw (new Exception("Unable to send GCM message:\n" + ex.StackTrace));
            }
            //  return returnMessage;
        }
    }
}