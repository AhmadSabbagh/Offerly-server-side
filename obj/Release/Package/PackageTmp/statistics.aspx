<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="statistics.aspx.cs" Inherits="orgproject.statistics" EnableEventValidation="false" %>
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
    <form id="form1" runat="server" style="height: 267px">
        <br />
        <table style="width: 100%">
            <tr>
                <td style="font-size: medium">&#1593;&#1583;&#1583; &#1586;&#1608;&#1575;&#1585; &#1575;&#1604;&#1587;&#1606;&#1577; </td>
                <td style="font-size: medium">&#1593;&#1583;&#1583; &#1586;&#1608;&#1575;&#1585; &#1575;&#1604;&#1588;&#1607;&#1585;</td>
                <td style="font-size: medium">&#1593;&#1583;&#1583; &#1586;&#1608;&#1575;&#1585; &#1575;&#1604;&#1610;&#1608;&#1605;</td>
                <td style="font-size: medium">&#1605;&#1578;&#1589;&#1604; &#1575;&#1604;&#1575;&#1606;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" Height="20px" Width="50px"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Height="20px" Width="50px"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Height="20px" Width="50px"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="50px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <table style="width: 100%">
            <tr>
                <td class="align-right">
                    <asp:Button ID="Button13" runat="server" Text="&#1575;&#1582;&#1578;&#1585;" OnClick="Button13_Click" />
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList4" runat="server">
                    </asp:DropDownList>
                </td>
                <td class="align-right">
                    <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="&#1575;&#1582;&#1578;&#1585;" />
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList3" runat="server">
                        <asp:ListItem Value="0">&#1575;&#1582;&#1578;&#1585; &#1575;&#1604;&#1606;&#1608;&#1593; </asp:ListItem>
                        <asp:ListItem Value="1">&#1589;&#1601;&#1581;&#1577; &#1593;&#1605;&#1610;&#1604; </asp:ListItem>
                        <asp:ListItem Value="2">&#1575;&#1593;&#1604;&#1575;&#1606; </asp:ListItem>
                        <asp:ListItem Value="3">&#1593;&#1600;&#1600;&#1600;&#1600;&#1585;&#1590;</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="align-right" colspan="2" style="text-align: center">
                    <asp:Label ID="Label3" runat="server" Text="&#1593;&#1583;&#1583; &#1586;&#1608;&#1575;&#1585; &#1575;&#1604;&#1587;&#1606;&#1577; "></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="&#1593;&#1583;&#1583; &#1586;&#1608;&#1575;&#1585; &#1575;&#1604;&#1588;&#1607;&#1585; "></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="&#1593;&#1583;&#1583; &#1586;&#1608;&#1575;&#1585; &#1575;&#1604;&#1610;&#1608;&#1605; "></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:TextBox ID="TextBox7" runat="server" Height="20px" Width="50px"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server" Height="20px" Width="50px"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server" Height="20px" Width="50px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <table style="width: 100%">
            <tr>
                <td>
                    <asp:Button ID="Button7" runat="server" Height="44px" OnClick="Button7_Click" Text="&#1575;&#1604;&#1575;&#1581;&#1589;&#1575;&#1574;&#1610;&#1575;&#1578; &#1575;&#1604;&#1582;&#1575;&#1589;&#1577; &#1576;&#1575;&#1604;&#1575;&#1583;&#1605;&#1606;" Width="110px" />
                </td>
                <td>
                    <asp:Button ID="Button8" runat="server" Height="44px" OnClick="Button8_Click" Text="&#1575;&#1604;&#1575;&#1581;&#1589;&#1575;&#1574;&#1575;&#1578; &#1575;&#1604;&#1593;&#1575;&#1605;&#1577;" Width="110px" />
                </td>
                <td>
                    <asp:Button ID="Button9" runat="server" Height="44px" OnClick="Button9_Click" Text="&#1575;&#1604;&#1586;&#1576;&#1575;&#1574;&#1606; &#1575;&#1604;&#1605;&#1587;&#1580;&#1604;&#1610;&#1606; &#1601;&#1610; &#1575;&#1604;&#1578;&#1591;&#1576;&#1610;&#1602;" Width="110px" />
                </td>
            </tr>
        </table>
        <br />
        <table align="right" style="width: 100%">
            <tr>
                <td class="align-right">
                    <asp:Button ID="Button10" runat="server" Text="&#1575;&#1582;&#1578;&#1585;" OnClick="Button10_Click" />
                </td>
                <td class="align-right">
                    <asp:DropDownList ID="DropDownList2" runat="server">
                    </asp:DropDownList>
                </td>
                <td class="align-right">
                    <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="&#1575;&#1582;&#1578;&#1585;" />
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="0">&#1575;&#1582;&#1578;&#1585; &#1606;&#1608;&#1593; &#1575;&#1604;&#1575;&#1581;&#1589;&#1575;&#1569;</asp:ListItem>
                        <asp:ListItem Value="1">&#1575;&#1604;&#1586;&#1576;&#1575;&#1574;&#1606; &#1575;&#1604;&#1584;&#1610;&#1606; &#1606;&#1588;&#1585;&#1608; &#1575;&#1604;&#1593;&#1585;&#1590;</asp:ListItem>
                        <asp:ListItem Value="2">&#1575;&#1604;&#1586;&#1576;&#1575;&#1574;&#1606; &#1575;&#1604;&#1584;&#1610;&#1606; &#1606;&#1588;&#1585;&#1608; &#1575;&#1604;&#1575;&#1593;&#1604;&#1575;&#1606; </asp:ListItem>
                        <asp:ListItem Value="3">&#1575;&#1604;&#1586;&#1576;&#1575;&#1574;&#1606; &#1575;&#1604;&#1584;&#1610;&#1606; &#1606;&#1588;&#1585;&#1608; &#1575;&#1604;&#1578;&#1591;&#1576;&#1610;&#1602;</asp:ListItem>
                        <asp:ListItem Value="4">&#1575;&#1604;&#1586;&#1576;&#1575;&#1574;&#1606; &#1575;&#1604;&#1578;&#1610; &#1583;&#1582;&#1604;&#1578; &#1593;&#1604;&#1609; &#1575;&#1593;&#1604;&#1575;&#1606;</asp:ListItem>
                        <asp:ListItem Value="5">&#1575;&#1604;&#1586;&#1576;&#1575;&#1574;&#1606; &#1575;&#1604;&#1578;&#1610; &#1583;&#1582;&#1604;&#1578; &#1593;&#1604;&#1609; &#1582;&#1576;&#1585; </asp:ListItem>
                        <asp:ListItem Value="6">&#1575;&#1604;&#1586;&#1576;&#1575;&#1574;&#1606; &#1575;&#1604;&#1578;&#1610; &#1583;&#1582;&#1604;&#1578; &#1593;&#1604;&#1609; &#1575;&#1588;&#1593;&#1575;&#1585;</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:Button ID="Button14" runat="server" OnClick="Button14_Click" Text="&#1578;&#1589;&#1583;&#1610;&#1585; &#1575;&#1604;&#1609; &#1605;&#1604;&#1601; &#1575;&#1603;&#1587;&#1604;" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</asp:Content>
