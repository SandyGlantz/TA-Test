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
        <p class="auto-style3">
            <asp:RadioButton ID="pencilRadioButton" runat="server" CssClass="auto-style4" GroupName="deviceGroup" style="font-family: Arial, Helvetica, sans-serif; font-size: large" Text="  Pencil &amp; paper " />
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
            <asp:Button ID="okButton" runat="server" CssClass="auto-style4" style="font-family: Arial, Helvetica, sans-serif; font-size: large" Text="Click for Result" OnClick="okButton_Click" />
        </p>
        <p class="auto-style3">
            <asp:Label ID="resultLabel" runat="server" CssClass="auto-style4" style="font-family: Arial, Helvetica, sans-serif; font-size: large"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p class="auto-style3">
            &nbsp;
            <asp:ImageButton ID="pencilImageButton" runat="server" Height="175px" ImageUrl="~/pencil.png" Visible="False" Width="125px" />
            <asp:ImageButton ID="penImageButton" runat="server" Height="175px" ImageUrl="~/pen.png" Visible="False" Width="140px" />
            <asp:ImageButton ID="iphoneImageButton" runat="server" Height="145px" ImageUrl="~/phone.png" Visible="False" Width="140px" />
            <asp:ImageButton ID="ipadImageButton" runat="server" Height="175px" ImageUrl="~/tablet.png" Visible="False" Width="220px" />
        </p>
        <p class="auto-style3">
            &nbsp;</p>
        <p class="auto-style3">
            <asp:Image ID="resultImage" runat="server" Visible="False" Height="250px" Width="250px" />
        </p>
        <p class="auto-style6">
            &nbsp;</p>
        <p class="auto-style3">
            &nbsp;</p>
        <p class="auto-style3">
            &nbsp;</p>
    </form>
</body>
</html>
