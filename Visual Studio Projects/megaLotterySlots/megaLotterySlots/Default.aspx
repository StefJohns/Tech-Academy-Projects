<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="megaLotterySlots.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="reelBox1" runat="server" Height="160px" Width="200px" />
            <asp:Image ID="reelBox2" runat="server" Height="160px" Width="200px" />
            <asp:Image ID="reelBox3" runat="server" Height="160px" Width="200px" />
            <br />
            <br />
            Your Bet:
            <asp:TextBox ID="BetBox" runat="server" Width="37px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="lever_Button" runat="server" OnClick="lever_Button_Click" Text="Pull The Lever!" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="moneyLabel" runat="server"></asp:Label>
            <br />
            <br />
            1 Cherry - x2 Your Bet       
            <br />
            2 Cherries - x3 Your Bet<br />
            3 Cherries - x4 Your Bet<br />
            3 7&#39;s - Jackpot - x100 Your Bet<br />
            HOWEVER ... if there&#39;s even one BAR you win nothing.</div>
    </form>
</body>
</html>
