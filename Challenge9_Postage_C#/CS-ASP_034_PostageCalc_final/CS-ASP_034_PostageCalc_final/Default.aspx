<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_034_PostageCalc_final.Default" %>

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
            font-size: large;
        }
        .auto-style3 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
            margin-left: 40px;
        }
        .auto-style4 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: x-large;
        }
        .auto-style5 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            margin-left: 40px;
        }
    </style>
</head>
<body>
    <p class="auto-style1">
        <strong>
        <br class="auto-style4" />
        </strong><span class="auto-style4"><strong>Postal Calculator</strong></span></p>
    <p class="auto-style3">
        &nbsp;</p>
    <p class="auto-style3">
        Please enter the width and height of your package; length is optional.</p>
    <p class="auto-style5">
        (Length defaults to the minimum of 1)</p>
    <form id="form1" runat="server" class="auto-style1">
        <p>
            <span class="auto-style2">Width:&nbsp;&nbsp;&nbsp; </span>
            <asp:TextBox ID="widthTextBox" runat="server" AutoPostBack="True" CssClass="auto-style2" OnTextChanged="checkForInputChange"></asp:TextBox>
        </p>
        <p>
            <span class="auto-style2">Height:&nbsp;&nbsp; </span>
            <asp:TextBox ID="heightTextBox" runat="server" AutoPostBack="True" CssClass="auto-style2" OnTextChanged="checkForInputChange"></asp:TextBox>
        </p>
        <p>
            <span class="auto-style2">Length:&nbsp; </span>
            <asp:TextBox ID="lengthTextBox" runat="server" AutoPostBack="True" CssClass="auto-style2" OnTextChanged="checkForInputChange"></asp:TextBox>
        </p>
        <p class="auto-style2">
            &nbsp;</p>
        <p class="auto-style2">
            Please select the delivery speed.</p>
        <p>
            <asp:RadioButton ID="groundRadioButton" runat="server" AutoPostBack="True" CssClass="auto-style2" GroupName="deliveryTypeRadioGroup" OnCheckedChanged="checkForInputChange" Text="Ground (3-5 days)" />
        </p>
        <p>
            <asp:RadioButton ID="airRadioButton" runat="server" AutoPostBack="True" CssClass="auto-style2" GroupName="deliveryTypeRadioGroup" OnCheckedChanged="checkForInputChange" Text="Air (2-3 days)" />
        </p>
        <p>
            <asp:RadioButton ID="nextDayRadioButton" runat="server" AutoPostBack="True" CssClass="auto-style2" GroupName="deliveryTypeRadioGroup" OnCheckedChanged="checkForInputChange" Text="Next Day (1 day/overnight)" />
        </p>
        <p class="auto-style2">
            &nbsp;</p>
        <p>
            <asp:Label ID="resultLabel" runat="server" CssClass="auto-style2"></asp:Label>
        </p>
    <div>
    
    </div>
    </form>
</body>
</html>
