<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="advert1.aspx.cs" Inherits="orgproject.advert1" %>
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
        <table style="width: 100%; height: 242px">
            <tr>
                <td class="align-left" colspan="3" style="font-size: x-large; height: 52px;">popup ads System&nbsp; </td>
            </tr>
            <tr>
                <td class="align-left" style="font-size: medium; width: 154px">
                    <h3>Advert number</h3>
                </td>
                <td class="align-left" style="font-size: x-large" colspan="2">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="align-right" style="font-size: medium; width: 154px">
                    <h3 class="align-left">Advert</h3>
                </td>
                <td class="align-left" style="font-size: x-large" colspan="2">
                    <asp:TextBox ID="TextBox3" runat="server" Height="80px" style="margin-left: 0" Width="181px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="align-right" style="height: 30px; font-size: medium; width: 154px;">
                    <h3 class="align-left">Advert picture</h3>
                </td>
                <td class="align-right" style="font-size: x-large; height: 30px" colspan="2">
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="align-right" style="font-size: medium; width: 154px">
                    <h3>Ad Duration</h3>
                </td>
                <td class="align-left" style="font-size: x-large" colspan="2">&nbsp;<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="align-right" style="font-size: medium; width: 154px">
                    <h3>Duration of the appearance advert</h3>
                </td>
                <td class="align-left" style="font-size: x-large" colspan="2">&nbsp;<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="align-right" style="width: 154px">
                    <h3><span style="font-size: medium">customers Targeted</span></h3>
                </td>
                <td class="align-left" style="font-size: x-large">
                    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem Value="1">All</asp:ListItem>
                        <asp:ListItem Value="2">Male</asp:ListItem>
                        <asp:ListItem Value="4">Address</asp:ListItem>
                        <asp:ListItem Value="5">Age</asp:ListItem>
                        <asp:ListItem Value="3">Female</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="align-left" style="font-size: x-large">
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: center">
                    <asp:Label ID="Label1" runat="server" Font-Size="Large" ForeColor="Red"></asp:Label>
                    &nbsp;&nbsp;<asp:Button ID="Button1" runat="server" style="font-size: medium" Text="View" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" style="font-size: medium" Text="Delete" OnClick="Button2_Click" />
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" style="font-size: medium" Text="Add" />
                </td>
            </tr>
        </table>
        <table style="width: 100%">
            <tr>
                <td>&nbsp;</td>
                <td class="align-right">
                    &nbsp;<asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Delete" />
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="View" />
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
   </div>
    </form>
</asp:Content>
