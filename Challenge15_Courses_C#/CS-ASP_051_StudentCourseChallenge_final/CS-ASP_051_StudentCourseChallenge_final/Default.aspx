<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_051_StudentCourseChallenge_final.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 80px;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <br class="auto-style2" />
        <asp:Button ID="assignment1Button" runat="server" CssClass="auto-style2" OnClick="assignment1Button_Click" Text="Assignment 1" Width="400px" />
        <br class="auto-style2" />
        <br class="auto-style2" />
        <asp:Button ID="assignment2Button" runat="server" CssClass="auto-style2" OnClick="assignment2Button_Click" Text="Assignment 2" Width="400px" />
        <br />
        <br />
        <asp:Button ID="assignment2v2Button" runat="server" CssClass="auto-style2" OnClick="assignment2v2Button_Click" Text="Assignment 2v.2" Width="400px" />
        <br class="auto-style2" />
        <br class="auto-style2" />
        <asp:Button ID="assignment3Button" runat="server" CssClass="auto-style2" OnClick="assignment3Button_Click" Text="Assignment 3" Width="400px" />
        <br class="auto-style2" />
        <br />
        <br class="auto-style2" />
        <asp:Label ID="resultLabel" runat="server" CssClass="auto-style2"></asp:Label>
    
    </div>
    </form>
</body>
</html>
