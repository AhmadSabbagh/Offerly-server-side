<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="defult.aspx.cs" Inherits="orgproject.defult" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">



        <div class="login-page">
           <asp:Label ID="fullname" runat="server" Text="fullname" BackColor="Green" ForeColor="White"  />
            <div class="form">
            
               <asp:Button ID="btnlocation" runat="server" Text="location" BackColor="Green" ForeColor="White"  />
                 <asp:Button ID="btndepaetment" runat="server" Text="department" BackColor="Green" ForeColor="White"  />
                <asp:Button ID="btnemployee" runat="server" Text="employee" BackColor="Green" ForeColor="White" PostBackUrl="~/employee.aspx" OnClick="btnemployee_Click1"  />
                 <asp:Button ID="btnusers" runat="server" Text="users" BackColor="Green" ForeColor="White"  />
            </div>
        </div>



    </form>
</body>
</html>
