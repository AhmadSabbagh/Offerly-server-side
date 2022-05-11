<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="advert.aspx.cs" Inherits="orgproject.WebForm3" %>
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
p.serif {
    font-family: "Times New Roman", Times, serif;
}

h5 {
    font-size: 30px;
    font-family: "Times New Roman", Times, serif;
}
        .auto-style4 {
            font-size: large;
        }
        .auto-style5 {
            font-size: xx-large;
        }
    </style>
    <form id="form1" runat="server">
   <div class="form">
        <br />
        <table style="width: 100%; height: 313px">
            <tr>
                <td class="align-right" colspan="2" style="font-size: x-large"><h2 class="auto-style5">&#1606;&#1592;&#1575;&#1605; &#1575;&#1604;&#1575;&#1593;&#1604;&#1575;&#1606;&#1575;&#1578; &#1575;&#1604;&#1605;&#1606;&#1576;&#1579;&#1602;&#1577;</h2></td>
            </tr>
            <tr>
                <td class="align-right">
                    <asp:TextBox ID="TextBox1"  runat="server"></asp:TextBox>
                </td>
                <td class="align-right" style="font-size: x-large"><h2>&#1585;&#1602;&#1605; &#1575;&#1604;&#1575;&#1593;&#1604;&#1575;&#1606; </h2></td>
            </tr>
            <tr>
                <td class="align-right" style="height: 30px">
                    
                    <div class="align-right">
                    <asp:TextBox ID="TextBox3"  runat="server" Height="31px" style="margin-left: 0" Width="301px" TextMode="MultiLine"></asp:TextBox>
                    </div>
                    
                    <br />
                </td>
                <td class="align-right" style="font-size: x-large; height: 30px;"><h2>&#1575;&#1604;&#1575;&#1593;&#1604;&#1575;&#1606; </h2></td>
            </tr>
            <tr>
                <td class="align-right">
                    <asp:TextBox ID="TextBox4"  runat="server"></asp:TextBox>
                </td>
                <td class="align-right" style="font-size: x-large"><h2>&#1605;&#1583;&#1577; &#1575;&#1604;&#1575;&#1593;&#1604;&#1575;&#1606;</h2> </td>
            </tr>
            <tr>
                <td class="align-right">
                    <asp:TextBox ID="TextBox5"  runat="server"></asp:TextBox>
                </td>
                <td class="align-right" style="font-size: x-large"><h2>&#1605;&#1583;&#1577; &#1575;&#1604;&#1592;&#1607;&#1608;&#1585; </h2> </td>
            </tr>
            <tr>
                <td class="align-right">
                    &nbsp;
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Font-Names="Times New Roman" Font-Size="Medium">
                        <asp:ListItem Value="1">&#1575;&#1604;&#1603;&#1604;</asp:ListItem>
                        <asp:ListItem Value="2">&#1584;&#1603;&#1608;&#1585;</asp:ListItem>
                        <asp:ListItem Value="4">&#1605;&#1603;&#1575;&#1606; &#1575;&#1604;&#1587;&#1603;&#1606;</asp:ListItem>
                        <asp:ListItem Value="5">&#1575;&#1604;&#1593;&#1605;&#1585;</asp:ListItem>
                        <asp:ListItem Value="3">&#1575;&#1606;&#1575;&#1579;</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="align-right" style="font-size: x-large"><h2 class="auto-style4">&#1575;&#1604;&#1586;&#1576;&#1575;&#1574;&#1606; &#1575;&#1604;&#1605;&#1587;&#1578;&#1607;&#1583;&#1601;&#1610;&#1606;</h2>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Label ID="Label1" runat="server" Font-Size="Large" ForeColor="Red"></asp:Label>
                   <asp:Button class="button" ID="Button1" runat="server" style="font-size: medium" Text="&#1593;&#1585;&#1590;" OnClick="Button1_Click" />
                    <asp:Button class="button" ID="Button2" runat="server" style="font-size: medium" Text="&#1581;&#1584;&#1601;" OnClick="Button2_Click" />
                    <asp:Button class="button" ID="Button4" runat="server" OnClick="Button4_Click" style="font-size: medium" Text="&#1573;&#1590;&#1575;&#1601;&#1577;" />
                </td>
            </tr>
        </table>
        <table style="width: 100%">
            <tr>
                <td>&nbsp;</td>
                <td class="align-right">
                    &nbsp;<asp:Button class="button" ID="Button8" runat="server" OnClick="Button8_Click" Text="&#1581;&#1584;&#1601;" />
                    <asp:Button class="button" ID="Button5" runat="server" OnClick="Button5_Click" Text="&#1593;&#1585;&#1590;" />
                    <asp:DropDownList ID="DropDownList2" runat="server" Font-Names="Times New Roman" Font-Size="Medium" Height="18px" Width="206px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Image ID="Image2" runat="server" />
                </td>
            </tr>
        </table>
<br />
<br />
<br />
<br />
   </div>
    </form>
</asp:Content>

