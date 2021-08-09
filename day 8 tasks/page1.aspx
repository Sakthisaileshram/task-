<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page1.aspx.cs" Inherits="RegForm.page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>page1</title>
    <link rel="stylesheet" type="text/css" href="Content/StyleSheet1.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Registration form</h1>
            <p>
                <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txt_Fname" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_Fname" ErrorMessage="*enter name" ForeColor="Red"></asp:RequiredFieldValidator>
            </p>
            <p>
                <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txt_Lname" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_Lname" ErrorMessage="*enter Last Nmae" ForeColor="Red"></asp:RequiredFieldValidator>
            </p>
            <p>
                <asp:Label ID="Label3" runat="server" Text="Age"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txt_Age" runat="server" TextMode="Number"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Enter age" ControlToValidate="txt_Age" ForeColor="Red"></asp:RequiredFieldValidator>
            </p>
            <p>
                <asp:Label ID="Label4" runat="server" Text="Gender"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="rbox_Male" runat="server" Text="Male" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="rbox_Female" runat="server" Text="Female" />
            </p>
            <p>
                <asp:Label ID="Label5" runat="server" Text="Marital Status"></asp:Label>
&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="RBox_MaritalstatM" runat="server" Text="Married" />
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="Rbox_Single" runat="server" Text="Single" />
            </p>
            <p>
                <asp:Label ID="Label6" runat="server" Text="Email"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txt_email" runat="server" TextMode="Email"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label7" runat="server" Text="Pin Code"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txt_pin" runat="server" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label8" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txt_pword" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label9" runat="server" Text="Confirm Password"></asp:Label>
                &nbsp;&nbsp;
            </p>
            <p>
                <asp:TextBox ID="txt_cfrm" runat="server"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txt_pword" ControlToValidate="txt_cfrm" ErrorMessage=" *password does not match previous  password" ForeColor="Red"></asp:CompareValidator>
            </p>
            <p>
                <asp:Label ID="Label10" runat="server" Text="Occupation"></asp:Label>
&nbsp;
                <asp:CheckBox ID="CB_Engineer" runat="server" Text="Engineer" />
            &nbsp;
                <asp:CheckBox ID="Cb_Doctor" runat="server" Text="Doctor" />
&nbsp;&nbsp;
                <asp:CheckBox ID="cB_Lawyer" runat="server" Text="Lawyer" />
            </p>
            <p>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
            </p>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
            <p>&nbsp;</p>
        </div>
        <%--  --%>
    </form>
</body>
</html>
