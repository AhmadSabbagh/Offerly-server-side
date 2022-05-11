<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="brithday_offer2.aspx.cs" Inherits="orgproject.brithday_offer2" %>
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
                <td class="align-left" style="font-size: medium">
                    Time period</td>
                <td class="align-left" style="font-size: large">&nbsp;from</td>
                <td class="align-left" style="font-size: large" colspan="2">
                    <asp:TextBox ID="TextBox2" runat="server" style="font-size: small" Width="106px" TextMode="DateTimeLocal"></asp:TextBox>
                </td>
                <td class="align-right" style="font-size: large">To:</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" style="font-size: small" Width="106px" TextMode="DateTimeLocal"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="align-right" colspan="6" style="background-color: #FF6600">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Kids birthday" />
                </td>
                <td colspan="2">
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Marriageday" />
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Brithday" />
                </td>
            </tr>
            <tr>
                <td colspan="6">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Button ID="Button4" runat="server" Text="kids offer" OnClick="Button4_Click" />
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:Button ID="Button5" runat="server" Text="Marriage offer" OnClick="Button5_Click" />
                </td>
                <td>
                    <asp:Button ID="Button6" runat="server" Text="Brith offer" OnClick="Button6_Click" />
                </td>
            </tr>
        </table>
    <table style="width: 100%">
        <tr>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td class="align-right">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="height: 30px">
                <asp:DropDownList ID="DropDownList2" runat="server">
                </asp:DropDownList>
            </td>
            <td style="height: 30px" class="align-right">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="align-left">
                <asp:Label ID="Label1" runat="server" Text="Offer"></asp:Label>
            </td>
            <td class="align-left">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="align-left">
                <asp:Label ID="Label2" runat="server" Text="Offer picture"></asp:Label>
            </td>
            <td class="align-left">
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="align-left">
                <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Send Marriage offer" />
                <asp:Button ID="Button7" runat="server" Text="send Brith offer" OnClick="Button7_Click" />
            </td>
            <td class="align-right">
                &nbsp;</td>
        </tr>
    </table>
    </form>
    <br />

</asp:Content>
