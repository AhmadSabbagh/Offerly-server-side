<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="picture.aspx.cs" Inherits="orgproject.picture" %>

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
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en" lang="en">
<head>
<title>Offerly</title>
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
        .auto-style5 {
            height: 46px;
        }
        sub {
        }
        .auto-style6 {
            font-size: large;
            text-align: center;
        }
        .auto-style7 {
            width: 311px;
        }
        .auto-style8 {
            height: 1316px;
            width: 66%;
        }
        .auto-style10 {
            width: 127px;
            height: 30px;
        }
        .auto-style11 {
            font-size: x-large;
            text-align: center;
        }
        .auto-style12 {
            font-size: large;
            text-align: right;
        }
        .auto-style13 {
            width: 127px;
            font-size: large;
            text-align: right;
        }
        .auto-style14 {
            font-size: large;
        }
        .auto-style15 {
            width: 100%;
            border: 1px solid #00FFFF;
            height: 110px;
        }
        .auto-style16 {
            text-align: right;
            height: 30px;
        }
        .auto-style17 {
            width: 96%;
            border: 2px solid #FF0000;
        }
        .auto-style18 {
            height: 30px;
        }
        .auto-style21 {
            font-size: large;
            text-align: right;
            width: 76px;
        }
        .auto-style23 {
            font-size: large;
            text-align: right;
            height: 30px;
        }
        .auto-style24 {
            width: 311px;
            text-align: right;
        }
        .auto-style25 {
            width: 311px;
            font-size: x-large;
            text-align: right;
        }
        .auto-style27 {
            width: 969px;
            text-align: right;
        }
        .auto-style28 {
            height: 43px;
        }
        .auto-style29 {
            font-size: large;
            text-align: right;
            width: 76px;
            height: 43px;
        }
        .auto-style30 {
            height: 43px;
            text-align: right;
        }
        .auto-style31 {
            width: 100%;
            border: 2px solid #0000FF;
        }
        .auto-style32 {
            width: 100%;
        }
        .auto-style33 {
            width: 95%;
            border: 2px solid #0000FF;
        }

        p.round3 {
    border: 2px solid red;
    border-radius: 12px;
}
        #rcorners2 {
    border-radius: 25px;
    border: 2px solid #73AD21;
    padding: 20px; 
    width: 200px;
    height: 150px;    
}
        .auto-style35 {
            text-align: center;
            height: 30px;
        }
        .auto-style36 {
            width: 311px;
            text-align: right;
            font-size: large;
        }
        h2 {
    font-size: 20px;
    font-family: "Times New Roman", Times, serif;
    font-weight: lighter;
}

    </style>
    
</head>
<body>
    <form id="form1" runat="server" enctype="multipart/form-data">
