<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webcontrols.aspx.cs" Inherits="feedbackforum.Webcontrols" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>

.vertical-center {
  margin: 0;
  position: absolute;
  top: 50%;
  left: 50%;
  -ms-transform: translate(-50%, -50%);
  transform: translate(-50%, -50%);
}
</style>
</head>
<body>
    <form id="form1" runat="server">
        
            <div class="vertical-center">
        
        <p>
            <asp:Label ID="Label1" runat="server" Text="hello"></asp:Label>
        &nbsp;</p>
                <p>
            <asp:Button ID="Button1" runat="server" Text="click me" />
        </p>
                <p>
            <asp:CheckBox ID="CheckBox1" runat="server" />
        </p>
             </div>
         
    </form>
</body>
</html>
