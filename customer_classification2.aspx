<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="customer_classification2.aspx.cs" Inherits="orgproject.customer_classification2" %>
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
        <table style="width: 50%">
            <tr>
                <td colspan="2">SORT</td>
            </tr>
            <tr>
                <td colspan="2">Choose the category you want through Category :</td>
            </tr>
            <tr>
                <td>Sort by: </td>
                <td>
                    <asp:DropDownList ID="DropDownList2" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="sort" />
                </td>
            </tr>
        </table>
        <br />
        <table style="width: 100%">
            <tr>
                <td colspan="2" style="height: 19px; font-size: x-large">
                    FILTER</td>
            </tr>
            <tr>
                <td colspan="2" style="height: 19px; font-size: x-large">
                    <pre><strong>Enter the field you want to filter through :</strong></pre>
                </td>
            </tr>
            <tr>
                <td>
                    <pre style="font-size: large">Gnder:</pre>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="height: 19px">
                    <pre style="font-size: large">Age:</pre>
                </td>
                <td style="height: 19px">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <pre style="font-size: large">Address:</pre>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="font-size: large">
                    <pre>birthday:</pre>
                </td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Filter" />
                </td>
            </tr>
        </table>
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <br />
    </form>
</asp:Content>
