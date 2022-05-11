<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="priv.aspx.cs" Inherits="orgproject.priv" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <table style="width: 100%">
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Font-Size="Medium" Height="17px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="154px">
                    </asp:DropDownList>
                    <asp:DropDownList ID="DropDownList2" runat="server" Height="16px" Width="170px">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:Timer ID="Timer1" runat="server" Interval="100" OnTick="Timer1_Tick">
                            </asp:Timer>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:GridView ID="GridView1" runat="server" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="5">
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                </td>
            </tr>
        </table>
        <br />
        <br />
    </form>
</asp:Content>
