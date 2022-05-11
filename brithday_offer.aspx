<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="brithday_offer.aspx.cs" Inherits="orgproject.brithday_offer" %>
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
                    <asp:TextBox ID="TextBox2" runat="server" style="font-size: small" Width="106px" TextMode="Date"></asp:TextBox>
                </td>
                <td class="align-right" style="font-size: large">:&#1575;&#1604;&#1609;</td>
                <td class="align-right" style="font-size: large">
                    <asp:TextBox ID="TextBox1" runat="server" style="font-size: small" Width="106px" TextMode="Date"></asp:TextBox>
                </td>
                <td class="align-right" style="font-size: large">:&#1605;&#1606;</td>
                <td>:&#1573;&#1582;&#1578;&#1585; &#1575;&#1604;&#1601;&#1578;&#1585;&#1577; &#1575;&#1604;&#1586;&#1605;&#1606;&#1610;&#1577;</td>
            </tr>
            <tr>
                <td class="align-right" colspan="5" style="background-color: #FF6600">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button class="button" ID="Button3" runat="server" OnClick="Button3_Click" Text="اعياد ميلاد الاطفال" />
                </td>
                <td colspan="2">
                    <asp:Button class="button" ID="Button2" runat="server" OnClick="Button2_Click" Text="&#1575;&#1593;&#1610;&#1575;&#1583; &#1575;&#1604;&#1586;&#1608;&#1575;&#1580; " />
                </td>
                <td>
                    <asp:Button class="button" ID="Button1" runat="server" OnClick="Button1_Click" Text="&#1575;&#1593;&#1610;&#1575;&#1583; &#1575;&#1604;&#1605;&#1610;&#1604;&#1575;&#1583;" />
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button class="button" ID="Button4" runat="server" Text="حذف عرض معين " OnClick="Button4_Click" BackColor="Red" ForeColor="White" />
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:Button class="button" ID="Button5" runat="server" Text="&#1593;&#1585;&#1590; &#1604;&#1604;&#1586;&#1608;&#1575;&#1580;" OnClick="Button5_Click" BackColor="Red" ForeColor="White" />
                </td>
                <td>
                    <asp:Button class="button" ID="Button6" runat="server" Text="&#1593;&#1585;&#1590; &#1604;&#1604;&#1605;&#1610;&#1604;&#1575;&#1583;" OnClick="Button6_Click" BackColor="Red" BorderColor="Red" ForeColor="White" />
                </td>
            </tr>
        </table>
    <table style="width: 100%">
        <tr>
            <td class="align-right" colspan="2" style="text-align: center">
                <asp:Button class="button" ID="Button10" runat="server" OnClick="Button10_Click" Text="مسح عرض زواج" Width="71px" BackColor="Red" ForeColor="White" />
                <asp:Button class="button" ID="Button11" runat="server" OnClick="Button11_Click" Text="مسح عرض ميلاد" Width="72px" BackColor="Red" ForeColor="White" />
            </td>
        </tr>
        <tr>
            <td class="align-right" colspan="2">
                <asp:Button class="button" ID="Button9" runat="server" OnClick="Button9_Click" Text="حذف" BackColor="#00CC00" ForeColor="White" Height="23px" Width="46px" />
                <asp:DropDownList ID="DropDownList3" runat="server">
                </asp:DropDownList>
                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="height: 30px"></td>
            <td style="height: 30px" class="align-right">
                <asp:DropDownList ID="DropDownList2" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="align-right">
                <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" Width="334px"></asp:TextBox>
            </td>
            <td class="align-right">
                <asp:Label ID="Label1" runat="server" Text="&#1575;&#1604;&#1593;&#1585;&#1590;" Font-Size="Large"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="align-left" colspan="2">
                <asp:Button class="button" ID="Button8" runat="server" OnClick="Button8_Click" Text="&#1575;&#1585;&#1587;&#1575;&#1604; &#1593;&#1585;&#1590; &#1575;&#1604;&#1586;&#1608;&#1575;&#1580;" BackColor="Lime" ForeColor="White" Height="26px" />
                <asp:Button class="button" ID="Button7" runat="server" Text="&#1575;&#1585;&#1587;&#1575;&#1604; &#1593;&#1585;&#1590; &#1575;&#1604;&#1605;&#1610;&#1604;&#1575;&#1583;" OnClick="Button7_Click" BackColor="Lime" ForeColor="White" Height="27px" />
            </td>
        </tr>
    </table>
    </form>
    <br />
</asp:Content>
