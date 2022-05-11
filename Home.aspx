<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="orgproject.Home" %>
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
             height: 42px;
         }
         .auto-style5 {
             text-align: right;
             height: 42px;
         }
         .auto-style6 {
             width: 100%;
             height: 248px;
         }
     </style>
    <form id="form1" runat="server">
        <div class="align-right">
        <table class="auto-style6">
            <tr>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Button class="button" ID="Button6" runat="server"  Font-Bold="True" Font-Names="Times New Roman" Font-Size="Large" ForeColor="Red" Height="50px" OnClick="Button6_Click" Text="&#1581;&#1584;&#1601; &#1575;&#1583;&#1605;&#1606; " Width="200px" />
                </td>
                <td class="auto-style5">
                    <asp:Button class="button" ID="Button5" runat="server"  Font-Bold="True" Font-Italic="False" Font-Names="Times New Roman" Font-Size="Large" ForeColor="Red" Height="50px" OnClick="Button5_Click" Text="&#1575;&#1590;&#1575;&#1601;&#1577; &#1571;&#1583;&#1605;&#1606;" Width="200px" />
                </td>
            </tr>
            <tr>
                <td style="height: 30px; ">
                    <asp:Button class="button" ID="Button7" runat="server"  Font-Bold="True" Font-Names="Times New Roman" Font-Size="Large" ForeColor="Red" Height="50px" Text="&#1575;&#1604;&#1578;&#1581;&#1603;&#1605; &#1601;&#1610; &#1589;&#1604;&#1575;&#1581;&#1610;&#1575;&#1578; &#1575;&#1604;&#1593;&#1605;&#1604;&#1575;&#1569;" Width="200px" OnClick="Button7_Click" />
                </td>
                <td style="height: 30px; " class="align-right">
                    <asp:Button class="button" ID="Button10" runat="server"  Font-Bold="True" Font-Names="Times New Roman" Font-Size="Large" ForeColor="Red" Height="50px" Text="&#1575;&#1604;&#1578;&#1581;&#1603;&#1605; &#1601;&#1610; &#1589;&#1604;&#1575;&#1581;&#1610;&#1575;&#1578; &#1575;&#1604;&#1575;&#1583;&#1605;&#1606;" Width="200px" OnClick="Button10_Click" />
                </td>
            </tr>
        </table>
        <table align="right" style="width: 50%;">
            <tr>
                <td class="align-right" colspan="3" style="height: 30px">
                    <asp:TextBox ID="TextBox1" runat="server" Height="30px"></asp:TextBox>
                </td>
                <td style="height: 30px">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="align-right" style="height: 30px">&nbsp;&nbsp;
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                </td>
                <td class="align-right" style="height: 30px; width: 52px">
                    <asp:Button class="button" ID="Button8" runat="server" Height="22px" OnClick="Button8_Click" Text="&#1581;&#1601;&#1592;" />
                </td>
                <td class="align-right" style="height: 30px">
                    <asp:TextBox ID="TextBox2" runat="server" Height="26px" TextMode="Password"></asp:TextBox>
                </td>
                <td style="height: 30px">
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="align-right" style="height: 30px">
                    <asp:Label ID="Label5" runat="server"></asp:Label>
                </td>
                <td class="align-right" style="height: 30px; width: 52px">
                    <asp:Button class="button" ID="Button9" runat="server" OnClick="Button9_Click1" Text="&#1581;&#1584;&#1601;" />
                </td>
                <td class="align-right" style="height: 30px">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                    </asp:DropDownList>
                </td>
                <td style="height: 30px">
                    <asp:Label ID="Label4" runat="server"></asp:Label>
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
            <asp:Button class="button" ID="Button12" runat="server" OnClick="Button12_Click" Text="&#1578;&#1593;&#1583;&#1610;&#1604; &#1604;&#1605;&#1583;&#1607; &#1605;&#1581;&#1583;&#1583;&#1607;" />
            <asp:Button class="button" ID="Button11" runat="server" OnClick="Button11_Click" Text="&#1578;&#1605;&#1583;&#1610;&#1583; 45 &#1610;&#1608;&#1605; " />
            <asp:Label ID="Label6" runat="server" Font-Size="X-Large" ForeColor="Red"></asp:Label>
            <br />
        <br />
        <br />
        </div>
    </form>
</asp:Content>
