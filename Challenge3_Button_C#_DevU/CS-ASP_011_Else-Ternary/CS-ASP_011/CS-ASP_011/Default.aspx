<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_011.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style2 {
            background-color: #FFFFCC;
        }
        .auto-style3 {
            font-size: large;
            font-family: Arial, Helvetica, sans-serif;
            background-color: #FFFFCC;
        }
        .auto-style4 {
            background-color: #FFFFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <span class="auto-style1">
        <br />
        <span class="auto-style2">Example1--Comparison:</span><br />
    
        Is
        </span>
        <asp:TextBox ID="firstTextBox" runat="server" CssClass="auto-style1"></asp:TextBox>
        <span class="auto-style1">&nbsp;equal to
        </span>
        <asp:TextBox ID="secondTextBox" runat="server" CssClass="auto-style1"></asp:TextBox>
        <span class="auto-style1">&nbsp;?</span><br class="auto-style1" />
        <br class="auto-style1" />
        <br class="auto-style1" />
        <span class="auto-style3"><span class="auto-style2"><span class="auto-style1">Example2--Checkbox--</span></span>Checked status:</span><br class="auto-style1" />
        <asp:CheckBox ID="coolCheckBox" runat="server" Text="Are you cool?" CssClass="auto-style1" />
        <br class="auto-style1" />
        <br class="auto-style1" />
        <br class="auto-style1" />
        <span class="auto-style3"><span class="auto-style2"><span class="auto-style1">Example3--RadioButtons--</span></span>Using <strong>Group</strong> attribute:</span><br class="auto-style1" />
        <span class="auto-style1">If you could only eat one food for the rest of your life, what would you choose?</span><br class="auto-style1" />
        <asp:RadioButton ID="pizzaRadioButton" runat="server" GroupName="FoodGroup" Text="Pizza" CssClass="auto-style1" />
        <br class="auto-style1" />
        <asp:RadioButton ID="saladRadioButton" runat="server" GroupName="FoodGroup" Text="Salad" CssClass="auto-style1" />
        <br class="auto-style1" />
        <asp:RadioButton ID="pbjRadioButton" runat="server" GroupName="FoodGroup" Text="Chocolate" CssClass="auto-style1" />
        <br class="auto-style1" />
        <br />
        <br class="auto-style1" />
        <span class="auto-style3"><span class="auto-style2"><span class="auto-style1">Example4--Ternary Checkbox</span></span>:<br />
        <asp:CheckBox ID="oldCheckBox" runat="server" CssClass="auto-style4" Text="  Are you old? " />
        <br />
        <br />
        <br />
        </span>
        <br class="auto-style1" />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" CssClass="auto-style1" />
        <br class="auto-style1" />
        <br class="auto-style1" />
        <span class="auto-style3">Output (result label):</span><br class="auto-style1" />
        <asp:Label ID="resultLabel" runat="server" CssClass="auto-style1"></asp:Label>
    
    </div>
    </form>
</body>
</html>
