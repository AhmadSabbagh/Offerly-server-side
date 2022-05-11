<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="orgproject.product" %>

<!DOCTYPE html>




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
        h2 {
    font-size: 20px;
    font-family: "Times New Roman", Times, serif;
    font-weight: lighter;
}
        h1 {
    font-size: 40px;
}
        .auto-style4 {
            font-size: large;
            text-align: left;
        }
        .auto-style5 {
            width: 61px;
        }
        .auto-style6 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" enctype="multipart/form-data">
<div id="wrap">
  <div id="header" class="auto-style1">
    <h1 id="logo-text"> Offerly  </h1>
    <h2 id="slogan">...</h2>
    <div id="header-links">
      <p> <a href="Home.aspx">الرئيسيه</a> | <a href="Home1.aspx">English</a> | <a href="Login.aspx">خروج</a> </p>
    </div>
  </div>
  <div  id="menu">
    <ul>
      <li id="current"><a href="Home.aspx">حول الموقع</a></li>
      <li><a href="suggestion_complint.aspx">الشكاوي</a></li>
      <li><a href="statistics.aspx">احصائيات</a></li>
      <li><a href="agent_permissions.aspx">صلاحيات العملاء</a></li>
      <li><a href="Home.aspx">حســـابي</a></li>
      <li class="last"><a href="Home.aspx">الرئيسيه</a></li>
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
        <li><a href="product.aspx"> <h2>Product اضافة</h2></a></li>
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
      <h1>معلومات</h1>
      <div class="left-box">
        <p class="auto-style2">كتابةاي معلومات لاحقا&nbsp; </p>
          <p>ا&nbsp; </p>
        <p class="align-right">&nbsp;</p>
      </div>
      <h1>نبذه او وصف للموقع</h1>
      <div class="left-box">
        <p class="auto-style3">كتابة اي وصف لاحقا</p>
      </div>
    </div>
    <div id="main"> 
        
            
       <table style="width: 60px; height: 150px">
            <tr>
                <td class="align-right" colspan="4" style="font-size: x-large"><strong>&nbsp;<asp:Label ID="Label3" runat="server" Font-Names="Times New Roman" Text="product اضافة"></asp:Label>
                    &nbsp; &nbsp;&nbsp; </strong></td>
            </tr>
            <tr>
                <td class="align-right" colspan="3">
                    <asp:TextBox ID="TextBox2" runat="server" Height="22px" Width="120px"></asp:TextBox>
                </td>
                <td class="align-left" style="font-size: large; ">&nbsp;
                    <asp:Label ID="Label4" runat="server" Font-Names="Times New Roman" Text="اسم المنتج"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="align-right" colspan="3">
                    &nbsp;<asp:TextBox ID="TextBox5" runat="server" Height="26px" Width="120px"></asp:TextBox>
                </td>
                <td class="align-left" style="font-size: large; ">
                    <asp:Label ID="Label5" runat="server" Font-Names="Times New Roman" Text="السعر"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="align-right" colspan="3">
                    <asp:TextBox ID="TextBox4" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
                <td class="align-left" style="font-size: large; ">
                    <asp:Label ID="Label6" runat="server" Font-Names="Times New Roman" Text="معلومات عن المنتج"></asp:Label>
&nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                <td class="auto-style5" colspan="2">
                    <asp:FileUpload ID="FileUpload1" runat="server" Height="34px" />
                </td>
                <td class="align-left" style="font-size: large; ">
                    <asp:Label ID="Label7" runat="server" Font-Names="Times New Roman" Text="الصورة"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="4" style="text-align: center">
                    <asp:Label ID="Label1" runat="server" Font-Size="Large" ForeColor="Red"></asp:Label>
                    &nbsp;&nbsp;<asp:Button ID="Button4" runat="server"  style="font-size: medium" Text="&#1573;&#1590;&#1575;&#1601;&#1577;" OnClick="Button4_Click" CssClass="button" />
                </td>
            </tr>
            <tr>
                <td colspan="4" style="text-align: center">
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td colspan="4" class="align-right">
                    <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="X-Large" Text="اضافة صور لمنتج معين "></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2" class="align-right">
                    <asp:DropDownList ID="DropDownList2" runat="server" Height="18px" Width="137px" Font-Names="Times New Roman" Font-Size="Large">
                    </asp:DropDownList>
                </td>
                <td colspan="2" class="align-right">
                    <asp:Label ID="Label11" runat="server" CssClass="auto-style6" Font-Names="Times New Roman" Font-Size="Large" Text="اسم المنتج"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="4" class="align-right">
                    <asp:Label ID="Label12" runat="server" Font-Size="Large" ForeColor="Red"></asp:Label>
                    <asp:Button ID="Button6" runat="server"  style="font-size: medium" Text="&#1573;&#1590;&#1575;&#1601;&#1577;" OnClick="Button6_Click"  CssClass="button"  />
                    <asp:FileUpload ID="FileUpload2" runat="server" Height="34px" />
                </td>
            </tr>
            <tr>
                <td colspan="4" class="align-right">
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td colspan="4" class="align-right">
                    <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="X-Large" Text="product حذف"></asp:Label>
                    <strong style="font-size: x-large; text-align: right">&nbsp; &nbsp;&nbsp; </strong>
                </td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: center">
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="18px" Width="137px" Font-Names="Times New Roman" Font-Size="Large">
                    </asp:DropDownList>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="Label9" runat="server" Font-Names="Times New Roman" Text="اسم المنتج"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="4" style="text-align: center">
                    <asp:Label ID="Label2" runat="server" Font-Size="Large" ForeColor="Red"></asp:Label>
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click1" Text="حذف" CssClass="button" Width="50px" />
                </td>
            </tr>
           <tr>
               <td colspan="4" style="text-align: center">
                   <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                   </td>
               </tr>
        </table>
      <br />
    </div>
  </div>
  <div id="footer">
    <p> &copy; 2017 <strong>Your Company</strong> | Design by: <a href="#">الاستقرار</a> | Valid <a href="#">XHTML</a> | <a href="#">CSS</a> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a href="Home.aspx">الرئيسيه</a>&nbsp;|&nbsp; <a href="#">تواصل معنا</a>&nbsp;|&nbsp; <a href="Login.aspx">خروج</a> </p>
  </div>
</div>
        </form>
</body>
</html>

