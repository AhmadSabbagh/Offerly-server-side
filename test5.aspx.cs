using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace orgproject
{

    public partial class test5 : System.Web.UI.Page
    {
        public class FCMResponse
        {
            public long multicast_id { get; set; }
            public int success { get; set; }
            public int failure { get; set; }
            public int canonical_ids { get; set; }
            public List<FCMResult> results { get; set; }
        }
        public class FCMResult
        {
            public string message_id { get; set; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {


         //   public static void SendPushNotification()
          //  {
                try
                {
                    string applicationID = "AAAAMmyrjRs:APA91bFSONUwykLrX5ZwllFTapXgYWq4R7Xcn1Joi_By4d0vg4D_Su3Cylnes4M9B-e-ZZ8jrSPGS1Sv7rpHEuCQ0cm2bQZYZMbGtrPP8nwg34fTzXILR5nfDKKwZZG6eGerpmVK022J";
                    string senderId = "216571546907";
                //    string deviceId = "ch_G60NPga4:APA9............T_LH8up40Ghi-J";
                    WebRequest tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");
                    tRequest.Method = "post";
                    tRequest.ContentType = "application/json";
                    var data = new
                    {
                        to =  "/ topics / news",
                     //   data = null,
                        data = new
                        {

                            body = "sssss",

                            title = "1212",


                        }
                    };

                    var serializer = new JavaScriptSerializer();
                    var json = serializer.Serialize(data);
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








                //   dal.FCMPushNotification fcmPush = new dal.FCMPushNotification();
                //    fcmPush.SendNotification("your notificatin title", "Your body message", "news");
            }
        }
}

          /*  //  Push a new record to a Firebase JSON database using the POST HTTP method.

            //  This example requires the Chilkat API to have been previously unlocked.
            //  See Global Unlock Sample for sample code.

            //  This example assumes a JWT authentication token, if required, has been previously obtained.
            //  See Get Firebase Access Token from JSON Service Account Private Key for sample code.

            //  Load the previously obtained Firebase access token into a string.
            Chilkat.FileAccess fac = new Chilkat.FileAccess();
            string accessToken = fac.ReadEntireTextFile("qa_data/tokens/firebaseToken.txt", "utf-8");
            if (fac.LastMethodSuccess != true)
            {
                Debug.WriteLine(fac.LastErrorText);
                return;
            }

            Chilkat.Rest rest = new Chilkat.Rest();

            //  Make the initial connection (without sending a request yet).
            //  Once connected, any number of requests may be sent.  It is not necessary to explicitly
            //  call Connect before each request.
            bool success = rest.Connect("chilkat.firebaseio.com", 443, true, true);
            if (success != true)
            {
                Debug.WriteLine(rest.LastErrorText);
                return;
            }

            Chilkat.AuthGoogle authGoogle = new Chilkat.AuthGoogle();
            authGoogle.AccessToken = accessToken;
            rest.SetAuthGoogle(authGoogle);

            //  Chilkat's sample data (pig-rescue data) is publicly readable at: https://chilkat.firebaseio.com/.json
            //  This data is publicly readable, but not writable.  You'll need to
            //  run against your own database..

            //  We're going to add a new pig with just the name.
            Chilkat.JsonObject pigRecord = new Chilkat.JsonObject();
            pigRecord.AppendString("name", "William");

            //  The string content of the last arg passed is  {"name":"William"}
            string jsonResponse = rest.FullRequestString("POST", "/pig-rescue/animal.json", pigRecord.Emit());
            if (rest.LastMethodSuccess != true)
            {
                //  Something happened in the communications (either no request was sent, or no response was received.
                //  (The Chilkat REST API also has lower-level methods where an app can send the request in one call,
                //  and then receive the response in another call.)
                Debug.WriteLine(rest.LastErrorText);
                return;
            }

            //  Check the response status code.   A 200 response status indicates success.
            if (rest.ResponseStatusCode != 200)
            {
                Debug.WriteLine(rest.ResponseStatusText);
                Debug.WriteLine(jsonResponse);
                Debug.WriteLine("Failed.");
                return;
            }

            //  Get the push ID generated by Firebase
            Chilkat.JsonObject resp = new Chilkat.JsonObject();
            resp.Load(jsonResponse);
            string pushId = resp.StringOf("name");
            Debug.WriteLine("Added record with push ID " + pushId);
            Debug.WriteLine("Success.");
            */