<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addofferagent.aspx.cs" Inherits="orgproject.addofferagent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en" lang="en">
<head>
<title>Envision</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<link rel="stylesheet" href="images/Envision.css" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            left: 2px;
            top: 5px;
            width: 818px;
        }
        .auto-style2 {
            height: 60px;
        }
        .auto-style3 {
            height: 106px;
        }
        .auto-style4 {
            height: 60px;
            text-align: center;
        }
        .auto-style5 {
            text-align: center;
        }
        .auto-style6 {
            width: 89%;
        }
        .auto-style7 {
            width: 91%;
            height: 283px;
        }
         
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
        .auto-style8 {
            text-align: right;
            font-size: large;
        }
    </style>
       
</head>
<body>
    <form id="form1" runat="server">
<div id="wrap">
  <div id="header" class="auto-style1">
    <h1 id="logo-text">Offerly </h1>
    <h2 id="slogan">put your site slogan here...</h2>
    <div id="header-links">
      <p> <a href="profile.aspx">&#1575;&#1604;&#1585;&#1574;&#1610;&#1587;&#1610;&#1607;</a> | <a href="#">&#1575;&#1578;&#1589;&#1604; &#1576;&#1606;&#1575;</a> | <a href="#">&#1582;&#1585;&#1608;&#1580;</a> </p>
    </div>
  </div>
  <div  id="menu">
    <ul>
      <li id="current"><a href="Home.aspx">&#1581;&#1608;&#1604; &#1575;&#1604;&#1605;&#1608;&#1602;&#1593;</a></li>
      <li class="last"><a href="profile.aspx">&#1581;&#1587;&#1575;&#1576;&#1610;</a></li>
    </ul>
  </div>
  <div id="content-wrap">
    <div id="sidebar">
      
     
      
      <ul class="sidemenu">
        <li><a href="agent_offer.aspx"><strong>&#1573;&#1590;&#1575;&#1601;&#1577; &#1593;&#1585;&#1590; </strong></a></li>
        <li><a href="agent_offer.aspx"><strong>&#1573;&#1590;&#1575;&#1601;&#1577; &#1582;&#1576;&#1585;</strong></a></li>
          <li><a href="agent_offer.aspx"> <strong>&#1581;&#1584;&#1601; &#1575;&#1604;&#1593;&#1585;&#1608;&#1590; </strong></a></li>
        <li><a href="agent_offer.aspx"> <strong>&#1578;&#1593;&#1583;&#1610;&#1604; &#1575;&#1604;&#1593;&#1585;&#1608;&#1590;</strong></a></li>
        <li><a href="statistics.aspx"><strong>&#1575;&#1604;&#1586;&#1576;&#1575;&#1574;&#1606; &#1575;&#1604;&#1604;&#1584;&#1610;&#1606; &#1583;&#1582;&#1604;&#1608; &#1593;&#1604;&#1609; &#1575;&#1604;&#1575;&#1593;&#1604;&#1575;&#1606; </strong></a> </li>
       
      </ul>
      <h1>&#1605;&#1593;&#1604;&#1608;&#1605;&#1575;&#1578;</h1>
      <div class="left-box">
        <p class="auto-style2">&#1603;&#1578;&#1575;&#1576;&#1577;&#1575;&#1610; &#1605;&#1593;&#1604;&#1608;&#1605;&#1575;&#1578; &#1604;&#1575;&#1581;&#1602;&#1575;&nbsp; </p>
          <p>&#1575;&nbsp; </p>
        <p class="align-right">&nbsp;</p>
      </div>
      <h1>&#1606;&#1576;&#1584;&#1607; &#1575;&#1608; &#1608;&#1589;&#1601; &#1604;&#1604;&#1605;&#1608;&#1602;&#1593;</h1>
      <div class="left-box">
        <p class="auto-style3">&#1603;&#1578;&#1575;&#1576;&#1577; &#1575;&#1610; &#1608;&#1589;&#1601; &#1604;&#1575;&#1581;&#1602;&#1575;</p>
      </div>
    </div>
    <div id="main"> 
        <br />
        <br />
         <table class="auto-style7">
                <tr>
                    <td colspan="3" style="font-size: x-large" class="auto-style4">&#1575;&#1590;&#1575;&#1601;&#1577; &#1593;&#1585;&#1590;</td>
                </tr>
                <tr>
                    <td colspan="3" style="font-size: x-large" class="auto-style2">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5" colspan="2">
                        <asp:TextBox ID="TextBox3" runat="server" Height="19px" Width="126px"></asp:TextBox>
                    </td>
                    <td class="align-right" style="font-size: large">&nbsp;&#1575;&#1604;&#1593;&#1585;&#1590;</td>
                </tr>
                <tr>
                    <td class="align-right" colspan="2" style="text-align: center">
                        <asp:TextBox ID="TextBox4" runat="server" Height="84px" TextMode="MultiLine" Width="343px"></asp:TextBox>
                    </td>
                    <td class="auto-style8">الوصف</td>
                </tr>
                <tr>
                    <td class="auto-style5" style="height: 30px; text-align: center;" colspan="2">
                        <asp:TextBox ID="TextBox6" runat="server" TextMode="DateTimeLocal"></asp:TextBox>
                    </td>
                    <td class="align-right" style="font-size: large; height: 30px;">&#1608;&#1602;&#1578; &#1575;&#1604;&#1576;&#1583;&#1575;&#1610;&#1577; </td>
                </tr>
                <tr>
                    <td class="align-right" style="width: 167px">
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="&#1575;&#1590;&#1575;&#1601;&#1577;" BackColor="#FF3300" BorderColor="White" ForeColor="Black" />
                    </td>
                    <td class="align-right" style="text-align: center">
                        <asp:TextBox ID="TextBox7" runat="server" TextMode="DateTimeLocal"></asp:TextBox>
                    </td>
                    <td class="align-right" style="font-size: large">&#1608;&#1602;&#1578; &#1575;&#1604;&#1606;&#1607;&#1575;&#1610;&#1577; </td>
                </tr>
                </table>


        <table align="left" aria-busy="False" class="auto-style6">
                <tr>
                    <td colspan="2" style="font-size: large; height: 44px" class="auto-style5">&#1575;&#1590;&#1575;&#1601;&#1577; &#1582;&#1576;&#1585;&nbsp; </td>
                </tr>
                <tr>
                    <td style="height: 30px">
                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    </td>
                    <td style="font-size: large; width: 89px; height: 30px;">&#1575;&#1587;&#1605; &#1575;&#1604;&#1582;&#1576;&#1585;</td>
                </tr>
                <tr>
                    <td style="height: 30px">
                        <asp:TextBox ID="TextBox1" runat="server" Height="48px" TextMode="MultiLine"></asp:TextBox>
                    </td>
                    <td style="font-size: large; width: 89px; height: 30px;">&#1575;&#1604;&#1582;&#1576;&#1585;</td>
                </tr>
                <tr>
                    <td class="align-right" colspan="2">
                        <asp:Label ID="Label2" runat="server"></asp:Label>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="&#1575;&#1590;&#1575;&#1601;&#1577;" />
                    </td>
                </tr>
                </table>
        
      <br />
    </div>
  </div>
  <div id="footer">
    <p> &copy; 2017 <strong>Your Company</strong> | Design by: <a href="#">الاستقرار</a> | Valid <a href="#">XHTML</a> | <a href="#">CSS</a> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a href="#">الرئيسيه</a>&nbsp;|&nbsp; <a href="#">تواصل معنا</a>&nbsp;|&nbsp; <a href="#">خروج</a> </p>
  </div>
</div>
    </form>
</body>
</html>


   

