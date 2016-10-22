<%@ Page Title="Troops" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Troops.aspx.cs" Inherits="Utopish_Space.User.Troops" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="text-align: center;"><%: Title %>.</h2>

    <div class="container-fluid">
        <%-- TroopTrainObjectRow --%>
        <div class="row">
            <%-- TroopName --%>
            <div class="col-md-2">
                <asp:Label ID="Label1" CssClass="LogginLabel" ForeColor="White" runat="server" Text="TroopName"></asp:Label>
            </div>
            <%-- Train amount --%>
            <div class="col-md-2">
                <asp:TextBox ID="TextBox1" CssClass="LogginLabel" Width="100px" Font-Names="Consolas" runat="server" TextMode="Number"></asp:TextBox>
            </div>
            <%-- Cost --%>
               <div class="col-md-3" style="border:solid 1px gray">
                    <asp:Label ID="Label2" CssClass="LogginLabel" ForeColor="White" runat="server" Text="Cost"></asp:Label>
               </div>
              <%-- Stats --%>
               <div class="col-md-3" style="border:solid 1px gray">
                    <asp:Label ID="Label3" CssClass="LogginLabel" ForeColor="White" runat="server" Text="Stats"></asp:Label>
               </div>
              <%-- TrainTime --%>
               <div class="col-md-2" style="border:solid 1px gray">
                    <asp:Label ID="Label4" CssClass="LogginLabel" ForeColor="White" runat="server" Text="TrainTime"></asp:Label>
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
