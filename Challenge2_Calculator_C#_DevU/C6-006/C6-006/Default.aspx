<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="C6_006.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style2 {
            color: #CC00FF;
        }
        .auto-style3 {
            background-color: #FFFF99;
        }
        .auto-style6 {
            text-decoration: underline;
        }
        .auto-style7 {
            width: 100%;
        }
        .auto-style8 {
            width: 677px;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style9 {
            text-decoration: underline;
            font-size: x-large;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style10 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style11 {
            text-decoration: underline;
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1 class="auto-style10">Headline 1</h1>
    
    </div>
        <h2 class="auto-style10">Headline 2</h2>
        <h3 class="auto-style10">Headline 3</h3>
        <h4 class="auto-style10">Headline 4</h4>
        <h5 class="auto-style10">Headline 5</h5>
        <h6 class="auto-style10">Headline 6</h6>
        <p class="auto-style1">
            <strong>This is a <span class="auto-style6">little</span> text I <em>want</em> to apply <span class="auto-style3">some</span> <span class="auto-style2">style</span> to.</strong></p>
        <p class="auto-style1">
            <a href="http://google.com">Add a hyperlink</a></p>
        <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style10" NavigateUrl="http://www.google.com" Target="_blank">This is another hyperlink</asp:HyperLink>
        <p>
            &nbsp;</p>
        <p class="auto-style9">
            <strong>IMAGE:</strong></p>
        <p>
            <asp:Image ID="Image1" runat="server" CssClass="auto-style10" Height="456px" ImageUrl="~/MarkTwain.jpg" Width="788px" />
        </p>
    </form>
    <p class="auto-style10">
        &nbsp;</p>
    <p class="auto-style10">
        &nbsp;</p>
    <p class="auto-style9">
        <strong>TABLE:</strong></p>
    <table class="auto-style7">
        <tr>
            <td class="auto-style8"><strong style="text-decoration: underline">Project</strong></td>
            <td class="auto-style10"><strong style="text-decoration: underline">Language</strong></td>
            <td class="auto-style11"><strong>Status</strong></td>
        </tr>
        <tr>
            <td class="auto-style8">Personal Site</td>
            <td class="auto-style10">HTML</td>
            <td class="auto-style10">needs some JS</td>
        </tr>
        <tr>
            <td class="auto-style8">Segment 2 - C# Fundamental</td>
            <td class="auto-style10">C#</td>
            <td class="auto-style10">underway</td>
        </tr>
    </table>
    <p class="auto-style10">
        &nbsp;</p>
    <p class="auto-style9">
        <strong>ORDERED LIST:</strong></p>
    <ol>
        <li class="auto-style10">First Item</li>
        <li class="auto-style10">Second Item</li>
        <li class="auto-style10">Third Item</li>
    </ol>
    <p class="auto-style11">
        &nbsp;</p>
    <p class="auto-style9">
        <strong>UNORDERED LIST:</strong></p>
    <ul>
        <li class="auto-style10">Idea 1</li>
        <li class="auto-style10">Idea 2</li>
        <li class="auto-style10">Idea 3</li>
    </ul>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
