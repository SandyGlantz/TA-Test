<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderManagementPage.aspx.cs" Inherits="KittyPizza.Web.OrderManagement_Web" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Completion Screen</title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 40px;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style3 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <br class="auto-style2" />
        <span class="auto-style3"><strong>Order Management Screen</strong></span><br class="auto-style2" />
        <span class="auto-style2"><em>&nbsp;... aka Pizza to-do list<br />
        </em></span>
        <br class="auto-style2" />
        <br class="auto-style2" />

        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" Font-Names="Arial" GridLines="Horizontal" OnRowCommand="GridView1_RowCommand">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <Columns>
                <asp:ButtonField Text="Complete" />
            </Columns>
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <SortedAscendingCellStyle BackColor="#F4F4FD" />
            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
            <SortedDescendingCellStyle BackColor="#D8D8F0" />
            <SortedDescendingHeaderStyle BackColor="#3E3277" />
        </asp:GridView>

        <br />
    </div>
    </form>
</body>
</html>
