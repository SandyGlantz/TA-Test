<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MySimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
        &nbsp;</p>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;<asp:Label ID="headerLabel" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="X-Large" Text=" Simple Calculator in C#"></asp:Label>
        <br />
        <br />
    
    </div>
        <asp:Label ID="firstValueLabel" runat="server" Font-Names="Arial" Font-Size="Large" Text="First Value: "></asp:Label>
&nbsp;
        <asp:TextBox ID="firstNumTextBox" runat="server" Font-Names="Arial" Font-Size="Large" Width="100px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="secondValueLabel" runat="server" Font-Names="Arial" Font-Size="Large" Text="Second Value:"></asp:Label>
&nbsp;
        <asp:TextBox ID="secondNumTextBox" runat="server" Font-Names="Arial" Font-Size="Large" Width="100px"></asp:TextBox>
        <br />
        <br />
        <br />
&nbsp;
        <asp:Button ID="addButton" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Medium" Height="50px" OnClick="AddButton_Click" Text=" + " Width="50px" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="minusButton" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Medium" Height="50px" OnClick="Button2_Click" Text=" - " Width="50px" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="multiButton" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Medium" Height="50px" OnClick="multiButton_Click" Text=" x " Width="50px" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="diviButton" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Medium" Height="50px" OnClick="diviButton_Click" Text=" % " Width="50px" />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="resultLabel" runat="server" BackColor="#CAEEFF" Font-Bold="True" Font-Names="Arial" Font-Size="X-Large"></asp:Label>
        <br />
        <br />
        <br />
    </form>
</body>
</html>
