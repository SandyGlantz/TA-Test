<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GridViewButtonCommand.Default" %>

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
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style2">
    
        <h1 class="auto-style1">GridView Button Command</h1>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Font-Names="Arial" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:ButtonField Text="View" />
                <asp:BoundField DataField="Make" HeaderText="Make" />
                <asp:BoundField DataField="Model" HeaderText="Model" />
                <asp:BoundField DataField="Year" HeaderText="Year" />
                <asp:BoundField DataField="CarId" HeaderText="Car ID" />
            </Columns>
        </asp:GridView>
        <br class="auto-style1" />
        <asp:Label ID="resultLabel" runat="server" CssClass="auto-style1"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
