<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="hiddenfile.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>home</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>gold and silver prices</h1>

            <br />
            <asp:HiddenField ID="HiddenField1" runat="server"  />
            <br />
            <asp:HiddenField ID="HiddenField2" runat="server" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Click on image to know price "></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Gold"></asp:Label>

        </div>
    &nbsp;
        <asp:ImageButton ID="ImageButton1" runat="server" Height="132px" ImageUrl="~/stack-of-golden-bars-in-the-bank-vault-60756080_1x1.jpg" OnClick="ImageButton1_Click" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Silver"></asp:Label>
        <br />
        <asp:ImageButton ID="ImageButton2" runat="server" Height="119px" ImageUrl="~/after-golden-year-for-precious-metals-silver-set-to-shine-in-2021.jpg" OnClick="ImageButton2_Click" Width="146px" />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Width="714px"></asp:TextBox>
        <br />
    </form>
</body>
</html>
