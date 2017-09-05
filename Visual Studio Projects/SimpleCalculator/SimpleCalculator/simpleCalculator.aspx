<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="simpleCalculator.aspx.cs" Inherits="SimpleCalculator.simpleCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Simple Calculator</h1>
        </div>
        <p>
            <span class="auto-style1"><strong>First Value</strong></span>:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="oneTextBox" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <p>
            <span class="auto-style1"><strong>Second Value</strong></span>:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="twoTextBox" runat="server" style="margin-left: 0px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="addButton" runat="server" Height="26px" OnClick="addButton_Click" Text="+" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="subButton" runat="server" OnClick="subButton_Click" Text="-" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="multButton" runat="server" OnClick="multButton_Click" Text="*" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="divdButton" runat="server" OnClick="divdButton_Click" Text="/" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server" OnDataBinding="addButton_Click"></asp:Label>
        </p>
    </form>
</body>
</html>
