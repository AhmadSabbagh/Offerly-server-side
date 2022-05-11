<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="orgproject.profile" %>

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
            width: 100%;
        }
        .auto-style5 {
            text-align: right;
            font-size: x-large;
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
      <p> <a href="profile.aspx">الرئيسيه</a> | <a href="#">اتصل بنا</a> | <a href="#">خروج</a> </p>
    </div>
  </div>
  <div  id="menu">
    <ul>
      <li id="current"><a href="Home.aspx">حول الموقع</a></li>
      <li class="last"><a href="profile.aspx">حسابي</a></li>
    </ul>
  </div>
  <div id="content-wrap">
    <div id="sidebar">
      
     
      
      <ul class="sidemenu">
        <li><a href="addofferagent.aspx"><strong>إضافة عرض </strong></a></li>
        <li><a href="addofferagent.aspx"><strong>إضافة خبر</strong></a></li>
          <li><a href="agent_offer.aspx"> <strong>حذف العروض </strong></a></li>
        <li><a href="agent_offer.aspx"> <strong>تعديل العروض</strong></a></li>
        <li><a href="statistics.aspx"><strong>الزبائن اللذين دخلو على الاعلان </strong></a> </li>
       
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
        <table class="auto-style4">
            <tr>
                <td class="auto-style5">
                    <address>
                        معلومات العميل العامة
                    </address>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:companyConnectionString3 %>" DeleteCommand="DELETE FROM [agent] WHERE [agent_id] = @agent_id" InsertCommand="INSERT INTO [agent] ([name], [password], [phone], [brith_day], [address], [city], [cat_id]) VALUES (@name, @password, @phone, @brith_day, @address, @city, @cat_id)" SelectCommand="SELECT agent.agent_id, agent.name, agent.phone, agent.brith_day, agent.address, agent.city, categories.cat_name FROM agent INNER JOIN categories ON agent.cat_id = categories.cat_id WHERE (agent.agent_id = @agent_id)" UpdateCommand="UPDATE [agent] SET [name] = @name, [password] = @password, [phone] = @phone, [brith_day] = @brith_day, [address] = @address, [city] = @city, [cat_id] = @cat_id WHERE [agent_id] = @agent_id">
                        <DeleteParameters>
                            <asp:Parameter Name="agent_id" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="name" Type="String" />
                            <asp:Parameter Name="password" Type="String" />
                            <asp:Parameter Name="phone" Type="String" />
                            <asp:Parameter Name="brith_day" Type="String" />
                            <asp:Parameter Name="address" Type="String" />
                            <asp:Parameter Name="city" Type="String" />
                            <asp:Parameter Name="cat_id" Type="Int32" />
                        </InsertParameters>
                        <SelectParameters>
                            <asp:QueryStringParameter Name="agent_id" QueryStringField="id" Type="Int32" />
                        </SelectParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="name" Type="String" />
                            <asp:Parameter Name="password" Type="String" />
                            <asp:Parameter Name="phone" Type="String" />
                            <asp:Parameter Name="brith_day" Type="String" />
                            <asp:Parameter Name="address" Type="String" />
                            <asp:Parameter Name="city" Type="String" />
                            <asp:Parameter Name="cat_id" Type="Int32" />
                            <asp:Parameter Name="agent_id" Type="Int32" />
                        </UpdateParameters>
                    </asp:SqlDataSource>
                    <asp:FormView ID="FormView1" runat="server" CellPadding="4" DataKeyNames="agent_id" DataSourceID="SqlDataSource1" ForeColor="#333333">
                        <EditItemTemplate>
                            agent_id:
                            <asp:Label ID="agent_idLabel1" runat="server" Text='<%# Eval("agent_id") %>' />
                            <br />
                            name:
                            <asp:TextBox ID="nameTextBox" runat="server" Text='<%# Bind("name") %>' />
                            <br />
                           
                            phone:
                            <asp:TextBox ID="phoneTextBox" runat="server" Text='<%# Bind("phone") %>' />
                            <br />
                            brith_day:
                            <asp:TextBox ID="brith_dayTextBox" runat="server" Text='<%# Bind("brith_day") %>' />
                            <br />
                            address:
                            <asp:TextBox ID="addressTextBox" runat="server" Text='<%# Bind("address") %>' />
                            <br />
                            city:
                            <asp:TextBox ID="cityTextBox" runat="server" Text='<%# Bind("city") %>' />
                            <br />
                            cat_id:
                            <asp:TextBox ID="cat_idTextBox" runat="server" Text='<%# Bind("cat_name") %>' />
                            <br />
                            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                        </EditItemTemplate>
                        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <InsertItemTemplate>
                            name:
                            <asp:TextBox ID="nameTextBox" runat="server" Text='<%# Bind("name") %>' />
                            <br />
                            password:
                            <asp:TextBox ID="passwordTextBox" runat="server" Text='<%# Bind("password") %>' />
                            <br />
                            phone:
                            <asp:TextBox ID="phoneTextBox" runat="server" Text='<%# Bind("phone") %>' />
                            <br />
                            brith_day:
                            <asp:TextBox ID="brith_dayTextBox" runat="server" Text='<%# Bind("brith_day") %>' />
                            <br />
                            address:
                            <asp:TextBox ID="addressTextBox" runat="server" Text='<%# Bind("address") %>' />
                            <br />
                            city:
                            <asp:TextBox ID="cityTextBox" runat="server" Text='<%# Bind("city") %>' />
                            <br />
                            cat_id:
                            <asp:TextBox ID="cat_idTextBox" runat="server" Text='<%# Bind("cat_id") %>' />
                            <br />
                            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                        </InsertItemTemplate>
                        <ItemTemplate>
                            agent_id:
                            <asp:Label ID="agent_idLabel" runat="server" Text='<%# Eval("agent_id") %>' />
                            <br />
                            name:
                            <asp:Label ID="nameLabel" runat="server" Text='<%# Bind("name") %>' />
                            <br />
                            
                        
                            phone:
                            <asp:Label ID="phoneLabel" runat="server" Text='<%# Bind("phone") %>' />
                            <br />
                            brith_day:
                            <asp:Label ID="brith_dayLabel" runat="server" Text='<%# Bind("brith_day") %>' />
                            <br />
                            address:
                            <asp:Label ID="addressLabel" runat="server" Text='<%# Bind("address") %>' />
                            <br />
                            city:
                            <asp:Label ID="cityLabel" runat="server" Text='<%# Bind("city") %>' />
                            <br />
                            cat_id:
                            <asp:Label ID="cat_idLabel" runat="server" Text='<%# Bind("cat_name") %>' />
                            <br />
                            <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
                             </ItemTemplate>
                        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    </asp:FormView>
                </td>
            </tr>
        </table>
        <br />
        <br />
        
        
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


   
