

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LocalDbExample.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 40px;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
         &nbsp;<span class="auto-style2">&nbsp;&nbsp; </span>
         <br class="auto-style2" />
         <asp:GridView ID="customersGridView" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" Font-Names="Arial" GridLines="Vertical">
             <AlternatingRowStyle BackColor="#DCDCDC" />
             <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
             <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
             <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
             <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
             <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
             <SortedAscendingCellStyle BackColor="#F1F1F1" />
             <SortedAscendingHeaderStyle BackColor="#0000A9" />
             <SortedDescendingCellStyle BackColor="#CAC9C9" />
             <SortedDescendingHeaderStyle BackColor="#000065" />
         </asp:GridView>
         <br class="auto-style2" />
         <br class="auto-style2" />
         <br class="auto-style2" />
         <asp:Label ID="resultLabel" runat="server" CssClass="auto-style2"></asp:Label>
    </div>
    </form>
</body>
</html>
