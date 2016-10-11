﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreatePlayer.aspx.cs" Inherits="Utopish_Space.UserPages.CreatePlayer" %>

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
   
<body>
        <form id="form2" runat="server">
        <br />
         
            <%-- START --%>
            <asp:Panel ID="Panel_CreatePlayer" runat="server">
                <div class="container">
                    <div class="row">
                        <h1>Get Started</h1>
                    </div>
                    <%-- SELECT Name --%>
                    <div class="row">
                        <div class="col-md-12" runat="server" id="Div1">
                            <asp:Label ID="Label1" runat="server" Text="Empire Name:"></asp:Label>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <%-- SELECT RACE --%>
                    <div class="row" runat="server" id="FillRaces">
             
                    </div>
                </div>
            </asp:Panel>
            <%-- END --%>
        </form>
</body>
</html>
<style>
      body {
        background: url('../Graphic/StarSky/space_up.png')fixed;
        background-repeat: no-repeat;
        background-size: cover;
        color:white;
    }
</style>