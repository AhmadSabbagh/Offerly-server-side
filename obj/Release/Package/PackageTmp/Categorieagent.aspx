<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Categorieagent.aspx.cs" Inherits="orgproject.Categorieagent" %>
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
    <form id="form1" runat="server" style="height: 3px">
        <br />
        <table style="width: 100%">
            <tr>
                <td class="align-right" colspan="2" style="font-size: large; font-family: 'Times New Roman', Times, serif;"><strong>:&#1573;&#1590;&#1575;&#1601;&#1577; &#1578;&#1589;&#1606;&#1610;&#1601; &#1580;&#1583;&#1610;&#1583; &#1604;&#1604;&#1593;&#1605;&#1604;&#1575;&#1569;&#1575;&#1608; &#1581;&#1584;&#1601; &#1578;&#1589;&#1606;&#1610;&#1601; &#1605;&#1608;&#1580;&#1608;&#1583; &#1605;&#1587;&#1576;&#1602;&#1575;&#1611;</strong></td>
            </tr>
            <tr>
                <td class="align-right">
                    <asp:Label ID="Label2" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
                    <asp:Button class="button" ID="Button1" runat="server" Text="&#1573;&#1590;&#1575;&#1601;&#1577; " OnClick="Button1_Click" BackColor="Red" Font-Size="Small" ForeColor="White" Width="51px" />
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td style="font-family: 'times New Roman', Times, serif; font-size: medium;">&#1575;&#1587;&#1605; &#1575;&#1604;&#1578;&#1589;&#1606;&#1610;&#1601; </td>
            </tr>
            <tr>
                <td class="align-right">
                    <asp:Label ID="Label3" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
                    <asp:Button class="button" ID="Button5" runat="server" Text="&#1581;&#1584;&#1601;" OnClick="Button5_Click" BackColor="Red" Font-Size="Small" ForeColor="White" Width="51px" />
                    <asp:DropDownList ID="DropDownList5" runat="server" Height="18px" Width="127px">
                    </asp:DropDownList>
                </td>
                <td style="font-family: 'times New Roman', Times, serif; font-size: medium;">&#1575;&#1587;&#1605; &#1575;&#1604;&#1578;&#1589;&#1606;&#1610;&#1601; </td>
            </tr>
        </table>
        <br />
        <br />
        <table align="right" style="width: 60%">
            <tr>
                <td class="align-right" colspan="2" style="height: 30px; font-family: 'times New Roman', Times, serif; font-size: large;"><strong>:&#1575;&#1590;&#1575;&#1601;&#1577; &#1578;&#1589;&#1606;&#1610;&#1601; &#1601;&#1585;&#1593;&#1610; </strong> </td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="131px" Font-Bold="False" Font-Names="Times New Roman" Font-Size="Medium">
                    </asp:DropDownList>
                </td>
                <td class="align-right" style="font-family: 'times New Roman', Times, serif">&#1575;<span style="font-size: medium">&#1604;&#1578;&#1589;&#1606;&#1610;&#1601; &#1575;&#1604;&#1585;&#1574;&#1610;&#1587;&#1610;</span> </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td class="align-right" style="font-family: 'times New Roman', Times, serif">&#1575;<span style="font-size: medium">&#1604;&#1578;&#1589;&#1606;&#1610;&#1601; &#1575;&#1604;&#1601;&#1585;&#1593;&#1610;</span></td>
            </tr>
            <tr>
                <td class="align-right" colspan="2">
                    <asp:Label ID="Label1" runat="server" BackColor="White" Font-Size="Large" ForeColor="Red"></asp:Label>
                    <asp:Button class="button" ID="Button2" runat="server" Text="&#1573;&#1590;&#1575;&#1601;&#1577;" OnClick="Button2_Click" BackColor="Red" ForeColor="White" />
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
        <br />
        <br />
        <br />
        <br />
        <br />
        <table align="right" style="width: 50%">
            <tr>
                <td class="align-right" colspan="2" style="font-family: 'times New Roman', Times, serif; font-size: large;"><strong>&nbsp;:&#1593;&#1585;&#1590; &#1578;&#1589;&#1606;&#1610;&#1601; &#1605;&#1593;&#1610;&#1606; &#1608;&#1575;&#1604;&#1593;&#1605;&#1604;&#1575;&#1569; &#1601;&#1610;&#1607;&nbsp; </strong> </td>
            </tr>
            <tr>
                <td class="align-right">
                    <asp:DropDownList ID="DropDownList2" runat="server" Height="16px" Width="111px" Font-Names="Times New Roman" Font-Size="Medium">
                    </asp:DropDownList>
                </td>
                <td style="font-family: 'times New Roman', Times, serif; font-size: medium;">&#1575;&#1604;&#1578;&#1589;&#1606;&#1610;&#1601; &#1575;&#1604;&#1585;&#1574;&#1610;&#1587;&#1610;</td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Button class="button" ID="Button4" runat="server" Text="&#1593;&#1585;&#1590;" OnClick="Button4_Click" BackColor="Red" ForeColor="White" />
                </td>
            </tr>
        </table>
        <br />
        <br />
         <br />
        <br />
         
        <br />
        <br />
        <table align="right" style="width: 50%">
            <tr>
                <td class="align-right" colspan="2" style="font-family: 'times New Roman', Times, serif; font-size: large;"><strong>&nbsp; &#1581;&#1584;&#1601; &#1578;&#1589;&#1606;&#1610;&#1601; &#1601;&#1585;&#1593;&#1610; &#1608;&#1575;&#1604;&#1593;&#1605;&#1604;&#1575;&#1569; &#1601;&#1610;&#1607; &#1605;&#1606; &#1575;&#1604;&#1578;&#1589;&#1606;&#1610;&#1601; &#1575;&#1604;&#1585;&#1574;&#1610;&#1587;&#1610; &#1575;&#1604;&#1605;&#1581;&#1583;&#1583; &#1575;&#1593;&#1604;&#1575;&#1607;&nbsp; </strong> </td>
            </tr>
            <tr>
                <td class="align-right">
                    <asp:DropDownList ID="DropDownList4" runat="server" Height="16px" Width="111px" Font-Names="Times New Roman" Font-Size="Medium">
                    </asp:DropDownList>
                </td>
                <td style="font-family: 'times New Roman', Times, serif; font-size: medium;">&#1575;&#1604;&#1578;&#1589;&#1606;&#1610;&#1601; &#1575;&#1604;&#1601;&#1585;&#1593;&#1610;</td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Label ID="Label4" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
                    <asp:Button class="button" ID="Button3" runat="server" Text="&#1581;&#1584;&#1601;" BackColor="Red" ForeColor="White" OnClick="Button3_Click1" />
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
        <asp:GridView ID="GridView1" runat="server" Width="410px">
        </asp:GridView>
    </form>
</asp:Content>
