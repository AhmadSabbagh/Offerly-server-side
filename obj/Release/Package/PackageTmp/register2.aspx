<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="register2.aspx.cs" Inherits="orgproject.register2" %>
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
        <p>
            <table style="width: 100%">
                <tr>
                    <td colspan="2">Agent accounts Manage:</td>
                </tr>
                <tr>
                    <td colspan="2">To add a new agent, please enter all required fields. &nbsp; To modify agent information, please enter the customer number with the fields to be modified .To delete a specific agent&nbsp; please enter the customer number or name :</td>
                </tr>
                <tr>
                    <td style="height: 19px">Agent number</td>
                    <td style="height: 19px">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Agent name</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Confirm password </td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="height: 19px">Phone number</td>
                    <td style="height: 19px">
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Birthday</td>
                    <td>
                        <asp:TextBox ID="TextBox6" runat="server" TextMode="DateTimeLocal"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Address</td>
                    <td>
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="height: 21px">City</td>
                    <td style="height: 21px">
                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Category</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                        </asp:DropDownList>
                        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Button" />
                    </td>
                </tr>
                <tr>
                    <td>sub_category</td>
                    <td>
                        <asp:DropDownList ID="DropDownList2" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>description</td>
                    <td>
                        <asp:TextBox ID="TextBox9" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align: center">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="New entry" />
                        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Edit" />
                        <asp:Button ID="Button2" runat="server" Text="Delete" OnClick="Button2_Click" />
                        <asp:Button ID="Button3" runat="server" Text="View" />
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
                <FooterStyle BackColor="White" ForeColor="#333333" />
                <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#487575" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#275353" />
            </asp:GridView>
        </p>
    </form>
</asp:Content>
