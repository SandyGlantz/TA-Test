<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_051b_MegaWar_PC_final.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
        }
        .auto-style6 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
        }
        .auto-style3 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style4 {
            font-size: xx-small;
        }
        .auto-style5 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: xx-small;
        }
        .auto-style7 {
            margin-left: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style7">
        <p>
            <asp:Image ID="Image1" runat="server" CssClass="auto-style2" Height="172px" ImageUrl="~/war_title.png" Width="520px" />
            <br />
            <span class="auto-style2"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; War is a card game of <em>chance.</em><br />
            </strong></span>
            <br class="auto-style2" />
            <br class="auto-style2" />
            <asp:Button ID="okButton" runat="server" CssClass="auto-style2" OnClick="okButton_Click" Text="Game rules below. Click here to start a game." Width="513px" />
            <br class="auto-style2" />
            <br class="auto-style2" />
            <asp:Label ID="resultLabel" runat="server" CssClass="auto-style2"></asp:Label>
            <br class="auto-style2" />
            <br class="auto-style2" />
            <br class="auto-style2" />
            <span class="auto-style6">****************************************************************************</span><span class="auto-style3"><br class="auto-style4" />
            </span><span class="auto-style5">&nbsp;</span><span class="auto-style3"><br class="auto-style4" />
            </span><span class="auto-style2"><strong>How this game of War will be played:</strong><br />
            </span><span class="auto-style3">
            <br class="auto-style4" />
            </span><span class="auto-style6">Two players are dealt rotating cards from a full deck of cards (no Joker).<br />
            </span>
            <br class="auto-style6" />
            <span class="auto-style6">They then flip over a card from their half of the deck and see who wins the card &quot;battle.&quot;</span><br class="auto-style6" />
            <span class="auto-style6">The winner adds both cards to the bottom of their deck.</span><br class="auto-style6" />
            <span class="auto-style6">Cards are face value with Ace high; there is no advantage to one suit over another.<br />
            </span>
            <br class="auto-style6" />
            <span class="auto-style6">Should both players turn over the same value card in different suits, it becomes a &quot;WAR&quot; round.</span><br class="auto-style6" />
            <span class="auto-style6">In war rounds, four additional cards are drawn and flipped over - winner keeps all the cards.</span></p>
        <p>
            <span class="auto-style6">It is common for this game to go on for 300 or more rounds, until one player runs out of cards.</span><br class="auto-style6" />
            <span class="auto-style6">However, in this game, we are only going 20 rounds.</span><br class="auto-style6" />
            <span class="auto-style6">Highest number of cards will determine who wins.</span><br class="auto-style6" />
            <br class="auto-style6" />
        </p>
    </form>
</body>
</html>
