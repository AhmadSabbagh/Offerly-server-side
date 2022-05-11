<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Categorieagent1.aspx.cs" Inherits="orgproject.Categorieagent1" %>
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
                <td>Add a new Category for agent </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Category Name :</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <table style="width: 50%">
            <tr>
                <td colspan="2">Add a subcategory </td>
            </tr>
            <tr>
                <td>Main Category </td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="height: 19px">Subcategory </td>
                <td style="height: 19px">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Add" />
                    <asp:Label ID="Label1" runat="server"></asp:Label>
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
        <table style="width: 50%">
            <tr>
                <td colspan="2">View Category and Agents</td>
            </tr>
            <tr>
                <td>Main Category </td>
                <td>
                    <asp:DropDownList ID="DropDownList2" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Subcategory </td>
                <td>
                    <asp:DropDownList ID="DropDownList3" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="View" />
                </td>
            </tr>
        </table>
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</asp:Content>
