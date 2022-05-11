<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="hot_event.aspx.cs" Inherits="orgproject.hot_event" %>
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

    <div class="form">
        <br />
        <table style="width: 100%; height: 423px">
            <tr>
                <td class="align-right" colspan="2" style="font-size: x-large"><strong>&nbsp;Hot events &#1606;&#1592;&#1575;&#1605;&nbsp; </strong></td>
            </tr>
            <tr>
                <td class="align-right">
                    <asp:TextBox ID="TextBox1"  runat="server" Height="21px" Width="135px"></asp:TextBox>
                </td>
                <td class="align-right" style="font-size: large">&#1575;&#1587;&#1605; &#1575;&#1604;&#1606;&#1588;&#1575;&#1591; </td>
            </tr>
            <tr>
                <td class="align-right">
                    <asp:TextBox ID="TextBox11"  runat="server" TextMode="MultiLine" Width="341px"></asp:TextBox>
                </td>
                <td class="align-right" style="font-size: large">&#1608;&#1589;&#1601; &#1575;&#1604;&#1606;&#1588;&#1575;&#1591;</td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Label ID="Label1" runat="server" Font-Size="Large" ForeColor="Red"></asp:Label>
                    &nbsp;&nbsp;<asp:Button ID="Button1" runat="server" style="font-size: medium" Text="&#1593;&#1585;&#1590;" OnClick="Button1_Click" CssClass="button" />
                    <asp:Button ID="Button2" runat="server" style="font-size: medium" Text="&#1581;&#1584;&#1601;" OnClick="Button2_Click" CssClass="button" />
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" style="font-size: medium" Text="&#1573;&#1590;&#1575;&#1601;&#1577;" CssClass="button" />
                </td>
            </tr>
        </table>
        <br />
        <table style="width: 100%">
            <tr>
                <td>&nbsp;</td>
                <td class="align-right">
                    <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="&#1581;&#1584;&#1601;" CssClass="button" />
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="&#1593;&#1585;&#1590;" CssClass="button" />
                    <asp:DropDownList ID="DropDownList2" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="align-right">
                    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:TextBox ID="TextBox12" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
        </table>
<br />
<br />
<br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
<br />
   </div>

    </form>

</asp:Content>
