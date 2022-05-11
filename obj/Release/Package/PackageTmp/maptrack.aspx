<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="maptrack.aspx.cs" Inherits="orgproject.maptrack" %>

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
<head runat="server">
    <title></title>
<script type="text/javascript" src="http://maps.googleapis.com/maps/api/js?key=AIzaSyD_xWYindJLkn5Um7w4ZlZvqYUaeocJBMY"></script>
    </head>
<body>
    
    <form id="form1" runat="server">
<script type="text/javascript">
var markers = [
<asp:Repeater ID="rptMarkers" runat="server">
<ItemTemplate>
            {
            "title": '<%# Eval("email") %>',
            "lat": '<%# Eval("Latitude") %>',
            "lng": '<%# Eval("Longitude") %>',
            "description": '<%# Eval("phone") %>'
        }
</ItemTemplate>
<SeparatorTemplate>
    ,
</SeparatorTemplate>
</asp:Repeater>
];
</script>
<script type="text/javascript">
    window.onload = function () {
        var mapOptions = {
            center: new google.maps.LatLng(markers[0].lat, markers[0].lng),
            zoom: 8,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        };
        var infoWindow = new google.maps.InfoWindow();
        var map = new google.maps.Map(document.getElementById("dvMap"), mapOptions);
        for (i = 0; i < markers.length; i++) {
            var data = markers[i]
            var myLatlng = new google.maps.LatLng(data.lat, data.lng);
            var marker = new google.maps.Marker({
                position: myLatlng,
                map: map,
                title: data.title
            });
            (function (marker, data) {
                google.maps.event.addListener(marker, "click", function (e) {
                    infoWindow.setContent(data.description);
                    infoWindow.open(map, marker);
                });
            })(marker, data);
        }
    }
</script>
<asp:Button ID="Button1" runat="server" Text="الصفحة الرئيسية" OnClick="Button1_Click" />
<asp:Button ID="Button2" runat="server" Text="تقديم عرض لعميل " OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" Text="خروج" OnClick="Button3_Click" />
<div id="dvMap" style="width: 1200px; height: 600px">
</div>
        </form>
    </body>
</html>