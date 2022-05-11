<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="department.aspx.cs" Inherits="orgproject.department" %>

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
                <asp:TextBox ID="txtdeptid" placeholder="dept id" runat="server"></asp:TextBox>
                <asp:TextBox ID="txtdeptname" placeholder="dept name"   runat="server"></asp:TextBox>
                 <asp:DropDownList ID="ddllocation" runat="server" Height="16px" Width="238px" OnSelectedIndexChanged="ddllocation_SelectedIndexChanged"></asp:DropDownList>
                <asp:Button ID="btnLogin" runat="server" Text="save" BackColor="Green" ForeColor="White" OnClick="btnSave_Click" />
            </div>
        </div>
    </form>
</body>
</html>