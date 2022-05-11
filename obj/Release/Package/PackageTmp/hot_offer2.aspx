<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="hot_offer2.aspx.cs" Inherits="orgproject.hot_offer2" %>
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
        <br />
        <table style="width: 100%; height: 242px">
            <tr>
                <td class="align-left" colspan="2" style="font-size: x-large"><strong>&nbsp;Hot offers system&nbsp;&nbsp; </strong></td>
            </tr>
            <tr>
                <td class="align-left" style="font-size: medium">
                    Hot offer name</td>
                <td class="align-left" style="font-size: x-large">
                    <asp:TextBox ID="TextBox2" runat="server" Height="23px" Width="209px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="align-left" style="height: 30px; font-size: medium;">
                    Hot offer picture</td>
                <td class="align-right" style="font-size: x-large; height: 30px">
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Label ID="Label1" runat="server" Font-Size="Large" ForeColor="Red"></asp:Label>
                    &nbsp;&nbsp;<asp:Button ID="Button1" runat="server" style="font-size: medium" Text="View" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" style="font-size: medium" Text="Remove" OnClick="Button2_Click" />
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" style="font-size: medium" Text="ADD" />
                </td>
            </tr>
        </table>
        <table style="width: 100%; height: 129px;">
            <tr>
                <td style="width: 66px">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                    </asp:DropDownList>
                </td>
                <td class="align-left">
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="show" />
                    <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="delete" />
                </td>
            </tr>
            <tr>
                <td style="width: 66px">
                    <asp:Label ID="Label2" runat="server" Font-Size="Medium" Text="hot offer name"></asp:Label>
                </td>
                <td class="align-left">&nbsp;
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Image ID="Image1" runat="server" />
                </td>
            </tr>
        </table>
<br />
<br />
<br />
<br />
    </form>

</asp:Content>
