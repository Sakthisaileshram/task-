<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calender.aspx.cs" Inherits="feedbackforum.calender" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Calendar ID="Calendar1" runat="server" BorderWidth="10" CellPadding="1" CellSpacing="4" Height="300px" Width="500px" SelectionMode="DayWeekMonth" FirstDayOfWeek="Saturday" DayHeaderStyle-BackColor="Brown" OtherMonthDayStyle-BackColor="Gray" SelectedDayStyle-BackColor="LightBlue"  ></asp:Calendar>
    </form>
</body>
</html>
