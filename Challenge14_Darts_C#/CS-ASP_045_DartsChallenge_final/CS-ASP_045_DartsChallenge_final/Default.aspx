<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_045_DartsChallenge_final.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 80px;
        }
        .auto-style2 {
            margin-left: 160px;
        }
        .auto-style3 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
        }
        .auto-style4 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
            margin-left: 80px;
        }
        .auto-style5 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: xx-large;
            margin-left: 80px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <p class="auto-style1">
            <br class="auto-style2" />
        </p>
        <p class="auto-style5">
            <strong>&quot;Simple&quot; Darts Game</strong></p>
        <p class="auto-style4">
            &nbsp;</p>
        <p class="auto-style1">
            <asp:Image ID="Image1" runat="server" CssClass="auto-style3" DescriptionUrl="~/dartboard.jpg" Height="294px" ImageUrl="~/dartboard.jpg" Width="378px" />
        </p>
        <p class="auto-style4">
            &nbsp;</p>
        <p class="auto-style1">
            <br class="auto-style3" />
            <asp:Button ID="okButton" runat="server" CssClass="auto-style3" OnClick="okButton_Click" Text="Click to Play" />
            <br class="auto-style3" />
        </p>
        <p class="auto-style1">
            <br class="auto-style3" />
            <asp:Label ID="resultLabel" runat="server" CssClass="auto-style3"></asp:Label>
        </p>
    
    </div>
    </form>
</body>
</html>
