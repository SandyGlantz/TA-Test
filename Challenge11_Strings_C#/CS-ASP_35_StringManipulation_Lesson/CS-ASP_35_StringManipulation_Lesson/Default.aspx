<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_35_StringManipulation_Lesson.Default" %>

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
    </style>
</head>
<body>
    <p class="auto-style1">
        <br />
    </p>
    <form id="form1" runat="server" class="auto-style1">
        <p>
            <asp:TextBox ID="inputTextBox" runat="server" CssClass="auto-style2" Height="50px" Width="1500px"></asp:TextBox>
        </p>
        <p class="auto-style2">
            &nbsp;</p>
        <p>
            <asp:Button ID="okButton" runat="server" CssClass="auto-style2" OnClick="okButton_Click" Text="Click to test the code" />
        </p>
        <p class="auto-style2">
            &nbsp;</p>
        <p>
            <asp:Label ID="outputLabel" runat="server" CssClass="auto-style2" Height="50px" Width="1500px"></asp:Label>
        </p>
    <div>
    
    </div>
    </form>
</body>
</html>
