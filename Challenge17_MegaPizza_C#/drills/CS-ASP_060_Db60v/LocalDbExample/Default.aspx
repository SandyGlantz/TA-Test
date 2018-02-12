

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LocalDbExample.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div> <!-- moved this here from above the close tag before-->
        <p>
            <br class="auto-style1" />
&nbsp;<span class="auto-style1">&nbsp;&nbsp; </span>
            <asp:Label ID="resultLabel" runat="server" CssClass="auto-style1"></asp:Label>
        </p>
    

    </div>
    </form>
</body>
</html>
