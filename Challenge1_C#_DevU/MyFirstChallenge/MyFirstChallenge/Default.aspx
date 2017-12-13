<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyFirstChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <br />
            <asp:Label ID="headerTextLabel" runat="server" BackColor="#FFFF99" Font-Bold="True" Font-Size="Large" Height="50px" Text=" MadLib for Devs" Width="550px"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Please enter an adjective:&nbsp;
            <asp:TextBox ID="wordOneTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Please enter another adjective:&nbsp;
            <asp:TextBox ID="wordTwoTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="clickButton" runat="server" OnClick="clickButton_Click" Text="Click for Mad Lib" />
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="madLibLabel" runat="server"></asp:Label>
            &nbsp;</p>
    <div>
    
    </div>
    </form>
</body>
</html>
