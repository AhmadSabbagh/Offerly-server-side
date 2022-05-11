<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="customer_classification1.aspx.cs" Inherits="orgproject.customer_classification1" EnableEventValidation="false" %>
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
            <table align="right" style="width: 50%; height: 132px; background-color: #FF6600; font-family: 'Times New Roman';">
                <tr>
                    <td class="align-right" colspan="2" style="font-size: large; color: #000000; text-align: center;">
                        <strong>&#1575;&#1604;&#1578;&#1589;&#1606;&#1610;&#1601;</strong></td>
                </tr>
                <tr>
                    <td class="align-right" colspan="2" style="font-size: x-large">
                        <dl>
                            <dd>
                                <p style="font-size: large; background-color: #FF6600;">
                                    &#1575;&#1582;&#1578;&#1585; &#1575;&#1604;&#1578;&#1589;&#1606;&#1610;&#1601; &#1575;&#1604;&#1584;&#1610; &#1578;&#1585;&#1610;&#1583;&nbsp; &#1575;&#1604;&#1578;&#1589;&#1606;&#1610;&#1601; &#1605;&#1606; &#1582;&#1604;&#1575;&#1604;&#1607;</p>
                            </dd>
                        </dl>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="DropDownList2" runat="server">
                            <asp:ListItem Value="1">&#1575;&#1604;&#1580;&#1606;&#1587;</asp:ListItem>
                            <asp:ListItem Value="2">&#1575;&#1604;&#1593;&#1605;&#1585;</asp:ListItem>
                            <asp:ListItem Value="3">&#1575;&#1604;&#1593;&#1606;&#1608;&#1575;&#1606;</asp:ListItem>
                            <asp:ListItem Value="4">&#1593;&#1610;&#1583; &#1575;&#1604;&#1605;&#1610;&#1604;&#1575;&#1583;</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="align-right" style="font-size: large">
                        <pre>:&#1575;&#1604;&#1578;&#1589;&#1606;&#1610;&#1601; &#1576;&#1581;&#1587;&#1576;</pre>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button2" runat="server" BackColor="Maroon" BorderColor="#FF6600" Text="&#1578;&#1589;&#1606;&#1610;&#1601;" OnClick="Button2_Click1" />
                    </td>
                </tr>
            </table>
       
        <table style="width: 46%; background-color: #FF9900; font-family: 'Times New Roman';">
            <tr>
                <td class="align-right" style="font-size: large; height: 46px; text-align: center;" colspan="3">
                    <span style="color: #000000"><strong>&#1575;&#1604;&#1576;&#1581;&#1579;</strong></span>&nbsp;
                </td>
            </tr>
            <tr>
                <td class="align-right" style="font-size: large; height: 46px;" colspan="3">
                    &#1575;&#1583;&#1582;&#1604; &#1575;&#1604;&#1581;&#1602;&#1604; &#1575;&#1604;&#1584;&#1610; &#1578;&#1585;&#1610;&#1583; &#1575;&#1604;&#1576;&#1581;&#1579; &#1605;&#1606; &#1582;&#1604;&#1575;&#1604;&#1607;</td>
            </tr>
            <tr>
                <td class="align-right" style="width: 232px" colspan="2">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="a">&#1575;&#1582;&#1578;&#1585; &#1575;&#1604;&#1580;&#1606;&#1587;</asp:ListItem>
                        <asp:ListItem Value="male">&#1584;&#1603;&#1585;</asp:ListItem>
                        <asp:ListItem Value="female">&#1575;&#1606;&#1579;&#1609;</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="align-right" style="font-size: large; width: 58px;">&#1575;&#1604;&#1580;&#1606;&#1587;</td>
            </tr>
            <tr>
                <td class="align-right" style="width: 232px">
                    <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="38px"></asp:TextBox>
                </td>
                <td class="align-right" style="width: 232px">
                    <asp:TextBox ID="TextBox4" runat="server" Height="16px" Width="33px"></asp:TextBox>
                </td>
                <td class="align-right" style="font-size: large; width: 58px;">&#1575;&#1604;&#1593;&#1605;&#1585;</td>
            </tr>
            <tr>
                <td class="align-right" style="width: 232px" colspan="2">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td class="align-right" style="font-size: large; width: 58px;">&#1605;&#1606;&#1591;&#1602;&#1577; &#1575;&#1604;&#1587;&#1603;&#1606;</td>
            </tr>
            <tr>
                <td class="align-right" style="width: 232px" colspan="2">
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="Date"></asp:TextBox>
                </td>
                <td class="align-right" style="font-size: large; width: 58px;">&#1593;&#1610;&#1583; &#1575;&#1604;&#1605;&#1610;&#1604;&#1575;&#1583;</td>
            </tr>
            <tr>
                <td class="align-right" style="width: 232px" colspan="2">
                    <asp:DropDownList ID="DropDownList3" runat="server">
                    </asp:DropDownList>
                </td>
                <td class="align-right" style="font-size: large; width: 58px;">&#1575;&#1604;&#1588;&#1576;&#1603;&#1577;</td>
            </tr>
            <tr>
                <td class="align-right" style="width: 232px" colspan="2">
                    <asp:DropDownList ID="DropDownList4" runat="server">
                        <asp:ListItem Value="a">&#1606;&#1608;&#1593; &#1575;&#1604;&#1580;&#1607;&#1575;&#1586; </asp:ListItem>
                        <asp:ListItem Value="1">Android</asp:ListItem>
                        <asp:ListItem Value="2">IOS</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="align-right" style="font-size: large; width: 58px;">&#1575;&#1604;&#1580;&#1607;&#1575;&#1586;</td>
            </tr>
            <tr>
                <td class="align-right" colspan="3">
                    <asp:Button ID="Button1" runat="server" BackColor="Maroon" BorderColor="#CC0000" BorderStyle="None" OnClick="Button1_Click" Text="&#1601;&#1604;&#1578;&#1585;&#1607;" style="margin-left: 0" />
                </td>
            </tr>
        </table>
            <br />
            <table style="width: 50%">
                <tr>
                    <td style="text-align: center">
                        <asp:Button class="button" ID="Button3" runat="server" BackColor="#FF9900" ForeColor="Black" Height="31px" OnClick="Button3_Click" Text="&#1578;&#1589;&#1583;&#1610;&#1585; &#1575;&#1604;&#1609; &#1575;&#1603;&#1587;&#1604;" Width="127px" />
                    </td>
                </tr>
            </table>
            <div style="text-align: center">
                <div class="align-right">
                <asp:GridView ID="GridView1" runat="server"  OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                </asp:GridView>
                <br />
            </div>
            <br />
            <br />
        </div>
        </div>
    </form>
    


</asp:Content>
