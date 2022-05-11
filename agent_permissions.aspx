<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="agent_permissions.aspx.cs" Inherits="orgproject.agent_permissions" %>
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
        <p>
            <table style="width: 100%">
                <tr>
                    <td class="align-right" colspan="3" style="font-size: large">&#1575;&#1582;&#1584; &#1608;&#1575;&#1593;&#1591;&#1575;&#1569; &#1589;&#1604;&#1575;&#1581;&#1610;&#1575;&#1578; &#1604;&#1593;&#1605;&#1610;&#1604; &#1605;&#1581;&#1583;&#1583; </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:DropDownList ID="DropDownList1" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td class="align-right" style="font-size: medium">&#1575;&#1582;&#1578;&#1585; &#1575;&#1604;&#1593;&#1605;&#1610;&#1604; &#1604;&#1578;&#1593;&#1583;&#1610;&#1604; &#1589;&#1604;&#1575;&#1581;&#1610;&#1575;&#1578;&#1607;</td>
                </tr>
                <tr>
                    <td class="align-right" colspan="2">
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="Grant" TextAlign="Left" />
                    </td>
                    <td class="align-right" style="font-size: medium">&#1575;&#1590;&#1575;&#1601;&#1577; &#1593;&#1585;&#1590; </td>
                </tr>
                <tr>
                    <td class="align-right" colspan="2">
                        <asp:CheckBox ID="CheckBox3" runat="server" Text=" " />
                    </td>
                    <td class="align-right" style="font-size: medium">&#1578;&#1593;&#1583;&#1610;&#1604; &#1575;&#1604;&#1576;&#1610;&#1575;&#1606;&#1575;&#1578; &#1575;&#1604;&#1588;&#1582;&#1589;&#1610;&#1577; </td>
                </tr>
                <tr>
                    <td class="align-right" colspan="2">
                        <asp:CheckBox ID="CheckBox5" runat="server" Text=" " />
                    </td>
                    <td class="align-right" style="font-size: medium">&#1575;&#1590;&#1575;&#1601;&#1577; &#1582;&#1576;&#1585;</td>
                </tr>
                <tr>
                    <td class="align-right" colspan="2">
                        <asp:CheckBox ID="CheckBox7" runat="server" Text=" " />
                    </td>
                    <td class="align-right" style="font-size: medium">&#1581;&#1584;&#1601; &#1593;&#1585;&#1590;&nbsp; </td>
                </tr>
                <tr>
                    <td class="align-right" colspan="2">
                        <asp:CheckBox ID="CheckBox9" runat="server" Text=" " />
                    </td>
                    <td class="align-right" style="font-size: medium">&#1578;&#1593;&#1583;&#1610;&#1604; &#1575;&#1604;&#1593;&#1585;&#1608;&#1590;</td>
                </tr>
                <tr>
                    <td class="align-right">
                        &nbsp;</td>
                    <td class="align-right">
                        <asp:CheckBox ID="CheckBox11" runat="server" Text=" " />
                    </td>
                    <td class="align-right" style="font-size: medium">&#1605;&#1588;&#1575;&#1607;&#1583;&#1577; &#1593;&#1583;&#1583; &#1575;&#1604;&#1575;&#1588;&#1582;&#1575;&#1589; &#1575;&#1604;&#1583;&#1575;&#1582;&#1604;&#1610;&#1606; &#1593;&#1604;&#1609; &#1575;&#1604;&#1575;&#1593;&#1604;&#1575;&#1606; &#1608;&#1575;&#1604;&#1593;&#1585;&#1590;</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;</td>
                    <td>&#1575;&#1592;&#1607;&#1575;&#1585; &#1575;&#1604;&#1589;&#1604;&#1575;&#1581;&#1610;&#1575;&#1578; &#1604;&#1593;&#1605;&#1610;&#1604; </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList2" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>
        </p>
        <p>
            <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
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
        </p>
        <p>
            <br />
        </p>
    </form>
</asp:Content>
