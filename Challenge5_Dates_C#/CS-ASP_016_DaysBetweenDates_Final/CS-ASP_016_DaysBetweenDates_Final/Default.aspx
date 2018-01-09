<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_016_DaysBetweenDates_Final.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
        }
        .auto-style3 {
            background-color: #CCFFCC;
        }
        .auto-style4 {
            background-color: #CCFFFF;
            font-size: medium;
        }
        .auto-style8 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            background-color: #CCFFCC;
        }
        .auto-style9 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
        }
        .auto-style10 {
            font-size: medium;
        }
        .auto-style11 {
            background-color: #CCCCFF;
            font-size: medium;
        }
    </style>
</head>
<body>
    <h2 class="auto-style9">
        &nbsp; =====&nbsp; Challenge: Days Between Dates&nbsp; =====</h2>
    <p class="auto-style9">
        *************************************************************</p>
    <form id="form1" runat="server">
        <p class="auto-style2">
            &nbsp;<span class="auto-style3"><strong><span class="auto-style11"> Calendar 1:&nbsp; Choose a Date</span></strong></span><span class="auto-style10">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </span>
        </p>
        <p class="auto-style9">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Calendar ID="cal1" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" FirstDayOfWeek="Monday" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="222px" OnSelectionChanged="cal1_SelectionChanged" Width="374px">
                <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                <WeekendDayStyle BackColor="#CCCCFF" />
            </asp:Calendar>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p class="auto-style2">
            &nbsp;<span class="auto-style4"><strong> Calendar 2: Choose another Date </strong></span></p>
        <p class="auto-style2">
            <asp:Calendar ID="cal2" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" FirstDayOfWeek="Monday" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="222px" OnSelectionChanged="cal2_SelectionChanged" Width="374px">
                <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                <WeekendDayStyle BackColor="#CCCCFF" />
            </asp:Calendar>
            </p>
        <p class="auto-style2">
            &nbsp;</p>
        <p class="auto-style9">
            &nbsp; Calendar 1 date:&nbsp;
            <asp:Label ID="date1Label" runat="server"></asp:Label>
            &nbsp;</p>
        <p class="auto-style9">
            &nbsp; Calendar 2 date:&nbsp;
            <asp:Label ID="date2Label" runat="server"></asp:Label>
            &nbsp;&nbsp;</p>
        <p>
            <span class="auto-style9">&nbsp;&nbsp; </span>
            <span class="auto-style2">
            <asp:Button ID="okButton" runat="server" CssClass="auto-style8" Text="Calculate days" OnClick="okButton_Click" />
            </span></p>
        <p>
            <span class="auto-style9">&nbsp;&nbsp; Number of days between the dates =&nbsp; </span>
            <asp:Label ID="resultLabel" runat="server" CssClass="auto-style9"></asp:Label>
            <span class="auto-style9">&nbsp;</span></p>
        <p class="auto-style9">
            &nbsp;</p>
        <p class="auto-style2">
            &nbsp;</p>
    <div>
    
    </div>
    </form>
</body>
</html>
