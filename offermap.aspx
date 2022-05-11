<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="offermap.aspx.cs" Inherits="orgproject.offermap" %>
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
         .auto-style5 {
             text-align: right;
             font-size: large;
             height: 30px;
         }
         .auto-style6 {
             text-align: right;
             height: 30px;
         }
         .auto-style7 {
             text-align: left;
             width: 154px;
         }
         .auto-style8 {
             text-align: right;
             height: 30px;
             width: 154px;
         }
         .auto-style9 {
             text-align: center;
         }
     </style>
      <form id="form1" runat="server">
        <div class="align-right" style="text-align: center; height: 228px">
            <table align="right" style="width: 50%">
                <tr>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="Medium" Height="30px">
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <table align="right" aria-busy="False" style="width: 50%">
                <tr>
                    <td colspan="2" style="font-size: large; height: 44px">&#1575;&#1590;&#1575;&#1601;&#1577; &#1582;&#1576;&#1585; &#1604;&#1593;&#1605;&#1610;&#1604; &#1605;&#1581;&#1583;&#1583; &#1575;&#1593;&#1604;&#1575;&#1607; &#1604;&#1604;&#1586;&#1576;&#1575;&#1574;&#1606; &#1575;&#1604;&#1605;&#1608;&#1580;&#1608;&#1583;&#1610;&#1606; &#1576;&#1606;&#1601;&#1587; &#1575;&#1604;&#1605;&#1606;&#1591;&#1602;&#1607; </td>
                </tr>
                <tr>
                    <td style="height: 30px">
                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    </td>
                    <td style="font-size: large; width: 89px; height: 30px;">&#1575;&#1587;&#1605; &#1575;&#1604;&#1582;&#1576;&#1585;</td>
                </tr>
                <tr>
                    <td style="height: 30px">
                        <asp:TextBox ID="TextBox1" runat="server" Height="48px" TextMode="MultiLine"></asp:TextBox>
                    </td>
                    <td style="font-size: large; width: 89px; height: 30px;">&#1575;&#1604;&#1582;&#1576;&#1585;</td>
                </tr>
                <tr>
                    <td class="align-right" colspan="2">
                        <asp:Label ID="Label2" runat="server"></asp:Label>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="&#1575;&#1590;&#1575;&#1601;&#1577;" Font-Names="Times New Roman" Font-Size="Medium" />
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
            <table style="width: 100%">
                <tr>
                    <td colspan="3" style="font-size: x-large" class="auto-style2">&#1575;&#1590;&#1575;&#1601;&#1577; &#1593;&#1585;&#1590; &#1604;&#1604;&#1593;&#1605;&#1610;&#1604; &#1575;&#1604;&#1605;&#1581;&#1583;&#1583; &#1604;&#1604;&#1586;&#1576;&#1575;&#1574;&#1606; &#1575;&#1604;&#1605;&#1608;&#1580;&#1608;&#1583;&#1610;&#1606; &#1576;&#1575;&#1604;&#1605;&#1606;&#1591;&#1602;&#1577;</td>
                </tr>
                <tr>
                    <td colspan="3" style="font-size: x-large" class="auto-style2">
                        <asp:DropDownList ID="DropDownList4" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="Medium" Height="30px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9" colspan="2">
                        <asp:TextBox ID="TextBox3" runat="server" Height="19px" Width="126px"></asp:TextBox>
                    </td>
                    <td class="align-right" style="font-size: large">&nbsp;&#1575;&#1604;&#1593;&#1585;&#1590;</td>
                </tr>
                <tr>
                    <td class="auto-style6" colspan="2" style="text-align: center">
                        <asp:TextBox ID="TextBox4" runat="server" Height="78px" TextMode="MultiLine" Width="286px"></asp:TextBox>
                    </td>
                    <td class="auto-style5">&#1575;&#1604;&#1608;&#1589;&#1601;</td>
                </tr>
                <tr>
                    <td class="align-right" style="height: 30px; text-align: center;" colspan="2">
                        <asp:TextBox ID="TextBox6" runat="server" TextMode="DateTimeLocal" Height="19px" Width="126px"></asp:TextBox>
                    </td>
                    <td class="align-right" style="font-size: large; height: 30px;">&#1608;&#1602;&#1578; &#1575;&#1604;&#1576;&#1583;&#1575;&#1610;&#1577; </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="&#1575;&#1590;&#1575;&#1601;&#1577;" BackColor="#FF3300" BorderColor="White" ForeColor="Black" Font-Names="Times New Roman" Font-Size="Medium" />
                    </td>
                    <td class="align-left">
                        <asp:TextBox ID="TextBox7" runat="server" TextMode="DateTimeLocal"></asp:TextBox>
                    </td>
                    <td class="align-right" style="font-size: large">&#1608;&#1602;&#1578; &#1575;&#1604;&#1606;&#1607;&#1575;&#1610;&#1577; </td>
                </tr>
                <tr>
                    <td class="auto-style8" style="border-left: thin solid #FF0000; border-right: thin none #FF0000; border-top: thin solid #FF0000; border-bottom: thin solid #FF0000; background-color: #C0C0C0;">
                        &nbsp;<br />
                        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="&#1581;&#1601;&#1592; &#1575;&#1604;&#1578;&#1593;&#1583;&#1610;&#1604;" />
                        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="&#1575;&#1592;&#1607;&#1575;&#1585; &#1575;&#1604;&#1576;&#1610;&#1575;&#1606;&#1575;&#1578;" />
                    </td>
                    <td class="align-right" style="border-style: solid none solid none; border-width: thin; border-color: #FF0000; height: 30px; background-color: #C0C0C0;">
                        <asp:DropDownList ID="DropDownList7" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td class="align-right" style="border: thin solid #FF0000; height: 30px; font-size: medium; background-color: #C0C0C0;">
                        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="&#1578;&#1593;&#1583;&#1610;&#1604; &#1593;&#1585;&#1590; &#1605;&#1593;&#1610;&#1606;" />
&nbsp;</td>
                </tr>
                </table>
            <table style="border-style: solid; border-width: thin; border-color: #FF00FF; width: 100%; background-color: #C0C0C0;">
                <tr>
                    <td>&nbsp;</td>
                    <td colspan="2" style="font-size: medium">&#1581;&#1584;&#1601; &#1582;&#1576;&#1585; &#1575;&#1608; &#1593;&#1585;&#1590; &#1605;&#1581;&#1583;&#1583;</td>
                </tr>
                <tr>
                    <td style="height: 30px"></td>
                    <td class="align-right" style="height: 30px">
                        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="&#1581;&#1584;&#1601;" Font-Names="Times New Roman" Font-Size="Medium" />
                        <asp:DropDownList ID="DropDownList5" runat="server" Font-Names="Times New Roman" Font-Size="Medium" Height="30px">
                        </asp:DropDownList>
                    </td>
                    <td style="font-size: medium; height: 30px">&#1581;&#1584;&#1601; &#1593;&#1585;&#1590;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="align-right">
                        <asp:Label ID="Label3" runat="server"></asp:Label>
                        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="&#1581;&#1584;&#1601;" Font-Names="Times New Roman" Font-Size="Medium" />
                        <asp:DropDownList ID="DropDownList6" runat="server" Font-Names="Times New Roman" Font-Size="Medium" Height="30px">
                        </asp:DropDownList>
                    </td>
                    <td style="font-size: medium">&#1581;&#1584;&#1601; &#1582;&#1576;&#1585; </td>
                </tr>
            </table>
            <br />
            <br />
            <br />
        </div>
    </form>
    </form>
    <br />
    <br />
    <br />
    <br />
</asp:Content>
