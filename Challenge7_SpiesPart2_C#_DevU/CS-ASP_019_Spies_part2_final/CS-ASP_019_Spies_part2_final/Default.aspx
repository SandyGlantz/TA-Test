<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_019_Spies_part2_final.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
        }
        .auto-style3 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            background-color: #CCFFCC;
        }
        .auto-style4 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
        }
        .auto-style5 {
            font-size: medium;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image1" runat="server" Height="150px" ImageUrl="~/epic-spies-logo.jpg" />
        <br />
        <h4 class="auto-style2"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Asset Performance Tracker</strong></h4>
        <br />
        <br class="auto-style1" />
        <span class="auto-style4">Asset Code Name:&nbsp; </span>
        <asp:TextBox ID="assetNameTextBox" runat="server" CssClass="auto-style4"></asp:TextBox>
        <br class="auto-style5" />
        <br class="auto-style4" />
        <span class="auto-style4">Elections Rigged:&nbsp; </span>
        <asp:TextBox ID="electRiggedTextBox" runat="server" CssClass="auto-style4"></asp:TextBox>
        <span class="auto-style1"><span class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;
        </span>
        <br class="auto-style5" />
        <br class="auto-style5" />
        <span class="auto-style5">Acts of Subterfuge Performed:&nbsp; </span> </span>
        <asp:TextBox ID="subterfugeTextBox" runat="server" CssClass="auto-style4"></asp:TextBox>
        <br class="auto-style5" />
        <br class="auto-style4" />
        <asp:Button ID="okButton" runat="server" CssClass="auto-style3" OnClick="okButton_Click" Text="Add Asset Info" />
        <br class="auto-style5" />
        <br class="auto-style5" />
        <asp:Label ID="resultLabel" runat="server" CssClass="auto-style4"></asp:Label>
    
    </div>
    </form>
</body>
</html>
