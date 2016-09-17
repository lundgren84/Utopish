<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Utopish_Space.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/jquery-1.10.2.js"></script>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Utopish/LogginBackground.css" rel="stylesheet" />
    <script src="Utopish/LogginBackground.js"></script>
</head>
<body style="overflow: hidden; margin: 0">
    <div class="overlay" id="main">
        <form id="form1" runat="server">
                <asp:Label ID="Label3" runat="server" class="LogginLabel"  Text="Game name" Font-Names="Consolas" ForeColor="White"></asp:Label><br />           
            <div id="logginPlanet1">
                <img src="Graphic/Plantes/planet_21.png"   style="height: 496px; width: 495px" />
            </div>
            <asp:Panel ID="PanelLoggin" runat="server">
                <asp:Label ID="Label1" runat="server" class="LogginLabel" Text="User name" ForeColor="White"></asp:Label><br />
                <asp:TextBox ID="TextBox1" class="LogginLabel" runat="server" Font-Names="Consolas" Height="40px"></asp:TextBox><br />
                <asp:Label ID="Label2" class="LogginLabel" runat="server" Text="Password" ForeColor="White"></asp:Label><br />
                <asp:TextBox ID="TextBox2" class="LogginLabel" runat="server" Height="40px" TextMode="Password" Font-Names="Consolas" OnTextChanged="TextBox2_TextChanged"></asp:TextBox><br />
                <asp:Button ID="Button1" CssClass="logginButton" runat="server" Text="Loggin" Font-Names="Consolas" Font-Size="Medium" Height="50px" Width="150px" />
               
            </asp:Panel>


            <div id="logginPlanet2">
                <img src="Graphic/Plantes/planet_18.png" />
            </div>
        </form>
    </div>
    <script>
        function autoResizeDiv() {
            document.getElementById('main').style.height = window.innerHeight + 'px';
        }
        window.onresize = autoResizeDiv;
        autoResizeDiv();
    </script>
</body>
</html>
