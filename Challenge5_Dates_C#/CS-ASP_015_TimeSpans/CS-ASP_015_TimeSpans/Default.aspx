<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_015.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &nbsp;&nbsp;&nbsp;&nbsp;
        <br class="auto-style1" />
        <br class="auto-style1" />
        <span class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;
    
        Working with spans of time (TimeSpan)</span><br class="auto-style1" />
        <br class="auto-style1" />
        <span class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp; </span>
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" CssClass="auto-style1" />
        <br class="auto-style1" />
        <br class="auto-style1" />
        <span class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp; </span>
        <asp:Label ID="resultLabel" runat="server" CssClass="auto-style1"></asp:Label>
    
    </div>
    </form>
</body>
</html>
