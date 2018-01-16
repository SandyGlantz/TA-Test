<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ValuesTest.Default" %>

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
    <p>
        <br />
    </p>
    <p class="auto-style1">
        This is a simple (?) test to see how to carry values across multiple click events</p>
    <p class="auto-style1">
        &nbsp;</p>
    <p class="auto-style1">
        &nbsp;</p>
    <form id="form1" runat="server">
        <p>
            <span class="auto-style1">Enter a number to add:
            </span>
            <asp:TextBox ID="num1TextBox" runat="server" CssClass="auto-style1"></asp:TextBox>
        </p>
        <p class="auto-style1">
            &nbsp;</p>
        <p>
            <span class="auto-style1">Enter a second number to add:
            </span>
            <asp:TextBox ID="num2TextBox" runat="server" CssClass="auto-style1"></asp:TextBox>
        </p>
        <p class="auto-style1">
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <span class="auto-style1">The total of this calculation is: </span>
            <asp:Label ID="thisCalcTotalLabel" runat="server" CssClass="auto-style1"></asp:Label>
        </p>
        <p>
            <span class="auto-style1">The new total is: </span>
            <asp:Label ID="newTotalLabel" runat="server" CssClass="auto-style1"></asp:Label>
        </p>
        <p class="auto-style1">
            &nbsp;</p>
        <p class="auto-style1">
            Click OK to get total, and add new numbers:</p>
        <p>
            <asp:Button ID="okButton" runat="server" CssClass="auto-style1" OnClick="okButton_Click" Text="OK, Make It So" />
        </p>
    <div>
    
    </div>
    </form>
</body>
</html>
