<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="dragdata.aspx.cs" Inherits="orgproject.dragdata" EnableEventValidation="false" %>
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
    <div class="align-right">
        <table style="width: 100%">
            <tr>
                <td class="align-right" style="height: 30px; width: 154px">
                    &nbsp;</td>
                <td class="align-right" style="height: 30px">
                    <asp:Button class="button" ID="Button5" runat="server" OnClick="Button5_Click" Text="&#1593;&#1585;&#1590; &#1575;&#1604;&#1593;&#1605;&#1604;&#1575;&#1569;" />
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="align-right" colspan="2">
                    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="align-right" colspan="2">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                    <asp:Button class="button" ID="Button1" runat="server" Text="&#1575;&#1604;&#1575;&#1610;&#1605;&#1610;&#1604; &#1601;&#1602;&#1591;" OnClick="Button1_Click" />
                    <asp:Button class="button" ID="Button2" runat="server" Text="&#1575;&#1604;&#1585;&#1602;&#1605; &#1602;&#1591;" OnClick="Button2_Click" />
                    <asp:Button class="button" ID="Button3" runat="server" OnClick="Button3_Click" Text="&#1575;&#1604;&#1585;&#1602;&#1605; &#1605;&#1593; &#1575;&#1604;&#1575;&#1610;&#1605;&#1610;&#1604; " />
                </td>
            </tr>
            <tr>
                <td class="align-right" style="width: 154px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                <td class="align-right">
                    <asp:GridView ID="GridView2" runat="server">
                    </asp:GridView>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="Button4" runat="server" Text="&#1587;&#1581;&#1576; &#1575;&#1604;&#1609; &#1575;&#1603;&#1587;&#1604;" OnClick="Button4_Click" />
    </div>
</form>
</asp:Content>
