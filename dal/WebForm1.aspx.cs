using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using static System.Console;

namespace orgproject.dal
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

    /// <summary>
    /// Examples
    /// </summary>
/*
 * 'Team-Awesome': {
                         'Members': {
                             'M1': {
                                 'mess': 'aaaaaa',
                                 'title': 'ccccc'
                                 },
                             'M2': {
                                 'mess': 'ccccc',
                                 'title': 'vvvvvv'
                                 },
                             'M3': {
                                 'mess': 'aaaaaa',
                                 'title': 'aaaaa'*/
     /// <summary>
     /// Main Method
     /// </summary>

         // Instanciating with base URL
         FirebaseDB firebaseDB = new FirebaseDB("https://awfrli-187600.firebaseio.com/");

         // Referring to Node with name "Teams"
         FirebaseDB firebaseDBTeams = firebaseDB.Node("Teams");

         var data = @"{
                                    'notfication': {
                                        'mess': 'aaaaaa',
                                        'title': 'ccccc'
                                        },
                                    
                        
                   }";

         WriteLine("GET Request");
         FirebaseResponse getResponse = firebaseDBTeams.Get();
         WriteLine(getResponse.Success);
         if (getResponse.Success)
             WriteLine(getResponse.JSONContent);
         WriteLine();

         WriteLine("PUT Request");
         FirebaseResponse putResponse = firebaseDBTeams.Put(data);
         WriteLine(putResponse.Success);
         WriteLine();

         WriteLine("POST Request");
         FirebaseResponse postResponse = firebaseDBTeams.Post(data);
         WriteLine(postResponse.Success);
         WriteLine();

         WriteLine("PATCH Request");
         FirebaseResponse patchResponse = firebaseDBTeams
             // Use of NodePath to refer path lnager than a single Node
             .NodePath("Team-Awesome/Members/M1")
             .Patch("{\"Designation\":\"CRM Consultant\"}");
         WriteLine(patchResponse.Success);
         WriteLine();

        // WriteLine("DELETE Request");
      //   FirebaseResponse deleteResponse = firebaseDBTeams.Delete();
      //   WriteLine(deleteResponse.Success);
     //    WriteLine();

         WriteLine(firebaseDBTeams.ToString());

         ReadLine();
     }
 }
}
