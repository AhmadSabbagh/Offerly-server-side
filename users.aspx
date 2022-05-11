<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="users.aspx.cs" Inherits="orgproject.users" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/Style.css" rel="stylesheet" />
    <script src="js/script.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-page">
            <div class="form">
                <asp:DropDownList ID="ddluser" runat="server" Height="16px" Width="238px"></asp:DropDownList>
                <asp:TextBox ID="txtusername" placeholder="username" runat="server"></asp:TextBox>
                <asp:TextBox ID="txtpassword" placeholder="password"   runat="server"></asp:TextBox>
                <asp:Button ID="btnLogin" runat="server" Text="save" BackColor="Green" ForeColor="White" OnClick="btnSave_Click" />
            </div>
        </div>
    </form>
</body>
</html>
