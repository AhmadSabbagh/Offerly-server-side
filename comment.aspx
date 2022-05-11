<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="comment.aspx.cs" Inherits="orgproject.comment" %>
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
                <td class="align-right">
                    &nbsp;</td>
                <td>
                    <asp:DropDownList ID="DropDownList2" runat="server">
                        <asp:ListItem Value="1">&#1578;&#1593;&#1604;&#1610;&#1602; &#1593;&#1604;&#1609; &#1593;&#1605;&#1610;&#1604;</asp:ListItem>
                        <asp:ListItem Value="2">&#1578;&#1593;&#1604;&#1610;&#1602; &#1593;&#1604;&#1609; &#1593;&#1585;&#1590;</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="align-right">
                    <asp:Button class="button" ID="Button1" runat="server" Height="36px" Text="&#1575;&#1604;&#1578;&#1593;&#1604;&#1610;&#1602;&#1575;&#1578; &#1575;&#1604;&#1605;&#1579;&#1576;&#1578;&#1607;" Width="127px" OnClick="Button1_Click" CssClass="button" />
                </td>
                <td>
                    <asp:Button class="button" ID="Button2" runat="server" Height="36px" Text="&#1575;&#1604;&#1578;&#1593;&#1604;&#1610;&#1602;&#1575;&#1578; &#1601;&#1610; &#1581;&#1575;&#1604;&#1577; &#1575;&#1604;&#1575;&#1606;&#1578;&#1592;&#1575;&#1585;" Width="127px" OnClick="Button2_Click" CssClass="button" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="align-right">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                    <asp:Button class="button" ID="Button3" runat="server" OnClick="Button3_Click" Text="&#1581;&#1584;&#1601;" />
                    <asp:Button class="button" ID="Button4" runat="server" OnClick="Button4_Click" Text="&#1605;&#1608;&#1575;&#1601;&#1602;&#1577;" />
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="170px">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        <p>
        <br />
    </p>
    </form>
</asp:Content>
