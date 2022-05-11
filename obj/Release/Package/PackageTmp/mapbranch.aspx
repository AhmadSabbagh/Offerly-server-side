<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mapbranch.aspx.cs" Inherits="orgproject.mapbranch" %>

<!DOCTYPE html>
 <style>
    .button {
  padding: 15px 25px;
  font-size: 24px;
  text-align: center;
  cursor: pointer;
  outline: none;
  color: #fff;
  background-color: #4CAF50;
  border: none;
  border-radius: 15px;
  box-shadow: 0 9px #999;
}

.button:hover {background-color: #3e8e41}

.button:active {
  background-color: #3e8e41;
  box-shadow: 0 5px #666;
  transform: translateY(4px);
}
</style>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="content-type" content="text/html; charset=UTF-8" />
    <title>Google Maps</title>
    <script src="http://maps.google.com/maps/api/js?key=AIzaSyD_xWYindJLkn5Um7w4ZlZvqYUaeocJBMY"
        type="text/javascript"></script>
</head>
<body>
   
    <form id="form1" runat="server">
   
    <script type="text/javascript">
        window.onload = function () {
            var mapOptions = {
                center: new google.maps.LatLng(32.0163909416, 35.866327285),
                zoom: 14,
                mapTypeId: google.maps.MapTypeId.ROADMAP
            };
            var infoWindow = new google.maps.InfoWindow();
            var latlngbounds = new google.maps.LatLngBounds();
            var map = new google.maps.Map(document.getElementById("dvMap"), mapOptions);
            google.maps.event.addListener(map, 'click', function (e) {
               // alert("Latitude: " + e.latLng.lat() + "\r\nLongitude: " + e.latLng.lng());
              // alert('#TextBox1').val(e.latLng.lat());
                var x = e.latLng.lat();
                document.getElementById("latitude").value = e.latLng.lat();
                document.getElementById("longitude").value = e.latLng.lng();
             
                
            });           
        }
    </script>
        <asp:TextBox ID="latitude" runat="server"></asp:TextBox>
        <asp:TextBox ID="longitude" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="تثبيت الموقع" OnClick="Button1_Click" />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <div id="dvMap" style="width: 500px; height: 500px">
    </div>
    </form>
</body>
</html>


