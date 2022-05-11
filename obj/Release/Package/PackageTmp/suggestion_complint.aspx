<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="suggestion_complint.aspx.cs" Inherits="orgproject.suggestion_complint" %>
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
                <td class="align-right"><span style="font-size: x-large">قائمة الاقتراحات</span> </td>
            </tr>
            <tr>
                <td class="align-right">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                    <br />
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="مسح الاقتراحات " />
                </td>
            </tr>
        </table>
        <br />
        <br />
         <table style="width: 100%">
            <tr>
                <td class="align-right"><span style="font-size: x-large">قائمة اقتراحات تحسين البرنامج</span> </td>
            </tr>
            <tr>
                <td class="align-right">
                    <asp:GridView ID="GridView3" runat="server">
                    </asp:GridView>
                    <br />
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="مسح الاقتراحات " />
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <table style="width: 100%">
            <tr>
                <td class="align-right" style="font-size: x-large">قائمة الشكاوي </td>
            </tr>
            <tr>
                <td class="align-right">
                    <asp:GridView ID="GridView2" runat="server">
                    </asp:GridView>
                    <br />
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="مسح الشكاوي" />
                </td>
            </tr>
        </table>
    </form>
</asp:Content>
