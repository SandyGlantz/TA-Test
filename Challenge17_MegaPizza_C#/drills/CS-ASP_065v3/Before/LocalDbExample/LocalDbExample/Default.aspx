

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LocalDbExample.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style2 {
            margin-left: 40px;
        }
        .auto-style3 {
            font-size: medium;
        }
        .auto-style4 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
        }
        .auto-style5 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: x-large;
        }
        .auto-style10 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
        }
        .auto-style11 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 6pt;
        }
        .auto-style12 {
            margin-left: 43px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        <strong><span class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span><span class="auto-style5">Customer Input Page</span>
        <br />
        </strong>
        <br />
        <hr class="auto-style12" />
        <br />
        <br />
         <asp:GridView ID="customersGridView" runat="server" CssClass="auto-style2" Font-Names="Arial" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
             <AlternatingRowStyle BackColor="#F7F7F7" />
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
         <p class="auto-style2">
         <br class="auto-style1" />
             <span class="auto-style10">Name:&nbsp;&nbsp;&nbsp;&nbsp; </span> <asp:TextBox ID="nameTextBox" runat="server" CssClass="auto-style10" Font-Names="Arial"></asp:TextBox>
             <br class="auto-style10" />
         <br class="auto-style11" />
             <span class="auto-style10">Address:&nbsp; </span> <asp:TextBox ID="addressTextBox" runat="server" CssClass="auto-style10" Font-Names="Arial"></asp:TextBox>
             <br class="auto-style10" />
         <br class="auto-style11" />
             <span class="auto-style10">City:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span> <asp:TextBox ID="cityTextBox" runat="server" CssClass="auto-style10" Font-Names="Arial"></asp:TextBox>
             <br class="auto-style10" />
         <br class="auto-style11" />
             <span class="auto-style10">State:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span> <asp:TextBox ID="stateTextBox" runat="server" CssClass="auto-style10" Font-Names="Arial"></asp:TextBox>
             <br class="auto-style10" />
         <br class="auto-style11" />
             <span class="auto-style10">Zip:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span> <asp:TextBox ID="zipTextBox" runat="server" CssClass="auto-style10" Font-Names="Arial"></asp:TextBox>
             <br class="auto-style10" />
         <br class="auto-style11" />
             <span class="auto-style10">Notes:&nbsp;&nbsp;&nbsp;&nbsp; </span> <asp:TextBox ID="notesTextBox" runat="server" CssClass="auto-style10" Font-Names="Arial"></asp:TextBox>
             <br class="auto-style1" />
             <br class="auto-style1" />
             <br />
             <asp:Button runat="server" Text="Save the Data" ID="okButton" OnClick="okButton_Click" CssClass="auto-style3" Font-Names="Arial" Height="50px" Width="275px" />
          <br />  
         <br class="auto-style1" />
         <asp:Label ID="resultLabel" runat="server" CssClass="auto-style1" Font-Names="Arial"></asp:Label>
         </p>
    </div>
    </form>
</body>
</html>
