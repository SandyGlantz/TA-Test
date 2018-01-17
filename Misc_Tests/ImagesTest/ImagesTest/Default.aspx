<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ImagesTest.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            margin-left: 80px;
        }
        .auto-style3 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
        }
        .auto-style4 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
            margin-left: 80px;
        }
    </style>
</head>
<body>
    <p class="auto-style2">
        <br class="auto-style3" />
    </p>
    <p class="auto-style4">
        This is a test of selecting random images.</p>
    <p class="auto-style4">
        &nbsp;</p>
    <form id="form1" runat="server" class="auto-style2">
        <p>
            <asp:Image ID="Image1" runat="server" CssClass="auto-style3" Height="150px" Width="150px" />
            <span class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:Image ID="Image2" runat="server" CssClass="auto-style3" Height="150px" Width="150px" />
            <span class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:Image ID="Image3" runat="server" CssClass="auto-style3" Height="150px" Width="150px" />
        </p>
        <p class="auto-style3">
            &nbsp;</p>
        <p>
            <asp:Button ID="click4RandImageButton" runat="server" CssClass="auto-style3" OnClick="click4RandImageButton_Click" Text="Click this button for random image(s)" />
        </p>
    <div>
    
    </div>
    </form>
</body>
</html>
