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
    <link href="../Style/PlayerCreation.css" rel="stylesheet" />

</head>
   
<body>
        <form id="form2" runat="server">
        <br />      
            <%-- START --%>
            <asp:Panel ID="Panel_CreatePlayer" runat="server">
                <div  class="container">
                    <div class="row">
                        <h1>Create player</h1>
                    </div>
                    <%-- SELECT Name --%>
                    <div class="row" style="margin-bottom:5%">
                        <div class="col-md-3" >
                              <p class="LogginLabel" style="text-align:end">Empire name:</p>
                        </div>
                        <div class="col-md-8" runat="server" id="Div1">                          
                            <asp:TextBox ID="TextBox_EmpireName" CssClass="LogginLabel" runat="server"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" Font-Names="consolas" runat="server" ErrorMessage="Required" ControlToValidate="TextBox_EmpireName"></asp:RequiredFieldValidator>
                        </div>
                    </div>

                    <div class="row" style="margin-bottom:5%">
                          <div class="col-md-3">  <p class="LogginLabel" style="text-align:end">Race:</p></div>
                         <div class="col-md-8" runat="server" id="Div3">                         
                             <asp:DropDownList ID="DropDownList_Races"  CssClass="LogginLabel" runat="server" Font-Names="consolas"></asp:DropDownList>
                             </div>
                    </div>
                    <%-- SELECT RACE --%>
                    <div class="row" runat="server" id="FillRaces">
             
                    </div>
                    <%-- CONFIRM --%>
                     <div class="row" runat="server" id="Div2">                 
                         <asp:Button ID="Button_ConfirmPlayer" CssClass="logginButton" OnClick="Button_ConfirmPlayer_Click" runat="server" Font-Names="Consolas" Font-Size="Medium" Height="50px" Width="150px" Text="Continue" />
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
