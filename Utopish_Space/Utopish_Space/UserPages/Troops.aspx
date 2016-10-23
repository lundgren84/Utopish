<%@ Page Title="Troops" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Troops.aspx.cs" Inherits="Utopish_Space.User.Troops" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="text-align: center;"><%: Title %>.</h2>

    <div class="container-fluid" id="TroopConrainer" runat="server">
        <%-- TroopTrainObjectRow --%>
   <div class="row">
     
   </div>
       
    </div>
    <asp:Button ID="btn_TrainTroops" runat="server" Text="Train" OnClick="btn_TrainTroops_Click"/>
</asp:Content>
