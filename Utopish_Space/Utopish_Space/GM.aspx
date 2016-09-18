<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GM.aspx.cs" Inherits="Utopish_Space.GM" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 246px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataKeyNames="AccountID" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="None" Height="378px" Width="462px">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <Columns>
                <asp:BoundField DataField="AccountID" HeaderText="AccountID" InsertVisible="False" ReadOnly="True" SortExpression="AccountID" />
                <asp:BoundField DataField="AccountName" HeaderText="AccountName" SortExpression="AccountName" />
                <asp:BoundField DataField="AccountPassword" HeaderText="AccountPassword" SortExpression="AccountPassword" />
                <asp:BoundField DataField="AccountEmail" HeaderText="AccountEmail" SortExpression="AccountEmail" />
                <asp:BoundField DataField="Gold" HeaderText="Gold" SortExpression="Gold" />
                <asp:BoundField DataField="Archer_Quant" HeaderText="Archer_Quant" SortExpression="Archer_Quant" />
                <asp:BoundField DataField="Knight_Quant" HeaderText="Knight_Quant" SortExpression="Knight_Quant" />
                <asp:BoundField DataField="MountKnight_Quant" HeaderText="MountKnight_Quant" SortExpression="MountKnight_Quant" />
                <asp:BoundField DataField="Bank_Quant" HeaderText="Bank_Quant" SortExpression="Bank_Quant" />
            </Columns>
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:UtopishDataBase2ConnectionString %>" SelectCommand="SELECT * FROM [Accounts]"></asp:SqlDataSource>
    </div>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataKeyNames="ArcherID" DataSourceID="SqlDataSource2" ForeColor="Black" GridLines="None">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <Columns>
                <asp:BoundField DataField="ArcherID" HeaderText="ArcherID" InsertVisible="False" ReadOnly="True" SortExpression="ArcherID" />
                <asp:BoundField DataField="Tier" HeaderText="Tier" SortExpression="Tier" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Cost" HeaderText="Cost" SortExpression="Cost" />
                <asp:BoundField DataField="HP" HeaderText="HP" SortExpression="HP" />
                <asp:BoundField DataField="AttackPower" HeaderText="AttackPower" SortExpression="AttackPower" />
                <asp:BoundField DataField="Armor" HeaderText="Armor" SortExpression="Armor" />
            </Columns>
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:UtopishDataBase3ConnectionString %>" SelectCommand="SELECT * FROM [Archers]"></asp:SqlDataSource>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <textarea id="TextArea1" cols="20" name="S1" rows="2"></textarea></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
