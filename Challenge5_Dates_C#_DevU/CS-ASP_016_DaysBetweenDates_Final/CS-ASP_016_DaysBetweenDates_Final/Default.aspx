<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_016_DaysBetweenDates_Final.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
        }
        .auto-style3 {
            background-color: #CCFFCC;
        }
        .auto-style4 {
            background-color: #CCFFFF;
        }
        .auto-style5 {
            background-color: #CCCCFF;
        }
    </style>
</head>
<body>
    <h2>
        <br class="auto-style1" />
        <span class="auto-style1">&nbsp; Challenge: Days Between Dates</span></h2>
    <p class="auto-style1">
        &nbsp;</p>
    <form id="form1" runat="server">
        <p class="auto-style2">
            &nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style3"><strong>Calendar 1:&nbsp; Choose a Date</strong></span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p class="auto-style2">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p class="auto-style2">
            &nbsp;</p>
        <p class="auto-style2">
            &nbsp; <span class="auto-style4"><strong>Calendar 2: Choose another Date</strong></span></p>
        <p class="auto-style2">
            <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
            &nbsp;</p>
        <p class="auto-style2">
            &nbsp;</p>
        <p class="auto-style2">
            &nbsp;</p>
        <p class="auto-style2">
            &nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style5"><strong>Click the OK button below for the magic ;-)</strong></span></p>
        <p>
            <span class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style2" Text="Button" />
            <span class="auto-style2">&nbsp;</span></p>
        <p>
            <span class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:Label ID="Label1" runat="server" CssClass="auto-style2" Text="Label"></asp:Label>
            <span class="auto-style2">&nbsp;</span></p>
        <p class="auto-style2">
            &nbsp;</p>
        <p class="auto-style2">
            &nbsp;</p>
    <div>
    
    </div>
    </form>
</body>
</html>
