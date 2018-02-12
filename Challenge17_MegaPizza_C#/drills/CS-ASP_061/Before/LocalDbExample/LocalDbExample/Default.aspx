

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
        .auto-style2 {
            margin-left: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style2">
         <br class="auto-style1" />
         <br class="auto-style1" />
         <br class="auto-style1" />
         <asp:GridView ID="customersGridView" runat="server" Font-Names="Arial">
         </asp:GridView>
         <br class="auto-style1" />
         <br class="auto-style1" />
         <br class="auto-style1" />
         <br class="auto-style1" />
         <br class="auto-style1" />
         <asp:Label ID="resultLabel" runat="server" CssClass="auto-style1"></asp:Label>
    </div>
    </form>
</body>
</html>
