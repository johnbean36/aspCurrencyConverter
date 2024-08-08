<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CurrencyConverter.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Convert:    "></asp:Label>
            <asp:TextBox ID="TxtUSD" runat="server" Width="177px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="USD to:      "></asp:Label>
&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Selected="True">Select a Currency</asp:ListItem>
                <asp:ListItem Value="1">Euro</asp:ListItem>
                <asp:ListItem Value="2">Canadian</asp:ListItem>
                <asp:ListItem Value="3">Japense Yen</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <asp:Button ID="BtnOk" runat="server" OnClick="BtnOk_Click" Text="OK" Width="84px" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnGraph" runat="server" OnClick="BtnGraph_Click" Text="Show Graph" Width="86px" />
            <br />
            <br />
        </div>
        <asp:Image ID="ImgGraph" runat="server" Height="171px" ImageUrl="images/blank.jpg" Width="291px" />
        <br />
        <br />
        <asp:Label ID="LblMessage" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
