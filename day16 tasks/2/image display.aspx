<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="image display.aspx.cs" Inherits="feedbackforum.image_display" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>welcome</h1>
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" Height="125px" ImageUrl="~/download.png" OnClick="ImageButton1_Click" Width="152px" />
&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton2" runat="server" Height="124px" ImageUrl="~/rect.png" OnClick="ImageButton2_Click" Width="160px" />
&nbsp;
            <asp:ImageButton ID="ImageButton3" runat="server" Height="121px" ImageUrl="~/tri.png" OnClick="ImageButton3_Click" Width="165px" />
        </div>
        <asp:ImageButton ID="ImageButton4" runat="server" Height="102px" OnClick="ImageButton4_Click" Width="136px" />
    </form>
</body>
</html>
