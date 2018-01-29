<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Darts_v1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            margin-left: 80px;
        }
        .auto-style3 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
        }
    </style>
</head>
<body>
    <p class="auto-style2">
        <br />
    </p>
    <form id="form1" runat="server" class="auto-style2">
        <p>
            <asp:Button ID="okButton" runat="server" CssClass="auto-style3" OnClick="okButton_Click" Text="Click to run Game" />
        </p>
        <p class="auto-style3">
            &nbsp;</p>
        <p>
            <asp:Label ID="resultLabel" runat="server" CssClass="auto-style3"></asp:Label>
        </p>
    <div>
    
    </div>
    </form>
</body>
</html>
