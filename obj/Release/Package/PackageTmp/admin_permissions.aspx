<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="admin_permissions.aspx.cs" Inherits="orgproject.admin_permissions" %>
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
         .auto-style4 {
             font-size: medium;
         }
     </style>
    <form id="form1" runat="server">
        <p>
            <table style="width: 100%">
                <tr>
                    <td class="align-right" colspan="3" style="font-size: large">&#1575;&#1582;&#1584; &#1608;&#1575;&#1593;&#1591;&#1575;&#1569; &#1589;&#1604;&#1575;&#1581;&#1610;&#1575;&#1578; &#1604;&#1571;&#1583;&#1605;&#1606; &#1605;&#1581;&#1583;&#1583; </td>
                </tr>
                <tr>
                    <td colspan="2" class="align-right">
                        <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="139px">
                        </asp:DropDownList>
                    </td>
                    <td class="align-right" style="font-size: medium">&#1575;&#1582;&#1578;&#1585; &#1575;&#1604;&#1575;&#1583;&#1605;&#1606; &#1604;&#1578;&#1593;&#1583;&#1610;&#1604; &#1589;&#1604;&#1575;&#1581;&#1610;&#1575;&#1578;&#1607;</td>
                </tr>
                <tr>
                    <td class="align-right" colspan="2">
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="Grant" TextAlign="Left" />
                    </td>
                    <td class="align-right" style="font-size: medium">&#1575;&#1590;&#1575;&#1601;&#1577; &#1593;&#1605;&#1610;&#1604; </td>
                </tr>
                <tr>
                    <td class="align-right" colspan="2">
                        <asp:CheckBox ID="CheckBox3" runat="server" Text=" " />
                    </td>
                    <td class="align-right" style="font-size: medium">&#1578;&#1593;&#1583;&#1610;&#1604; &#1605;&#1593;&#1604;&#1608;&#1605;&#1575;&#1578; &#1593;&#1605;&#1610;&#1604; </td>
                </tr>
                <tr>
                    <td class="align-right" colspan="2">
                        <asp:CheckBox ID="CheckBox5" runat="server" Text=" " />
                    </td>
                    <td class="align-right"><span style="font-size: medium">&#1581;&#1584;&#1601; &#1593;&#1605;&#1610;&#1604;</span> </td>
                </tr>
                <tr>
                    <td class="align-right" colspan="2">
                        <asp:CheckBox ID="CheckBox7" runat="server" Text=" " />
                    </td>
                    <td class="align-right" style="font-size: medium">&#1575;&#1604;&#1575;&#1591;&#1604;&#1575;&#1593; &#1593;&#1604;&#1609; &#1575;&#1604;&#1575;&#1581;&#1589;&#1575;&#1574;&#1575;&#1578;</td>
                </tr>
                <tr>
                    <td class="align-right" colspan="2">
                        <asp:CheckBox ID="CheckBox9" runat="server" Text=" " />
                    </td>
                    <td class="align-right" style="font-size: medium">&#1575;&#1590;&#1575;&#1601;&#1577; &#1575;&#1604;&#1593;&#1585;&#1608;&#1590;</td>
                </tr>
                <tr>
                    <td class="align-right">
                        &nbsp;</td>
                    <td class="align-right">
                        <asp:CheckBox ID="CheckBox11" runat="server" Text=" " />
                    </td>
                    <td class="align-right" style="font-size: medium">event &#1575;&#1590;&#1575;&#1601;&#1577; </td>
                </tr>
                <tr>
                    <td class="align-right">
                        &nbsp;</td>
                    <td class="align-right">
                        <asp:CheckBox ID="CheckBox13" runat="server" Text=" " />
                    </td>
                    <td class="align-right" style="font-size: medium">&#1575;&#1590;&#1575;&#1601;&#1577; &#1575;&#1582;&#1576;&#1575;&#1585;</td>
                </tr>
                <tr>
                    <td class="align-right">
                        &nbsp;</td>
                    <td class="align-right">
                        <asp:CheckBox ID="CheckBox15" runat="server" Text=" " />
                    </td>
                    <td class="align-right" style="font-size: medium">&#1605;&#1585;&#1575;&#1580;&#1593;&#1577; &#1575;&#1604;&#1578;&#1593;&#1604;&#1610;&#1602;&#1575;&#1578; &#1608;&#1575;&#1604;&#1578;&#1602;&#1610;&#1610;&#1605; </td>
                </tr>
                <tr>
                    <td class="align-right">
                        &nbsp;</td>
                    <td class="align-right">
                        <asp:CheckBox ID="CheckBox17" runat="server" Text=" " />
                    </td>
                    <td class="align-right" style="font-size: medium">&#1575;&#1590;&#1575;&#1601;&#1577; &#1575;&#1593;&#1604;&#1575;&#1606;&#1575;&#1578; </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Button CssClass="button" ID="Button1" runat="server" OnClick="Button1_Click" Text="&#1578;&#1579;&#1576;&#1610;&#1578;" Font-Size="Medium" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;</td>
                    <td class="auto-style4">&#1575;&#1592;&#1607;&#1575;&#1585; &#1575;&#1604;&#1589;&#1604;&#1575;&#1581;&#1610;&#1575;&#1578; &#1604;&#1571;&#1583;&#1605;&#1606; </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button CssClass="button" ID="Button2" runat="server" OnClick="Button2_Click" Text="&#1593;&#1585;&#1590;" Font-Size="Medium" />
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList2" runat="server" Height="16px" Width="177px">
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>
        </p>
        <p>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </p>
        <p>
            <br />
        </p>
    </form>
</asp:Content>
