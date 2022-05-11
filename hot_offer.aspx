<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="hot_offer.aspx.cs" Inherits="orgproject.hot_offer" %>
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
        <br />
        <table style="width: 100%; height: 242px">
            <tr>
                <td class="align-right" colspan="2" style="font-size: x-large"><strong>&nbsp;Hot offers &#1606;&#1592;&#1575;&#1605;&nbsp;&nbsp; </strong></td>
            </tr>
            <tr>
                <td class="align-right">
                    <asp:TextBox ID="TextBox2" runat="server" Height="39px" Width="387px" TextMode="MultiLine"></asp:TextBox>
                </td>
                <td class="align-right" style="font-size: large; text-align: center;">&#1575;&#1587;&#1605; &#1575;&#1604;&#1575;&#1593;&#1604;&#1575;&#1606;</td>
            </tr>
            <tr>
                <td class="align-right">
                    <asp:TextBox ID="TextBox4" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
                <td class="align-right" style="font-size: large; text-align: center;">&#1606;&#1589;<br />
&nbsp;&#1575;&#1604;&#1575;&#1593;&#1604;&#1575;&#1606; </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Label ID="Label1" runat="server" Font-Size="Large" ForeColor="Red"></asp:Label>
                    &nbsp;&nbsp;<asp:Button ID="Button1" runat="server" style="font-size: medium" Text="&#1593;&#1585;&#1590;" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" style="font-size: medium" Text="&#1581;&#1584;&#1601;" OnClick="Button2_Click" />
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" style="font-size: medium" Text="&#1573;&#1590;&#1575;&#1601;&#1577;" />
                </td>
            </tr>
        </table>
        <table style="width: 100%">
            <tr>
                <td style="width: 66px">&nbsp;</td>
                <td class="align-right">
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="&#1593;&#1585;&#1590;" />
                    <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="&#1581;&#1584;&#1601;" />
                    <asp:DropDownList ID="DropDownList1" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="width: 66px" class="align-right">
                    <asp:TextBox ID="TextBox3" runat="server" Height="48px" TextMode="MultiLine" Width="307px"></asp:TextBox>
                    </td>
                <td class="align-right">&nbsp;
                    <asp:Label ID="Label2" runat="server" Font-Size="Medium" Text="&#1575;&#1587;&#1605; &#1575;&#1604;&#1575;&#1593;&#1604;&#1575;&#1606;"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align: center">
                    <asp:TextBox ID="TextBox5" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
                <td style="text-align: center">
                    <asp:Label ID="Label3" runat="server" Font-Size="Medium" Text="&#1606;&#1589; &#1575;&#1604;&#1575;&#1593;&#1604;&#1575;&#1606; "></asp:Label>
                </td>
            </tr>
        </table>
<br />
<br />
<br />
<br />
    </form>

</asp:Content>
