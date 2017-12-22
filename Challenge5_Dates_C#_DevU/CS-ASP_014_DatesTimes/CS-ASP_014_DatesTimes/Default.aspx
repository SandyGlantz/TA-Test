<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_014.Default" %>

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
    
        <br class="auto-style1" />
        <br class="auto-style1" />
        <span class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp; <strong>Working with DateTime<br />
        </strong></span><br class="auto-style1" />
        <br class="auto-style1" />
        <span class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp; </span>
        <asp:Button ID="okButton" runat="server" Text="OK" OnClick="okButton_Click" CssClass="auto-style1" />
        <br class="auto-style1" />
        <br class="auto-style1" />
        <span class="auto-style1">&nbsp; <strong>&nbsp;&nbsp; </strong></span><strong>
        <asp:Label ID="resultLabel" runat="server" CssClass="auto-style1"></asp:Label>
    
        </strong>
    
    </div>
    </form>
</body>
</html>
