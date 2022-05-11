<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="point_customer2.aspx.cs" Inherits="orgproject.point_customer2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
 <form id="form1" runat="server">
        <table style="width: 100%">
            <tr>
                <td>
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Add offers" />
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="&#1578;&#1601;&#1575;&#1589;&#1610;&#1604; &#1605;&#1585;&#1575;&#1578; &#1575;&#1604;&#1606;&#1588;&#1585; " />
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="&#1593;&#1585;&#1590; &#1575;&#1604;&#1586;&#1576;&#1575;&#1574;&#1606; &#1608;&#1605;&#1585;&#1575;&#1578; &#1575;&#1604;&#1606;&#1588;&#1585; " />
                </td>
            </tr>
        </table>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <br />
        <table align="right" style="width: 50%">
            <tr>
                <td class="align-right">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label1" runat="server" Font-Size="Medium" Text="&#1575;&#1604;&#1593;&#1585;&#1590;"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="align-right" style="height: 30px">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td style="height: 30px">
                    <asp:Label ID="Label2" runat="server" Font-Size="Medium" Text="&#1575;&#1604;&#1582;&#1589;&#1605;"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="align-right">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label3" runat="server" Font-Size="Medium" Text="&#1605;&#1585;&#1575;&#1578; &#1575;&#1604;&#1605;&#1588;&#1575;&#1585;&#1603;&#1577;"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
                <td>
                    <asp:Label ID="Label4" runat="server" Font-Size="Medium" Text="&#1575;&#1604;&#1589;&#1608;&#1585;&#1607;"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="align-right">
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="&#1575;&#1590;&#1575;&#1601;&#1577;" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
    
</asp:Content>