<div id="wrap">
  <div id="header" class="auto-style1">
    <h1 id="logo-text"> offerly  </h1>
    <h2 id="slogan">...</h2>
    <div id="header-links">
      <p> <a href="Home.aspx">&#1575;&#1604;&#1585;&#1574;&#1610;&#1587;&#1610;&#1607;</a> | <a href="Home1.aspx">English</a> | <a href="Login.aspx">&#1582;&#1585;&#1608;&#1580;</a> </p>
    </div>
  </div>
  <div  id="menu">
    <ul class="auto-style5">
      <li id="current"><a href="Home.aspx">&#1581;&#1608;&#1604; &#1575;&#1604;&#1605;&#1608;&#1602;&#1593;</a></li>
      <li><a href="suggestion_complint.aspx">&#1575;&#1604;&#1588;&#1603;&#1575;&#1608;&#1610;</a></li>
      <li><a href="statistics.aspx">&#1575;&#1581;&#1589;&#1575;&#1574;&#1610;&#1575;&#1578;</a></li>
      <li><a href="agent_permissions.aspx">&#1589;&#1604;&#1575;&#1581;&#1610;&#1575;&#1578; &#1575;&#1604;&#1593;&#1605;&#1604;&#1575;&#1569;</a></li>
      <li><a href="Home.aspx">&#1581;&#1587;&#1600;&#1600;&#1600;&#1575;&#1576;&#1610;</a></li>
      <li class="last"><a href="Home.aspx">&#1575;&#1604;&#1585;&#1574;&#1610;&#1587;&#1610;&#1607;</a></li>
    </ul>
  </div>
  <div id="content-wrap">
    <div id="sidebar">
      
     
      
     <ul class="sidemenu">
        <li><a href="statistics.aspx"><h2>قائمة الاحصائيات</h2></a></li>
        <li><a href="advert.aspx"><h2>نظام الاعلانات المنبثقه</h2></a></li>
        <li><a href="tracking.aspx"><h2>نظام تتبع الزبون</h2></a></li>
        <li><a href="hot_offer.aspx"> <h2>hot offer اضافة</h2></a></li>
        <li><a href="hot_event.aspx"> <h2>hot event اضافة</h2></a></li>
        <li><a href="register.aspx"><h2>ادراة حسابات العملاء</h2></a> </li>
        <li><a href="customer_classification1.aspx"><h2>نظام تصنيف الزبائن</h2></a></li>
        <li><a href="agent_offer.aspx"><h2>ادارة عروض العملاء</h2></a></li>
        <li><a href="admin.aspx"><h2>حسابات الاداره</h2></a></li>
        <li><a href="comment.aspx"><h2>التعليقات والتقييم</h2></a></li>
        <li><a href="dragdata.aspx"><h2>نظام البيانات وتفصيلها</h2></a></li>
     
        <li><a href="brithday_offer.aspx"><h2>نظام اعياد الميلاد </h2></a> </li>
        <li><a href="brithday_offer.aspx"><h2>نظام اعياد الزواج</h2></a> </li>
        <li><a href="maptrack.aspx"><h2>تتبع الزبائن على الخريطه</h2></a> </li>
        <li><a href="picture.aspx"><h2>اضافة صور</h2></a></li>
        <li><a href="offermap.aspx"><h2>ارسال عرض للزبون حسب الموقع الجغرافي</h2></a> </li>
        <li><a href="point_customer.aspx"><h2>نظام النقاط للزبائن</h2></a> </li>
          <li><a href="Categorieagent.aspx"><h2>نظام تصنيف العملاء</h2></a> </li>
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
          <p class="auto-style3">&nbsp;</p>
          <p class="auto-style3">&nbsp;</p>
      </div>
    </div>
    <div id="main" class="auto-style8"> 
       
        
        
        <table  align="right" class="auto-style31">
            <tr>
                <td class="auto-style6" colspan="2"><strong>&#1573;&#1590;&#1575;&#1601;&#1577; &#1589;&#1608;&#1585;&#1577; &#1604;&#1571;&#1593;&#1604;&#1575;&#1606; &#1605;&#1593;&#1610;&#1606; </strong></td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:DropDownList ID="DropDownList1" runat="server" Font-Names="Times New Roman" Font-Size="Medium" ForeColor="Black" Height="30px" Width="209px" Font-Bold="True">
                    </asp:DropDownList>
                </td>
                <td class="auto-style24"><span class="auto-style14">&#1575;&#1604;&#1575;&#1593;&#1604;&#1575;&#1606;</span> </td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:FileUpload ID="FileUpload1" runat="server" BorderColor="#0000CC" />
                </td>
                <td class="auto-style25">&#1575;&#1604;&#1589;&#1608;&#1585;&#1577; </td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:Label ID="Label1" runat="server" BackColor="White" BorderColor="White" Font-Size="Medium" ForeColor="#0000CC"></asp:Label>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="&#1575;&#1590;&#1575;&#1601;&#1577; " BackColor="Lime" BorderColor="#0000CC" Font-Bold="True" Font-Italic="False" Font-Names="Times New Roman" Font-Size="Medium" Width="54px" />
                </td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <table class="auto-style17">
            <tr>
                <td class="auto-style11" colspan="4"><strong>Agent</strong></td>
            </tr>
            <tr>
                <td class="auto-style35" colspan="4">
                    <asp:DropDownList ID="DropDownList6" runat="server" Font-Names="Times New Roman" Font-Size="Medium" Height="30px" Width="232px" Font-Bold="True">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style23" colspan="2">&#1575;&#1590;&#1575;&#1601;&#1577; &#1589;&#1608;&#1585; &#1604;&#1604;&#1593;&#1605;&#1610;&#1604;</td>
                <td class="auto-style23" colspan="2" style="border-left-style: solid; border-left-color: #FF0000; border-left-width: medium;">&#1575;&#1590;&#1575;&#1601;&#1577; &#1589;&#1608;&#1585;&#1577; &#1575;&#1604;&#1593;&#1605;&#1610;&#1604; &#1575;&#1604;&#1588;&#1582;&#1589;&#1610;&#1577;</td>
            </tr>
            <tr>
                <td class="align-left">
                    <asp:FileUpload ID="FileUpload6" runat="server" BorderColor="Red" Width="150px" Height="24px" />
                </td>
                <td class="align-left"><span class="auto-style14">&#1575;&#1604;&#1589;&#1608;&#1585;&#1577;</span> </td>
                <td class="align-left" style="border-left-style: solid; border-left-color: #FF0000; border-left-width: medium;">
                    <asp:FileUpload ID="FileUpload8" runat="server" BorderColor="Red" Width="150px" Height="24px" />
                </td>
                <td><span class="auto-style14">&#1575;&#1604;&#1589;&#1608;&#1585;&#1577;</span> </td>
            </tr>
            <tr>
                <td class="align-left">
                    <asp:Label ID="Label5" runat="server" BackColor="White" Font-Names="Times New Roman" Font-Size="Medium" ForeColor="Red"></asp:Label>
                    <asp:Button ID="Button8" runat="server" BackColor="#66FF33" BorderColor="#FF3300" Font-Bold="True" Font-Italic="False" Font-Names="Times New Roman" Font-Size="Medium" OnClick="Button8_Click" Text="&#1575;&#1590;&#1575;&#1601;&#1577;" />
                </td>
                <td class="align-left">
                    &nbsp;</td>
                <td class="align-left" style="border-left-style: solid; border-left-color: #FF0000; border-left-width: medium;">
                    <asp:Label ID="Label8" runat="server" BackColor="White" Font-Names="Times New Roman" Font-Size="Medium" ForeColor="Red"></asp:Label>
                    <asp:Button ID="Button10" runat="server" BackColor="#66FF33" BorderColor="#FF3300" Font-Bold="True" Font-Italic="False" Font-Names="Times New Roman" Font-Size="Medium" OnClick="Button10_Click" Text="&#1575;&#1590;&#1575;&#1601;&#1577;" />
                </td>
                <td class="align-left">
                    &nbsp;</td>
            </tr>
        </table>
        <br />
        <table class="auto-style33">
            <tr>
                <td class="auto-style11" colspan="4"><strong>Hot event</strong></td>
            </tr>
            <tr>
                <td class="auto-style11" colspan="4">
                    <asp:DropDownList ID="DropDownList4" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Overline="False" Font-Size="Medium" Height="30px" Width="172px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style23" colspan="2">&#1573;&#1590;&#1575;&#1601;&#1577; &#1589;&#1608;&#1585; &#1604;&#1604;&#1581;&#1601;&#1604; &#1575;&#1608; &#1575;&#1604;&#1606;&#1588;&#1575;&#1591; </td>
                <td class="auto-style23" colspan="2" style="border-width: thin thin thin medium; border-color: #FFFFFF #FFFFFF #FFFFFF #0000FF">&#1575;&#1590;&#1575;&#1601;&#1577; &#1589;&#1608;&#1585;&#1577; &#1575;&#1604;&#1606;&#1588;&#1575;&#1591; &#1608;&#1575;&#1604;&#1578;&#1608;&#1590;&#1610;&#1581; </td>
            </tr>
            <tr>
                <td>
                    <asp:FileUpload ID="FileUpload4" runat="server" BorderColor="#0000CC" Width="178px" />
                </td>
                <td class="align-right"><span class="auto-style14">&#1575;&#1604;&#1589;&#1608;&#1585;&#1577;</span> </td>
                <td style="border-width: thin thin thin medium; border-color: #FFFFFF #FFFFFF #FFFFFF #0000FF">
                    <asp:FileUpload ID="FileUpload3" runat="server" BorderColor="#0000CC" Width="163px" />
                </td>
                <td class="auto-style13" style="border-width: thin; border-color: #FFFFFF">&#1575;&#1604;&#1589;&#1608;&#1585;&#1577; </td>
            </tr>
            <tr>
                <td class="auto-style16">
                    <asp:Label ID="Label3" runat="server" Font-Names="Times New Roman" Font-Size="Medium" ForeColor="#0000CC"></asp:Label>
                    <asp:Button ID="&#1575;&#1590;&#1575;&#1601;&#1577;" runat="server" BackColor="Lime" BorderColor="#0000CC" Font-Bold="True" Font-Names="Times New Roman" Font-Size="Medium" Height="30px" OnClick="Button6_Click" Text="&#1575;&#1590;&#1575;&#1601;&#1577;" Width="50px" />
                </td>
                <td class="auto-style18"></td>
                <td class="auto-style16" style="border-width: thin thin thin medium; border-color: #FFFFFF #FFFFFF #FFFFFF #0000FF">
                    <asp:Label ID="Label2" runat="server" Font-Names="Times New Roman" Font-Size="Medium" ForeColor="#0000CC"></asp:Label>
                    <asp:Button runat="server" BackColor="Lime" BorderColor="#0000CC" Font-Bold="True" Font-Names="Times New Roman" Font-Size="Medium" OnClick="Button5_Click" Text="&#1575;&#1590;&#1575;&#1601;&#1577;" ID="button5" />
                </td>
                <td class="auto-style10" style="border-width: thin; border-color: #FFFFFF"></td>
            </tr>
        </table>
        <br />
        <br />
        <table class="auto-style15">
            <tr>
                <td class="auto-style11" colspan="3"><strong>Hot offer </strong></td>
            </tr>
            <tr>
                <td class="align-right" colspan="2">
                    <asp:DropDownList ID="DropDownList5" runat="server" Font-Names="Times New Roman" Font-Size="Medium" Height="31px" Width="210px" Font-Bold="True">
                    </asp:DropDownList>
                </td>
                <td class="auto-style12">&#1575;&#1590;&#1575;&#1601;&#1577; &#1589;&#1608;&#1585;&#1577; &#1575;&#1604;&#1609; </td>
            </tr>
            <tr>
                <td class="auto-style16">
                    <asp:Label ID="Label4" runat="server" Font-Names="Times New Roman" Font-Size="Medium" ForeColor="#00FFCC"></asp:Label>
                    <asp:Button ID="Button7" runat="server" BackColor="Lime" BorderColor="Aqua" Font-Bold="True" Font-Names="Times New Roman" Font-Size="Medium" OnClick="Button7_Click" Text="&#1575;&#1590;&#1575;&#1601;&#1577;" />
                </td>
                <td class="auto-style16">
                    <asp:FileUpload ID="FileUpload5" runat="server" BorderColor="#00FFCC" />
                </td>
                <td class="auto-style16"><span class="auto-style14">&#1575;&#1604;&#1589;&#1608;&#1585;&#1577;</span> </td>
            </tr>
        </table>
        <br />
        <br />

        <br />
        <br />
        <br />
            

        <table align="right" style="border: thin solid #FF00FF; background-color: #C0C0C0;" class="auto-style32">
                <tr>
                    <td colspan="4" class="auto-style6"><strong>&#1575;&#1590;&#1575;&#1601;&#1577; &#1589;&#1608;&#1585; &#1604;&#1593;&#1585;&#1590; &#1605;&#1593;&#1610;&#1606; </strong> </td>
                </tr>
                <tr>
                    <td class="auto-style28">
                        <asp:DropDownList ID="DropDownList3" runat="server" Font-Names="Times New Roman" Font-Size="Medium" Height="30px" Width="168px" Font-Bold="True">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style30">
                        <asp:Button ID="Button9" runat="server" Height="23px" OnClick="Button9_Click" Text="&#1575;&#1582;&#1578;&#1585;" Width="26px" />
                    </td>
                    <td class="auto-style30">
                        <asp:DropDownList ID="DropDownList2" runat="server" Font-Names="Times New Roman" Font-Size="Medium" Height="30px" Width="143px" AutoPostBack="True" Font-Bold="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style29">&#1575;&#1604;&#1593;&#1585;&#1590; &#1604;&#1604;&#1593;&#1605;&#1610;&#1604;</td>
                </tr>
                <tr>
                    <td colspan="3" class="align-right">
                        <asp:FileUpload ID="FileUpload2" runat="server" BorderColor="#CC0099" />
                    </td>
                    <td class="auto-style21">&#1575;&#1604;&#1589;&#1608;&#1585;&#1577;</td>
                </tr>
                <tr>
                    <td colspan="2" class="auto-style16">
                        <asp:Label ID="Label6" runat="server"></asp:Label>
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="&#1575;&#1590;&#1575;&#1601;&#1577; " BackColor="Lime" BorderColor="#CC0099" />
                    </td>
                    <td colspan="2" class="auto-style18">
                        &nbsp;</td>
                </tr>
            </table>
      
        
        
      <br />

    
      <br />
      <br />
      <br />
      <br />

      <br />
      <br />
      <br />
      <br />
      <br />
      <table align="right" style="border: thin solid #FF00FF; background-color: #C0C0C0;" class="auto-style32">
                <tr>
                    <td colspan="4" class="auto-style6"><strong>&#1575;&#1590;&#1575;&#1601;&#1577; &#1589;&#1608;&#1585; &#1604;&#1582;&#1576;&#1585; &#1605;&#1593;&#1610;&#1606; </strong> </td>
                </tr>
                <tr>
                    <td class="auto-style28">
                        <asp:DropDownList ID="DropDownList7" runat="server" Font-Names="Times New Roman" Font-Size="Medium" Height="30px" Width="168px" Font-Bold="True">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style30">
                        <asp:Button ID="Button2" runat="server" Height="23px" OnClick="Button2_Click" Text="&#1575;&#1582;&#1578;&#1585;" Width="26px" />
                    </td>
                    <td class="auto-style30">
                        <asp:DropDownList ID="DropDownList8" runat="server" Font-Names="Times New Roman" Font-Size="Medium" Height="30px" Width="143px" AutoPostBack="True" Font-Bold="True" OnSelectedIndexChanged="DropDownList8_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style29">&#1575;&#1604;&#1582;&#1576;&#1585; &#1604;&#1604;&#1593;&#1605;&#1610;&#1604;</td>
                </tr>
                <tr>
                    <td colspan="3" class="align-right">
                        <asp:FileUpload ID="FileUpload7" runat="server" BorderColor="#CC0099" />
                    </td>
                    <td class="auto-style21">&#1575;&#1604;&#1589;&#1608;&#1585;&#1577;</td>
                </tr>
                <tr>
                    <td colspan="2" class="auto-style16">
                        <asp:Label ID="Label7" runat="server"></asp:Label>
                        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="&#1575;&#1590;&#1575;&#1601;&#1577; " BackColor="Lime" BorderColor="#CC0099" />
                    </td>
                    <td colspan="2" class="auto-style18">
                        &nbsp;</td>
                </tr>
            </table>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <table  align="right" class="auto-style31">
            <tr>
                <td class="auto-style6" colspan="2">sub_categorie</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:DropDownList ID="DropDownList9" runat="server" Font-Names="Times New Roman" Font-Size="Medium" ForeColor="Black" Height="30px" Width="209px" Font-Bold="True">
                    </asp:DropDownList>
                </td>
                <td class="auto-style36">sub_categorie</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:FileUpload ID="FileUpload9" runat="server" BorderColor="#0000CC" />
                </td>
                <td class="auto-style25">&#1575;&#1604;&#1589;&#1608;&#1585;&#1577; </td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:Label ID="Label9" runat="server" BackColor="White" BorderColor="White" Font-Size="Medium" ForeColor="#0000CC"></asp:Label>
                    <asp:Button ID="Button15" runat="server" OnClick="Button15_Click" Text="&#1575;&#1590;&#1575;&#1601;&#1577; " BackColor="Lime" BorderColor="#0000CC" Font-Bold="True" Font-Italic="False" Font-Names="Times New Roman" Font-Size="Medium" Width="54px" />
                </td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
      <br />
      <br />
      </div>
      <br />
  </div>
  <div id="footer">
    <p> &copy; 2017 ef="#">&#1575;&#1604;&#1575;&#1587;&#1578;&#1602;&#1585;&#1575;&#1585;</a> | Valid <a href="#">XHTML</a> | <a href="#">CSS</a> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a href="Home.aspx">&#1575;&#1604;&#1585;&#1574;&#1610;&#1587;&#1610;&#1607;</a>&nbsp;|&nbsp; <a href="#">&#1578;&#1608;&#1575;&#1589;&#1604; &#1605;&#1593;&#1606;&#1575;</a>&nbsp;|&nbsp; <a href="Login.aspx">&#1582;&#1585;&#1608;&#1580;</a> </p>
  </div>
</div>
    </form>
</body>
</html>

