<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreatePlayer.aspx.cs" Inherits="Utopish_Space.UserPages.CreatePlayer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../Scripts/bootstrap.js"></script>
    <script src="../Scripts/jquery-1.10.2.js"></script>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="../Utopish/LogginBackground.css" rel="stylesheet" />
    <script src="../Utopish/LogginBackground.js"></script>
</head>
<body style="overflow: hidden; margin: 0">
    <div class="overlay" id="main">
        <form id="form2" runat="server">
            <%-- <asp:Label ID="LabelGameName" runat="server" CssClass="LogginLabel" Text="Game name" Font-Names="Consolas" ForeColor="White"></asp:Label>--%>
            <%--   <asp:Button ID="ButtonChangeLoggin" CssClass="logginButton" runat="server" Font-Names="Consolas" Font-Size="Medium" Height="50px" Width="150px" Text="Register"  OnClick="Button3_Click" CausesValidation="false"/>--%>
            <br />
            <div id="logginPlanet1">
                <img src="../Graphic/Plantes/planet_21.png" style="height: 496px; width: 495px" />
            </div>
            <%-- START --%>
            <asp:Panel ID="Panel_CreatePlayer" runat="server">
                <div class="container">
                     <div class="row"><h1>Get Started</h1></div>
                    <div class="row">
                        <div class="col-md-4" runat="server" id="Col1">1</div>
                        <div class="col-md-4" runat="server" id="Col2">2</div>
                        <div class="col-md-4" runat="server" id="Col3">3</div>
                    </div>
                </div>
            </asp:Panel>
            <%-- END --%>
        </form>
        <div id="logginPlanet2">
            <img src="../Graphic/Plantes/planet_18.png" />

        </div>
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
