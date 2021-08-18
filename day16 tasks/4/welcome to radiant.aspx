<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="welcome to radiant.aspx.cs" Inherits="feedbackforum.welcome_to_radiant" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASP.NET</title>
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
<body class="vertical-center">
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Click" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
