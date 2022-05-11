<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="orgproject.register" EnableEventValidation="false" %>
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
        <table style="width: 100%">
            <tr>
                <td class="align-right" colspan="2">
                    <pre style="font-size: large"><strong>:&#1575;&#1583;&#1585;&#1575;&#1577; &#1581;&#1587;&#1575;&#1576;&#1575;&#1578; &#1575;&#1604;&#1593;&#1605;&#1604;&#1575;&#1569; </strong></pre>
                </td>
            </tr>
            <tr>
                <td class="align-right" colspan="2" style="font-size: small"><span style="color: #FF0000">&#1604;&#1573;&#1590;&#1575;&#1601;&#1577; &#1593;&#1605;&#1610;&#1604; &#1580;&#1583;&#1610;&#1583; &#1610;&#1585;&#1580;&#1609; &#1575;&#1583;&#1582;&#1575;&#1604; &#1603;&#1575;&#1601;&#1577; &#1575;&#1604;&#1581;&#1602;&#1608;&#1604; &#1575;&#1604;&#1575;&#1580;&#1576;&#1575;&#1585;&#1610;&#1577; ,&#1604;&#1578;&#1593;&#1583;&#1610;&#1604; &#1605;&#1593;&#1604;&#1608;&#1605;&#1575;&#1578; &#1604;&#1593;&#1605;&#1610;&#1604; &#1610;&#1585;&#1580;&#1609; &#1575;&#1604;&#1590;&#1594;&#1591;</span>&nbsp; </td>
            </tr>
            <tr>
                <td class="align-right">
                    <asp:TextBox ID="TextBox1"  runat="server"></asp:TextBox>
                </td>
                <td class="align-right" style="font-size: medium">&#1585;&#1602;&#1605; &#1575;&#1604;&#1593;&#1605;&#1610;&#1604; </td>
            </tr>
            <tr>
                <td class="align-right">
                    <asp:TextBox ID="TextBox2"   runat="server"></asp:TextBox>
                </td>
                <td class="align-right" style="font-size: medium">&#1575;&#1587;&#1605; &#1575;&#1604;&#1593;&#1605;&#1610;&#1604; </td>
            </tr>
            <tr>
                <td class="align-right">
                    <asp:TextBox ID="TextBox3"  runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="align-right" style="font-size: medium">&#1603;&#1604;&#1605;&#1577; &#1575;&#1604;&#1605;&#1585;&#1608;&#1585;</td>
            </tr>
            <tr>
                <td class="align-right">
                    <asp:TextBox ID="TextBox4"  runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="align-right" style="font-size: medium">&#1578;&#1571;&#1603;&#1610;&#1583; &#1603;&#1604;&#1605;&#1577; &#1575;&#1604;&#1605;&#1585;&#1608;&#1585;</td>
            </tr>
            <tr>
                <td class="align-right">
                    <asp:TextBox ID="TextBox5"  runat="server"></asp:TextBox>
                </td>
                <td class="align-right" style="font-size: medium">&#1585;&#1602;&#1605; &#1575;&&#1585;&#1602;&#1605; &#1575;&#1604;&#1607;&#1575;&#1578;&#1601;</td>
            </tr>
            <tr>
                <td class="align-right">
                    <asp:TextBox ID="TextBox6"  runat="server"></asp:TextBox>
                </td>
                <td class="align-right" style="font-size: medium">&#1575;&#1604;&#1593;&#1606;&#1608;&#1575;&#1606;         <tr>
                <td class="align-right">
                    <asp:TextBox ID="TextBox7"  runat="server"></asp:TextBox>
                </td>
                <td class="align-right" style="font-size: medium">&#1575;&#1604;&#1605;&#1583;&#1610;&#1606;&#1577; </td>
            </tr>
            <tr>
                <td class="align-right">
                    <asp:TextBox ID="TextBox9"  runat="server" Height="57px" TextMode="MultiLine"></asp:TextBox>
                </td>
                <td class="align-right" style="font-size: medium">&#1575;&#1604;&#1608;&#1589;&#1601;</td>
            </tr>
            <tr>
                <td class="align-right">
                    <asp:Button CssClass="button" ID="Button6" runat="server" OnClick="Button6_Click" Text="&#1601;&#1585;&#1593;&#1610;" />
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="21px" Width="109px">
                    </asp:DropDownList>
                </td>
                <td class="align-right" style="font-size: medium">&#1575;&#1604;&#1578;&#1589;&#1606;&#1610;&#1601; </td>
            </tr>
            <tr>
                <td class="align-right">
                    <asp:DropDownList ID="DropDownList2" runat="server" Height="16px" Width="110px">
                    </asp:DropDownList>
                </td>
                <td class="align-right" style="font-size: medium">&#1575;&#1604;&#1578;&#1589;&#1606;&#1610;&#1601; &#1575;&#1604;&#1601;&#1585;&#1593;&#1610;</td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Label ID="Label1" runat="server" Font-Italic="True" Font-Size="Larger" ForeColor="Red"></asp:Label>
                    <asp:Button CssClass="button" ID="Button4" runat="server" OnClick="Button4_Click" Text="&#1593;&#1585;&#1590;" />
                    <asp:Button CssClass="button" ID="Button2" runat="server" OnClick="Button2_Click" Text="&#1578;&#1593;&#1583;&#1610;&#1604;" />
                    <asp:Button CssClass="button" ID="Button3" runat="server" OnClick="Button3_Click" Text="&#1581;&#1601;&#1592;" />
                    <asp:Button CssClass="button" ID="Button5" runat="server" OnClick="Button5_Click" Text="&#1580;&#1583;&#1610;&#1583;" />
                </td>
            </tr>
        </table>
        <table align="right" style="width: 45%; border: 1px solid #FF00FF; background-color: #C0C0C0">
            <tr>
                <td class="align-right" colspan="2" style="text-align: center; font-size: large">&#1581;&#1584;&#1601; &#1593;&#1605;&#1610;&#1604; &#1605;&#1593;&#1610;&#1606;</td>
            </tr>
            <tr>
                <td class="align-right">
                    <asp:Button ID="Button1" runat="server" Text="&#1581;&#1584;&#1601;" OnClick="Button1_Click" CssClass="button" />
                    </td>
                <td class="align-right">
                    <asp:DropDownList ID="DropDownList3" runat="server" Height="16px" Width="158px">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        <table style="width: 40%; border: 1px solid #FF00FF; background-color: #C0C0C0">
            <tr>
                <td colspan="3" style="text-align: center; font-size: large">&#1578;&#1593;&#1583;&#1610;&#1604; &#1576;&#1610;&#1575;&#1606;&#1575;&#1578; &#1593;&#1605;&#1610;&#1604; </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button7" runat="server" Text="&#1578;&#1581;&#1583;&#1610;&#1579;" OnClick="Button7_Click" CssClass="button" />
                </td>
                <td>
                    <asp:Button ID="Button8" runat="server" Text="&#1593;&#1585;&#1590;" OnClick="Button8_Click" CssClass="button" />
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList4" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <table style="width: 100%; border: 1px solid #FF00FF; background-color: #C0C0C0">
            <tr>
                <td colspan="4" style="text-align: center"><span style="font-size: large">&#1575;&#1590;&#1575;&#1601;&#1577; &#1601;&#1585;&#1608;&#1593; &#1604;&#1593;&#1605;&#1610;&#1604; &#1605;&#1593;&#1610;&#1606;</span> </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TextBox10" runat="server" Width="142px"></asp:TextBox>
                </td>
                <td style="font-size: medium">&#1575;&#1587;&#1605; &#1575;&#1604;&#1601;&#1585;&#1593; </td>
                <td>
                    <asp:DropDownList ID="DropDownList5" runat="server" Height="16px" Width="123px">
                    </asp:DropDownList>
                </td>
                <td style="font-size: medium">&#1575;&#1587;&#1605; &#1575;&#1604;&#1593;&#1605;&#1610;&#1604; </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="&#1581;&#1601;&#1592;" CssClass="button" />
                </td>
                <td><span style="font-size: medium">&#1575;&#1604;&#1605;&#1608;&#1602;&#1593;</span> </td>
                <td>
                    <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                </td>
                <td style="font-size: medium">&#1585;&#1602;&#1605; &#1575;&#1604;&#1607;&#1575;&#1578;&#1601; </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <br />
        <br />
        <br />
        <br />
    </form>
</asp:Content>
