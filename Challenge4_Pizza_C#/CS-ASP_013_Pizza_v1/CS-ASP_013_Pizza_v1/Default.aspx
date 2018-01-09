<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_013_Pizza_v1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            margin-left: 40px;
        }
        .auto-style4 {
            color: #FF3300;
        }
        .auto-style6 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            text-decoration: underline;
            background-color: #C4FFC4;
        }
        .auto-style7 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            background-color: #FFFFCC;
        }
        .auto-style8 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
        }
        .auto-style9 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            margin-left: 40px;
        }
        .auto-style11 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
        }
        .auto-style12 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: x-large;
        }
        .auto-style13 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            margin-left: 120px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image1" runat="server" ImageUrl="~/SengeTheGodfather.jpg" Height="150px" Width="140px" />
&nbsp;&nbsp;&nbsp; <span class="auto-style12"><strong>Senge The Godfather&#39;s: Pizza and Loans</strong></span></p>
    <div>
    
        <br />
    
    </div>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style8">&nbsp;</span><span class="auto-style11"><strong>Please choose a Pizza size:</strong></span></p>
        <p class="auto-style2">
            <asp:RadioButton ID="sm10RadioButton" runat="server" Checked="True" CssClass="auto-style11" GroupName="sizeGroup" Text="Small, $10 (10-inch) " />
            <span class="auto-style11">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:RadioButton ID="med13RadioButton" runat="server" CssClass="auto-style11" GroupName="sizeGroup" Text="Medium, $13 (13-inch)" />
            <span class="auto-style11">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:RadioButton ID="lg16RadioButton" runat="server" CssClass="auto-style11" GroupName="sizeGroup" Text="Large, $16 (16-inch)" />
        </p>
        <p class="auto-style9">
            &nbsp;</p>
        <p class="auto-style9">
            <strong>Choose your crust:</strong></p>
        <p class="auto-style2">
            <asp:RadioButton ID="regCrust0RadioButton" runat="server" Checked="True" CssClass="auto-style11" GroupName="crustGroup" Text="Regular Crust" />
            <span class="auto-style11">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:RadioButton ID="xtraCrust2RadioButton" runat="server" CssClass="auto-style11" GroupName="crustGroup" Text="Deep Dish Crust, adds $2" />
        </p>
        <p class="auto-style9">
            &nbsp;</p>
        <p class="auto-style2">
            <span class="auto-style6"><strong>Senge&#39;s </strong></span><span class="auto-style4"><strong><span class="auto-style6">Special Deal</span></strong></span><span class="auto-style6"><strong> - Save $2!</strong></span></p>
        <p class="auto-style2">
            <span class="auto-style11">save $2 off your order total when you get these combinations:</span></p>
        <p class="auto-style2">
            <span class="auto-style11">&nbsp;Pepperoni, Green Peppers, and Anchovies</span></p>
        <p class="auto-style2">
            <span class="auto-style7">&nbsp;-- or -- </span></p>
        <p class="auto-style2">
            <span class="auto-style11">Pepperoni, Red Peppers, and Onions </span></p>
        <p class="auto-style9">
            &nbsp;</p>
        <p class="auto-style9">
            <strong>What toppings would you like on your pizza?</strong></p>
        <p class="auto-style2">
            <asp:CheckBox ID="pepper15CheckBox" runat="server" CssClass="auto-style11" Text="Pepperoni, adds $1.50" />
            <span class="auto-style11">&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:CheckBox ID="onion075CheckBox" runat="server" CssClass="auto-style11" Text="Onions, adds $0.75" />
            <span class="auto-style11">&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:CheckBox ID="grnPep050CheckBox" runat="server" CssClass="auto-style11" Text="Green Peppers, adds $0.50" />
            <span class="auto-style11">&nbsp;&nbsp;&nbsp;&nbsp; </span>
        </p>
        <p class="auto-style2">
            <asp:CheckBox ID="redPep075CheckBox" runat="server" CssClass="auto-style11" Text="Red Peppers, adds $0.75" />
            <span class="auto-style11">&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:CheckBox ID="anch2CheckBox" runat="server" CssClass="auto-style11" Text="Anchovies, adds $2" />
        </p>
        <p class="auto-style9">
            &nbsp;</p>
        <p class="auto-style13">
            <asp:Button ID="orderButton" runat="server" BackColor="#CCFFCC" CssClass="auto-style11" Text="Place My Order!" OnClick="orderButton_Click" />
        </p>
        <p class="auto-style13">
            <span class="auto-style11">Total order:&nbsp; $</span><asp:Label ID="resultLabel" runat="server" CssClass="auto-style11"></asp:Label>
        </p>
    </form>
</body>
</html>
