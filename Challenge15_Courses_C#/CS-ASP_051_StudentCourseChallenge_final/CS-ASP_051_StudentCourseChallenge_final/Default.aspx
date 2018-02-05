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
        .auto-style3 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: x-large;
        }
        .auto-style4 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
        }
        .auto-style5 {
            font-size: medium;
        }
        .auto-style6 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <br class="auto-style3" />
        <span class="auto-style3"><strong>Cat Charter Community College<br />
        </strong></span><span class="auto-style4"><em>Welcome to CCCC - Home of the Lions!<br />
        </em></span>
        <hr />
        <br />
    
        <br class="auto-style2" />
        <asp:Button ID="assignment1Button" runat="server" CssClass="auto-style6" OnClick="assignment1Button_Click" Text="Assignment 1" Width="250px" Font-Size="16pt" />
        <br />
        <br class="auto-style4" />
        &nbsp;<br class="auto-style2" />
        <asp:Button ID="assignment2Button" runat="server" CssClass="auto-style2" OnClick="assignment2Button_Click" Text="Assignment 2" Width="250px" Font-Size="16pt" />
        &nbsp;&nbsp;
        <asp:Button ID="assignment2v2Button" runat="server" CssClass="auto-style2" OnClick="assignment2v2Button_Click" Text="Assignment 2v.2" Width="250px" Font-Size="16pt" />
        &nbsp;&nbsp;
        <asp:Button ID="assignment2v3Button" runat="server" CssClass="auto-style2" Font-Size="16pt" OnClick="assignment2v3Button_Click" Text="Assignment 2v.3" Width="250px" />
        <br />
&nbsp;<br class="auto-style5" />
&nbsp;<br class="auto-style2" />
        <asp:Button ID="assignment3Button" runat="server" CssClass="auto-style2" OnClick="assignment3Button_Click" Text="Assignment 3" Width="250px" Font-Size="16pt" />
        <span class="auto-style2">&nbsp;&nbsp; </span>
        <asp:Button ID="assignment3v2Button" runat="server" CssClass="auto-style2" Font-Size="16pt" OnClick="assignment3v2Button_Click" Text="Assignment 3v.2" Width="250px" />
        <br class="auto-style2" />
        <span class="auto-style5">&nbsp;</span><br class="auto-style4" />
        &nbsp;<br class="auto-style2" />
        <asp:Label ID="resultLabel" runat="server" CssClass="auto-style2" Font-Size="16pt"></asp:Label>
    
    </div>
    </form>
</body>
</html>
