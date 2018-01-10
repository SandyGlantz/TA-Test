<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_028.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
        }
        .auto-style2 {
            margin-left: 40px;
        }
        .auto-style3 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <p class="auto-style2">
                <br />
                <br />
                <br class="auto-style1" />
                <span class="auto-style3"><strong>Convert to Cups</strong></span><br class="auto-style1" />
        <br class="auto-style1" />
        <asp:TextBox ID="quantityTextBox" runat="server" AutoPostBack="True" OnTextChanged="quantityTextBox_TextChanged" CssClass="auto-style1"></asp:TextBox>
        <br class="auto-style1" />
        <br class="auto-style1" />
        <asp:RadioButton ID="fromCupsRadio" runat="server" AutoPostBack="True" GroupName="FromGroup" OnCheckedChanged="cupsRadio_CheckedChanged" Text="Cups" CssClass="auto-style1" />
        <br class="auto-style1" />
        <asp:RadioButton ID="fromPintsRadio" runat="server" AutoPostBack="True" GroupName="FromGroup" OnCheckedChanged="fromPintsRadio_CheckedChanged" Text="Pints" CssClass="auto-style1" />
        <br class="auto-style1" />
        <asp:RadioButton ID="fromQuartsRadio" runat="server" AutoPostBack="True" GroupName="FromGroup" OnCheckedChanged="fromQuartsRadio_CheckedChanged" Text="Quarts" CssClass="auto-style1" />
        <br class="auto-style1" />
        <asp:RadioButton ID="fromGallonsRadio" runat="server" AutoPostBack="True" GroupName="FromGroup" OnCheckedChanged="fromGallonsRadio_CheckedChanged" Text="Gallons" CssClass="auto-style1" />
        <br class="auto-style1" />
        <br class="auto-style1" />
        <asp:Label ID="resultLabel" runat="server" CssClass="auto-style1"></asp:Label>
            </p>
    </div>
    </form>
</body>
</html>
