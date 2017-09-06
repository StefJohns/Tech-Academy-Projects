<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EpicSpiesAssignment.aspx.cs" Inherits="spyAssignment.EpicSpiesAssignment" %>

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
            <h1>
                <asp:Image ID="pageIcon" runat="server" Height="190px" ImageUrl="~/epic-spies-logo.jpg" />
            </h1>
            <h1>
                <br class="auto-style1" />
                <span class="auto-style1">Spy New Assignment Form</span></h1>
            <p>
                Spy Code Name:&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </p>
            <p>
                New Assignment Name:&nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </p>
            <p>
                &nbsp;</p>
            <p>
                End Date of Previous Assignment:<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            </p>
            <p>
                &nbsp;</p>
            <p>
                Projected Start Date of New Assignment:<asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
            </p>
            <p>
                &nbsp;</p>
            <p>
                Projected End Date of New Assignment:<asp:Calendar ID="Calendar3" runat="server"></asp:Calendar>
            </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:Button ID="assignButton" runat="server" OnClick="assignButton_Click" Text="Assign Spy" />
            </p>
            <p>
                <asp:Label ID="assignLabel" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
