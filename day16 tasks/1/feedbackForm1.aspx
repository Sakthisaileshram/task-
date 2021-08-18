<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="feedbackForm1.aspx.cs" Inherits="feedbackforum.feedbackForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Feedback forum</h1>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Student Name"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Sex"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="Label3" runat="server" Text="select Course "></asp:Label>
&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>IOT</asp:ListItem>
            <asp:ListItem>PYTHON</asp:ListItem>
            <asp:ListItem>C</asp:ListItem>
            <asp:ListItem>C#</asp:ListItem>
            <asp:ListItem>C++</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Technical coverage"></asp:Label>
        <br />
        <asp:RadioButtonList ID="RadioButtonList2" runat="server">
            <asp:ListItem>Excellent</asp:ListItem>
            <asp:ListItem>Good</asp:ListItem>
            <asp:ListItem>Average</asp:ListItem>
            <asp:ListItem>Poor</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Label ID="Label5" runat="server" Text="suggestions"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" Width="334px"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" Height="16px" Text="submit forum" OnClick="Button1_Click" style="margin-top: 0px" position ="bottom" />
&nbsp;&nbsp;
        <br />
    </form>
</body>
</html>
