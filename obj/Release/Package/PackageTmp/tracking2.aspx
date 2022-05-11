<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="tracking2.aspx.cs" Inherits="orgproject.tracking2" %>
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
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <asp:DropDownList ID="DropDownList1" runat="server" Height="40px" Width="208px">
            </asp:DropDownList>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
    </form>

</asp:Content>
