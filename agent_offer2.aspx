<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="agent_offer2.aspx.cs" Inherits="orgproject.agent_offer2" %>
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
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="245px">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
        <br />
        <br />
        <br />
        <br />
        <br />
        <table style="width: 50%">
            <tr>
                <td colspan="2" style="font-size: large">
                    <pre style="font-size: large; height: 33px; width: 381px"><strong>Added by number and agent name :</strong></pre>
                </td>
            </tr>
            <tr>
                <td style="font-size: medium">Agent Number</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="font-size: medium">Agent name</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>
        </table>



        <br />
        <br />
        <br />
        <table style="width: 100%">
            <tr>
                <td colspan="2" style="font-size: x-large">
                    <pre style="height: 30px; font-size: large;"><strong>Add an offer to the specified agent:</strong></pre>
                   
                </td>
            </tr>
            <tr>
                <td>Ofer name:</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Discount:</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="height: 19px">Time:</td>
                <td style="height: 19px">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Start time:</td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>End time:</td>
                <td>
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </td>
            </tr>
            </table>



        <br />
        <table style="width: 100%">
            <tr>
                <td colspan="2" style="font-size: x-large">
                    <pre><strong>add pictures:</strong></pre>
                </td>
            </tr>
            <tr>
                <td style="height: 21px"><strong>picture:</strong></td>
                <td style="height: 21px">
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
            </tr>
        </table>
        <br />
        <br />



    </form>

</asp:Content>
