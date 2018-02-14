<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="KittyPizza.Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kitty's Pizza</title>

    <!-- Bootstrap min version -->
    <link href="Content/bootstrap.min.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
    <div class="container">


    <div class ="page-header">
        <h1>Kitty's Pizza</h1>
        <p class ="lead">Coded for my code-mates</p>
     </div>
      <hr color="blue" >
        <br />  



     <div class="form-group">
        <label>Size: </label> 
        <asp:DropDownList ID="sizeDropDownList" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged ="recalculateTotalCost">
            <asp:ListItem Text="Select a Size" Value="" Selected="True" />
            <asp:ListItem Text="Kitten, $12.00" Value="Kitten" />
            <asp:ListItem Text="Cat, $14.00" Value="Cat" />
            <asp:ListItem Text="Lion, $16.00" Value="Lion" />
        </asp:DropDownList></div>




      <div class="form-group">
        <label>Crust: </label>
        <asp:DropDownList ID="crustDropDownList" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged ="recalculateTotalCost">
           <asp:ListItem Text="Select a Crust" Value="" Selected="True" />
           <asp:ListItem Text="Regular Gluten-free" Value="RegularGlutenFree" />
           <asp:ListItem Text="Thin Fried Salmon Skin" Value="ThinSalmonSkin" />
           <asp:ListItem Text="Thick Crispy Cheese, + $2.00)" Value="ThickCrispyCheese" /> 
        </asp:DropDownList></div>
    
        <br />
      
           
      <div class="checkbox"><label><asp:CheckBox ID="mouseCheckBox" runat="server" AutoPostBack="true" OnCheckedChanged ="recalculateTotalCost" />
        Ground Mouse, + $2.00</label></div>

      <div class="checkbox"><label><asp:CheckBox ID="goldfishCheckBox" runat="server" AutoPostBack="true" OnCheckedChanged ="recalculateTotalCost" />
        Smoked Goldfish, + $1.50</label></div>

      <div class="checkbox"><label><asp:CheckBox ID="catnipCheckBox" runat="server" AutoPostBack="true" OnCheckedChanged ="recalculateTotalCost" />
        Fresh Catnip, + $1.00</label></div>

        <div class="checkbox"><label><asp:CheckBox ID="grassCheckBox" runat="server" AutoPostBack="true" OnCheckedChanged ="recalculateTotalCost" />
        Grass Blades, + $1.00</label></div>





        <br />
        <br />
        <h3>Deliver To:</h3>

        <div class="form-group"><label>Name: </label>
            <asp:TextBox ID="nameTextBox" runat="server" CssClass="form-control">
            </asp:TextBox></div>

        <div class="form-group"><label>Address: </label>
            <asp:TextBox ID="addressTextBox" runat="server" CssClass="form-control">
            </asp:TextBox></div>

        <div class="form-group"><label>Zip: </label>
            <asp:TextBox ID="zipTextBox" runat="server" CssClass="form-control">
            </asp:TextBox></div>

        <div class="form-group"><label>Phone: </label>
            <asp:TextBox ID="phoneTextBox" runat="server" CssClass="form-control">
            </asp:TextBox></div>

      
        <br />
        <br />
        <h3>Payment:</h3>

        <div class="radio"><label>
        <asp:RadioButton ID="cashRadioButton" runat="server" GroupName="PayentGroup" Checked="false"/>
        Purr Cash</label></div>

        <div class="radio"><label>
        <asp:RadioButton ID="creditRadioButton" runat="server" GroupName="PayentGroup"/>
        Snuggle Credit</label></div>


            
        <br />
        <br />
        <asp:Button ID="orderButton" runat="server" Text="Place Order" CssClass="btn btn-primary" OnClick="orderButton_Click"/>

        <br />
        <br />
        <asp:Label ID="validationLabel" runat="server" Text="" CssClass="badge-warning" Visible="false"></asp:Label>
        <h3>Total Cost: <asp:Label ID="totalLabel" runat="server" Text=""></asp:Label></h3>
        <br />
        <br />


    </div>
    </form>

    <!-- the JQ scripts ... -->
    <script src="scripts/jquery-3.3.1.min.js"></script>
    <script src="scripts/bootstrap.bundle.min.js"></script>

</body>
</html>
