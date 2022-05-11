<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="location.aspx.cs" Inherits="orgproject.location" %>

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
                <asp:TextBox ID="txtlocid" placeholder="locid" required runat="server"></asp:TextBox>
                <asp:TextBox ID="txtlocname" placeholder="locname" required TextMode="Number" runat="server"></asp:TextBox>
                <asp:Button ID="btnLogin" runat="server" Text="save" BackColor="Green" ForeColor="White" OnClick="btnLogin_Click" />
            </div>
        </div>
    </form>
</body>
</html>