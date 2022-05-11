<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="hot_event2.aspx.cs" Inherits="orgproject.hot_event2" %>
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

    <div class="form">
        <br />
        <table style="width: 100%; height: 437px">
            <tr>
                <td class="align-left" colspan="5" style="font-size: x-large"><strong>&nbsp;Hot events system&nbsp; </strong></td>
            </tr>
            <tr>
                <td class="align-left" style="font-size: medium">
                    Activity Name</td>
                <td class="align-left" style="font-size: x-large" colspan="4">
                    <asp:TextBox ID="TextBox1" runat="server" Height="21px" Width="135px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="align-left" style="height: 30px; font-size: medium;">
                    Activity picture</td>
                <td class="align-right" style="font-size: x-large; height: 30px" colspan="4">
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="align-left" style="font-size: medium">
                    Address</td>
                <td class="align-left" style="font-size: x-large" colspan="4">
                    <asp:TextBox ID="TextBox4" runat="server" Height="21px" Width="135px"></asp:TextBox>
                &nbsp;</td>
            </tr>
            <tr>
                <td class="align-left" style="font-size: medium">
                    Telephone</td>
                <td class="align-left" style="font-size: x-large" colspan="4">
                    <asp:TextBox ID="TextBox5" runat="server" Height="21px" Width="135px"></asp:TextBox>
                    &nbsp; </td>
            </tr>
            <tr>
                <td class="align-left">
                    &nbsp;
                    <span style="font-size: medium">phone</span>&nbsp;</td>
                <td class="align-left" style="font-size: x-large" colspan="4">
                    <asp:TextBox ID="TextBox6" runat="server" Height="21px" Width="135px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="align-left" style="font-size: medium">
                    booking tickets</td>
                <td class="align-right" style="font-size: x-large">
                    <asp:RadioButton ID="RadioButton4" runat="server" Checked="True" GroupName="b" Text="none" TextAlign="Left" />
                </td>
                <td class="align-right" style="font-size: x-large">
                    <asp:RadioButton ID="RadioButton3" runat="server" GroupName="b" Text="phone" TextAlign="Left" />
                </td>
                <td class="align-right" style="font-size: x-large">
                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="b" Text="cridet card" TextAlign="Left" />
                </td>
                <td class="align-right" style="font-size: x-large">
                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="b" Text="paypal" TextAlign="Left" />
                </td>
            </tr>
            <tr>
                <td colspan="5" style="text-align: center">
                    <asp:Label ID="Label1" runat="server" Font-Size="Large" ForeColor="Red"></asp:Label>
                    &nbsp;&nbsp;<asp:Button ID="Button1" runat="server" style="font-size: medium" Text="view" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" style="font-size: medium" Text="Remove" OnClick="Button2_Click" />
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" style="font-size: medium" Text="ADD" />
                </td>
            </tr>
        </table>
        <br />
        <table style="width: 100%">
            <tr>
                <td>&nbsp;</td>
                <td class="align-right">
                    <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Delete" />
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Show" />
                    <asp:DropDownList ID="DropDownList2" runat="server">
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
                &nbsp;
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Image ID="Image1" runat="server" />
                </td>
            </tr>
        </table>
        <table align="right" style="width: 50%; height: 111px;">
            <tr>
                <td class="align-left" colspan="2" style="font-size: large">Add picture </td>
            </tr>
            <tr>
                <td class="align-left" style="font-size: large">
                    Activity you want to add photos to:</td>
                <td class="align-right" style="font-size: large">
                    <asp:DropDownList ID="DropDownList3" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:FileUpload ID="FileUpload2" runat="server" />
                </td>
                <td>
                    <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="ADD" />
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
   </div>

    </form>


</asp:Content>
