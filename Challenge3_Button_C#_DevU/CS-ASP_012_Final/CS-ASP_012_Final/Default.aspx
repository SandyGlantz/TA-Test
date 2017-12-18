<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_012_Final.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
            margin-left: 40px;
        }
        .auto-style3 {
            margin-left: 80px;
        }
        .auto-style6 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
            margin-left: 80px;
        }
        .auto-style7 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: xx-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
    
    </div>
        <div>
        </div>
        <p class="auto-style1">
            <strong>What is your preference for taking notes?:</strong></p>
        <p class="auto-style1">
            &nbsp;</p>
        <p class="auto-style3">
            <asp:RadioButton ID="pencilRadioButton" runat="server" CssClass="auto-style4" GroupName="deviceGroup" OnCheckedChanged="RadioButton2_CheckedChanged" style="font-family: Arial, Helvetica, sans-serif; font-size: large" Text="  Pencil &amp; paper " />
        </p>
        <p class="auto-style3">
            <asp:RadioButton ID="penRadioButton" runat="server" CssClass="auto-style4" GroupName="deviceGroup" style="font-family: Arial, Helvetica, sans-serif; font-size: large" Text="  Pen &amp; paper  " />
        </p>
        <p class="auto-style3">
            <asp:RadioButton ID="iphoneRadioButton" runat="server" CssClass="auto-style4" GroupName="deviceGroup" style="font-family: Arial, Helvetica, sans-serif; font-size: large" Text="  iPhone  " />
        </p>
        <p class="auto-style3">
            <asp:RadioButton ID="ipadRadioButton" runat="server" CssClass="auto-style4" GroupName="deviceGroup" style="font-family: Arial, Helvetica, sans-serif; font-size: large" Text="  iPad  " />
        </p>
        <p class="auto-style6">
            &nbsp;</p>
        <p class="auto-style3">
            <asp:Button ID="okButton" runat="server" CssClass="auto-style4" style="font-family: Arial, Helvetica, sans-serif; font-size: large" Text="Click for Result" />
        </p>
        <p class="auto-style6">
            &nbsp;</p>
        <p class="auto-style3">
            <asp:Label ID="resultLabel" runat="server" CssClass="auto-style4" style="font-family: Arial, Helvetica, sans-serif; font-size: large"></asp:Label>
        </p>
        <p class="auto-style6">
            &nbsp;</p>
        <p class="auto-style3">
            <asp:Image ID="resultImage" runat="server" CssClass="auto-style7" />
        </p>
        <p class="auto-style3">
            &nbsp;</p>
        <p class="auto-style3">
            &nbsp;</p>
        <p class="auto-style3">
            &nbsp;</p>
    </form>
</body>
</html>
