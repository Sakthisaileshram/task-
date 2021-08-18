<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="itemlist.aspx.cs" Inherits="feedbackforum.itemlist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>

.vertical-center {
  position: absolute;
  top: 50%;
  left: 50%;
  -ms-transform: translate(-50%, -50%);
  transform: translate(-50%, -50%);
            margin-left: 0;
            margin-right: 0;
            margin-top: 0;
        }
</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Welcome</h1>
            </div>
        <div class="vertical-center">
        
            <p>
                <asp:Label ID="Label1" runat="server" Text="select an item"></asp:Label>
&nbsp;&nbsp;
                <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" >
                    <asp:ListItem>brush</asp:ListItem>
                    <asp:ListItem>toothpaste</asp:ListItem>
                    <asp:ListItem>headphones</asp:ListItem>
                    <asp:ListItem>bread</asp:ListItem>
                </asp:ListBox>
&nbsp;
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="enter" />
           
                &nbsp;</p>
            <p>
           
                <asp:Image ID="Image1" runat="server" Height="189px" Width="212px" />
            </p>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>

        &nbsp;<br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="number of quantity"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="add to kart" />
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>

        </div>
    <p>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="176px" ImageUrl="~/WhatsApp Image 2021-08-18 at 9.18.12 PM.jpeg" OnClick="ImageButton1_Click" Width="287px" />
        </p>
        <p>
            <asp:ImageButton ID="ImageButton2" runat="server" Height="200px" ImageUrl="~/WhatsApp Image 2021-08-18 at 9.21.44 PM.jpeg" OnClick="ImageButton2_Click" Width="229px" />
        </p>
    </form>
    </body>
</html>
