<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pizzaMenu.aspx.cs" Inherits="pizzaAndSoftware.pizzaMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: xx-large;
        }
        .auto-style3 {
            color: #FF0000;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style4 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/PapaBob.png" />
            <span class="auto-style2"><strong>Papa Bob&#39;s Pizza and Software</strong></span></div>
        <br />
        <br />
        <asp:RadioButton ID="size1" runat="server" Checked="True" GroupName="pizzaSize" Text="Baby Bob Size (10&quot;) - $10" />
        <br />
        <asp:RadioButton ID="size2" runat="server" GroupName="pizzaSize" Text="Mama Bob Size (13&quot;) - $13" />
        <br />
        <asp:RadioButton ID="size3" runat="server" GroupName="pizzaSize" Text="Papa Bob Size (16&quot;) -$16" />
        <br />
        <br />
        <asp:RadioButton ID="crust1" runat="server" Checked="True" GroupName="crustGroup" Text="Thin Crust" />
        <br />
        <asp:RadioButton ID="crust2" runat="server" GroupName="crustGroup" Text="Deep Dish (+$2)" />
        <br />
        <br />
        <asp:CheckBox ID="topping1" runat="server" Text="Pepperoni (+$1.50)" />
        <br />
        <asp:CheckBox ID="topping2" runat="server" Text="Onions (+$0.75)" />
        <br />
        <asp:CheckBox ID="topping3" runat="server" Text="Green Peppers (+$0.50)" />
        <br />
        <asp:CheckBox ID="topping4" runat="server" Text="Red Peppers (+$0.75)" />
        <br />
        <asp:CheckBox ID="topping5" runat="server" Text="Anchovies (+$2)" />
        <h1><span class="auto-style4">Papa Bob&#39;s </span><span class="auto-style3">Special Deal</span></h1>
        <p>
            Save $2.00 when you add Pepperoni, Green Peppers and Anchovies OR Pepperoni, Red Peppers and Onions to your pizza.</p>
        <p>
            <asp:Button ID="purchaseButton" runat="server" OnClick="purchaseButton_Click" Text="Purchase" />
        </p>
        <p>
            Total:&nbsp; <asp:Label ID="totalLabel" runat="server" Text="$0.00"></asp:Label>
        </p>
        <p>
            Sorry, at this time you can only order one pizza online...and pick-up only......we NEED a better website!</p>
    </form>
</body>
</html>
