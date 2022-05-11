<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="employee.aspx.cs" Inherits="orgproject.employee" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/Style.css" rel="stylesheet" />
    <script src="js/script.js"></script>
    <style type="text/css">
        .auto-style1 {
            width: 70%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-page">
            <div class="form">
                <asp:TextBox ID="txtemployeeid" placeholder="Employee ID"  runat="server"></asp:TextBox>
                <asp:TextBox ID="txtemployeename" placeholder="Employee Name" runat="server"></asp:TextBox>
                <asp:TextBox ID="txtsalary" placeholder="Employee Salary"   runat="server"></asp:TextBox>
                <br />

                <table class="auto-style1">
                    <tr>
                        <td>

                <asp:RadioButton ID="rdoMale" runat="server" Text="Male" Checked="True" GroupName="G" />
                        </td>
                        <td>
                <asp:RadioButton ID="rdoFemale" runat="server" Text="Female" GroupName="G" />
                        </td>
                    </tr>
                </table>
                <br />
                <asp:DropDownList ID="ddlDeprtment" runat="server" Height="16px" Width="238px"></asp:DropDownList>
                <asp:Button ID="btnSave" runat="server" Text="Save" BackColor="Green" ForeColor="White" OnClick="btnSave_Click"  />
                <asp:Button ID="btnedit" runat="server" Text="edit" BackColor="Green" ForeColor="White" OnClick="btnedit_Click"  />
                <asp:Button ID="btnremove" runat="server" Text="remove" BackColor="Green" ForeColor="White" OnClick="btnremove_Click"  />
            </div>
        </div>

        <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
        </asp:GridView>
    </form>
</body>
</html>

