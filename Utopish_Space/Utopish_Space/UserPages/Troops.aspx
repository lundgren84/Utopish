<%@ Page Title="Troops" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Troops.aspx.cs" Inherits="Utopish_Space.User.Troops" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="text-align: center;"><%: Title %>.</h2>

    <div class="container-fluid" id="TroopConrainer" runat="server">
        <%-- TroopTrainObjectRow --%>
        <div class="row">
            <%-- TroopName --%>
            <div class="col-md-2">
                <p class="LogginLabel" style="color: white">TroopName</p>
            </div>
            <%-- Train amount --%>
            <div class="col-md-2">
                <input  type="number" class="form-control LogginLabel">
            </div>
            <%-- Cost --%>
            <div class="col-md-3" style="border: solid 1px gray">
                  <p class="LogginLabel" style="color: white">TroopCost</p>
            </div>
            <%-- Stats --%>
            <div class="col-md-3" style="border: solid 1px gray">
                  <p class="LogginLabel" style="color: white">TroopStats</p>
            </div>
            <%-- TrainTime --%>
            <div class="col-md-2" style="border: solid 1px gray">
                   <p class="LogginLabel" style="color: white">TroopTrainTime</p>
            </div>
        </div>
        <div class="row">
            <div class="col-md-5"></div>
            <div class="col-md-2">
                <asp:Button ID="Button1" CssClass="logginButton" Font-Names="Consolas" Font-Size="Medium" Height="50px" Width="150px" runat="server" Text="TRAIN" />
            </div>
        </div>
    </div>
</asp:Content>
