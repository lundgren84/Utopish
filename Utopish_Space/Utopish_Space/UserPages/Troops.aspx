<%@ Page Title="Troops" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Troops.aspx.cs" Inherits="Utopish_Space.User.Troops" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="text-align: center;"><%: Title %>.</h2>

    <div class="container-fluid" id="TroopConrainer" runat="server" style="text-align: center">
        <%-- TroopTrainObjectRow --%>
        <div class="row">
            <%-- TroopName --%>
            <div class="col-md-2">
            </div>
            <%-- TroopTextBox --%>
            <div class="col-md-2">
            </div>
            <%-- Troop cost --%>
            <div class="col-md-3">
                <asp:Label ID="Label1" runat="server" Text="Cost"></asp:Label>
            </div>
            <%-- Troop stats --%>
            <div class="col-md-3">
                <asp:Label ID="Label2" runat="server" Text="Stats"></asp:Label>
            </div>
            <%-- Troop TrainTime --%>
            <div class="col-md-2">
                
            </div>
        </div>
        <%-- ROW 2 --%>
        <div class="row">
            <%-- TroopName --%>
            <div class="col-md-2">
            </div>
            <%-- TroopTextBox --%>
            <div class="col-md-2">
            </div>
            <%-- Troop cost --%>
            <div class="col-md-3" style="border:solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">Mineral</div>
                        <div class="col-sm-4">Monney</div>
                        <div class="col-sm-4">Oil</div>
                    </div>
                </div>
            </div>
            <%-- Troop stats --%>
            <div class="col-md-3" style="border:solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">Attack</div>
                        <div class="col-sm-4">Defence</div>
                        <div class="col-sm-4">Speed</div>
                    </div>
                </div>
            </div>
            <%-- Troop TrainTime --%>
            <div class="col-md-2" style="border:solid 1px gray">
                <asp:Label ID="Label6" runat="server" Text="Train time"></asp:Label>
            </div>
        </div>
  <%-- TROOP 1 --%>
            <div class="row">
            <%-- TroopName --%>
            <div class="col-md-2">
                <asp:Label ID="lbl_T1Name" runat="server" Text="TroopName"></asp:Label>
            </div>
            <%-- TroopTextBox --%>
            <div class="col-md-2">
                <asp:TextBox ID="tb_T1" runat="server"></asp:TextBox>
            </div>
            <%-- Troop cost --%>
            <div class="col-md-3" style="border:solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">Mineral</div>
                        <div class="col-sm-4">Monney</div>
                        <div class="col-sm-4">Oil</div>
                    </div>
                </div>
            </div>
            <%-- Troop stats --%>
            <div class="col-md-3" style="border:solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">Attack</div>
                        <div class="col-sm-4">Defence</div>
                        <div class="col-sm-4">Speed</div>
                    </div>
                </div>
            </div>
            <%-- Troop TrainTime --%>
            <div class="col-md-2" style="border:solid 1px gray">
                <asp:Label ID="Label3" runat="server" Text="Train time"></asp:Label>
            </div>
        </div>
        <%-- END --%>
    </div>
    <asp:Button ID="btn_TrainTroops" runat="server" Text="Train" OnClick="btn_TrainTroops_Click"/>
</asp:Content>
