<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_034b_MegaChallenge_Casino_final.Default" %>

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
            margin-left: 40px;
        }
        .auto-style3 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
        }
        .auto-style4 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: x-large;
            margin-left: 80px;
        }
        .auto-style5 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
            margin-left: 80px;
        }
        .auto-style6 {
            margin-left: 80px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p class="auto-style1">
            <br class="auto-style3" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="leftImage" runat="server" CssClass="auto-style3" Height="150px" Width="150px" />
            <span class="auto-style3">&nbsp; </span>
            <asp:Image ID="middleImage" runat="server" CssClass="auto-style3" Height="150px" Width="150px" />
            <span class="auto-style3">&nbsp; </span>
            <asp:Image ID="rightImage" runat="server" CssClass="auto-style3" Height="150px" Width="150px" />
&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p class="auto-style2">
            &nbsp;</p>
        <p class="auto-style1">
            <span class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp; Place your bet amount:&nbsp; </span>
            <asp:TextBox ID="amountBetTextBox" runat="server" CssClass="auto-style3"></asp:TextBox>
        </p>
        <p class="auto-style1">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style3">&nbsp;</span><asp:Button ID="makeBetButton" runat="server" CssClass="auto-style3" OnClick="makeBetButton_Click" Text="Pull the Lever!" />
        </p>
        <p class="auto-style5">
            &nbsp;</p>
        <p class="auto-style5">
            <asp:Label ID="betOutcomeLabel" runat="server"></asp:Label>
        </p>
        <p class="auto-style6">
            <asp:Label ID="playerBalanceLabel" runat="server" CssClass="auto-style3"></asp:Label>
        </p>
        <p class="auto-style5">
            &nbsp;</p>
        <p class="auto-style4">
            <strong>Here&#39;s how the Mega Casino pays out:</strong></p>
        <p class="auto-style5">
            One (1) Cherry gets your bet doubled&nbsp;
            <asp:Image ID="Image1" runat="server" DescriptionUrl="1 cherry" Height="30px" ImageUrl="~/images/Cherry.png" />
        </p>
        <p class="auto-style5">
            Two (2) Cherries and your bet is tripled!&nbsp;
            <asp:Image ID="Image2" runat="server" DescriptionUrl="1 cherry" Height="30px" ImageUrl="~/images/Cherry.png" />
&nbsp;<asp:Image ID="Image3" runat="server" DescriptionUrl="1 cherry" Height="30px" ImageUrl="~/images/Cherry.png" />
        </p>
        <p class="auto-style5">
            Three (3) Cherries quadruple your bet!&nbsp;
            <asp:Image ID="Image4" runat="server" DescriptionUrl="1 cherry" Height="30px" ImageUrl="~/images/Cherry.png" />
&nbsp;<asp:Image ID="Image5" runat="server" DescriptionUrl="1 cherry" Height="30px" ImageUrl="~/images/Cherry.png" />
&nbsp;<asp:Image ID="Image6" runat="server" DescriptionUrl="1 cherry" Height="30px" ImageUrl="~/images/Cherry.png" />
&nbsp;</p>
        <p class="auto-style5">
            Get three (3) &quot;7&#39;s&quot; in a row - and JACKPOT! You win 100 times the amount bet.
            <asp:Image ID="Image7" runat="server" DescriptionUrl="seven image" Height="30px" ImageUrl="~/Images/Seven.png" />
&nbsp;<asp:Image ID="Image8" runat="server" DescriptionUrl="seven image" Height="30px" ImageUrl="~/Images/Seven.png" />
&nbsp;<strong><asp:Image ID="Image9" runat="server" DescriptionUrl="seven image" Height="30px" ImageUrl="~/Images/Seven.png" />
            </strong>
        </p>
        <p class="auto-style5">
            <strong>However ... get a bar in any position, and you win nothing.&nbsp; </strong>
            <asp:Image ID="Image10" runat="server" Height="50px" ImageUrl="~/Images/Bar.png" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
