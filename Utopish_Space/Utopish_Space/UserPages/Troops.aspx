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
            <div class="col-md-3" style="border: solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">Mineral</div>
                        <div class="col-sm-4">Monney</div>
                        <div class="col-sm-4">Oil</div>
                    </div>
                </div>
            </div>
            <%-- Troop stats --%>
            <div class="col-md-3" style="border: solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">Attack</div>
                        <div class="col-sm-4">Defence</div>
                        <div class="col-sm-4">Speed</div>
                    </div>
                </div>
            </div>
            <%-- Troop TrainTime --%>
            <div class="col-md-2" style="border: solid 1px gray">
                <asp:Label ID="Label6" runat="server" Text="Train time(Minutes)"></asp:Label>
            </div>
        </div>
        <%-- TROOP 1 --%>
        <div class="row">
            <%-- TroopName --%>
            <div class="col-md-2">
                <asp:Label CssClass="LogginLabel" ID="lbl_T1Name" runat="server" Text="TroopName"></asp:Label>
            </div>
            <%-- TroopTextBox --%>
            <div class="col-md-2">
                <asp:TextBox CssClass="TroopTrainObject" ID="tb_T1" runat="server"></asp:TextBox>
            </div>
            <%-- Troop cost --%>
            <div class="col-md-3 TroopTrainObject"  style="border: solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T1Mineral" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="tbt_T1Monney" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T1Oli" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- Stats --%>
            <div class="col-md-3 TroopTrainObject" style="border: solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T1Attack" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T1Defence" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T1Speed" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- TrainTime --%>
                <div class="col-md-2 TroopTrainObject" style="border: solid 1px gray">
                <asp:Label ID="lbl_T1TrainTime" runat="server" Text="1"></asp:Label>
            </div>
        </div>
           <%-- TROOP 2 --%>
        <div class="row">
            <%-- TroopName --%>
            <div class="col-md-2">
                <asp:Label CssClass="LogginLabel" ID="Label3" runat="server" Text="TroopName"></asp:Label>
            </div>
            <%-- TroopTextBox --%>
            <div class="col-md-2">
                <asp:TextBox CssClass="TroopTrainObject" ID="TextBox1" runat="server"></asp:TextBox>
            </div>
            <%-- Troop cost --%>
            <div class="col-md-3 TroopTrainObject" style="border: solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T2Mineral" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T2Monney" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T2Oil" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- Stats --%>
            <div class="col-md-3 TroopTrainObject" style="border: solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T2Attack" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T2Defence" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="Speed" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- TrainTime --%>
                <div class="col-md-2 TroopTrainObject" style="border: solid 1px gray">
                <asp:Label ID="lbl_T2TrainTime" runat="server" Text="1"></asp:Label>
            </div>
        </div>
           <%-- TROOP 3 --%>
        <div class="row">
            <%-- TroopName --%>
            <div class="col-md-2">
                <asp:Label CssClass="LogginLabel" ID="Label12" runat="server" Text="TroopName"></asp:Label>
            </div>
            <%-- TroopTextBox --%>
            <div class="col-md-2">
                <asp:TextBox CssClass="TroopTrainObject" ID="TextBox2" runat="server"></asp:TextBox>
            </div>
            <%-- Troop cost --%>
            <div class="col-md-3 TroopTrainObject" style="border: solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:Label ID="Label13" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="Label14" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="Label15" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- Stats --%>
            <div class="col-md-3 TroopTrainObject" style="border: solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:Label ID="Label16" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="Label17" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="Label18" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- TrainTime --%>
                <div class="col-md-2 TroopTrainObject" style="border: solid 1px gray">
                <asp:Label ID="Label19" runat="server" Text="1 Minute"></asp:Label>
            </div>
        </div>
           <%-- TROOP 4 --%>
        <div class="row">
            <%-- TroopName --%>
            <div class="col-md-2">
                <asp:Label CssClass="LogginLabel" ID="Label20" runat="server" Text="TroopName"></asp:Label>
            </div>
            <%-- TroopTextBox --%>
            <div class="col-md-2">
                <asp:TextBox CssClass="TroopTrainObject" ID="TextBox3" runat="server"></asp:TextBox>
            </div>
            <%-- Troop cost --%>
            <div class="col-md-3 TroopTrainObject" style="border: solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:Label ID="Label21" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="Label22" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="Label23" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- Stats --%>
            <div class="col-md-3 TroopTrainObject" style="border: solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:Label ID="Label24" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="Label25" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="Label26" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- TrainTime --%>
                <div class="col-md-2 TroopTrainObject" style="border: solid 1px gray">
                <asp:Label ID="Label27" runat="server" Text="1 Minute"></asp:Label>
            </div>
        </div>
           <%-- TROOP 5 --%>
        <div class="row">
            <%-- TroopName --%>
            <div class="col-md-2">
                <asp:Label CssClass="LogginLabel" ID="Label28" runat="server" Text="TroopName"></asp:Label>
            </div>
            <%-- TroopTextBox --%>
            <div class="col-md-2">
                <asp:TextBox CssClass="TroopTrainObject" ID="TextBox4" runat="server"></asp:TextBox>
            </div>
            <%-- Troop cost --%>
            <div class="col-md-3 TroopTrainObject" style="border: solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:Label ID="Label29" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="Label30" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="Label31" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- Stats --%>
            <div class="col-md-3 TroopTrainObject" style="border: solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:Label ID="Label32" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="Label33" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="Label34" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- TrainTime --%>
                <div class="col-md-2 TroopTrainObject" style="border: solid 1px gray">
                <asp:Label ID="Label35" runat="server" Text="1 Minute"></asp:Label>
            </div>
        </div>
           <%-- TROOP 6 --%>
        <div class="row">
            <%-- TroopName --%>
            <div class="col-md-2">
                <asp:Label CssClass="LogginLabel" ID="Label36" runat="server" Text="TroopName"></asp:Label>
            </div>
            <%-- TroopTextBox --%>
            <div class="col-md-2">
                <asp:TextBox CssClass="TroopTrainObject" ID="TextBox5" runat="server"></asp:TextBox>
            </div>
            <%-- Troop cost --%>
            <div class="col-md-3 TroopTrainObject" style="border: solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:Label ID="Label37" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="Label38" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="Label39" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- Stats --%>
            <div class="col-md-3 TroopTrainObject" style="border: solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:Label ID="Label40" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="Label41" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="Label42" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- TrainTime --%>
                <div class="col-md-2 TroopTrainObject" style="border: solid 1px gray">
                <asp:Label ID="Label43" runat="server" Text="1 Minute"></asp:Label>
            </div>
        </div>
           <%-- TROOP 7 --%>
        <div class="row">
            <%-- TroopName --%>
            <div class="col-md-2">
                <asp:Label CssClass="LogginLabel" ID="Label44" runat="server" Text="TroopName"></asp:Label>
            </div>
            <%-- TroopTextBox --%>
            <div class="col-md-2">
                <asp:TextBox CssClass="TroopTrainObject" ID="TextBox6" runat="server"></asp:TextBox>
            </div>
            <%-- Troop cost --%>
            <div class="col-md-3 TroopTrainObject" style="border: solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:Label ID="Label45" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="Label46" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="Label47" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- Stats --%>
            <div class="col-md-3 TroopTrainObject" style="border: solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:Label ID="Label48" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="Label49" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="Label50" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- TrainTime --%>
                <div class="col-md-2 TroopTrainObject" style="border: solid 1px gray">
                <asp:Label ID="Label51" runat="server" Text="1 Minute"></asp:Label>
            </div>
        </div>
           <%-- TROOP 8 --%>
        <div class="row">
            <%-- TroopName --%>
            <div class="col-md-2">
                <asp:Label CssClass="LogginLabel" ID="Label52" runat="server" Text="TroopName"></asp:Label>
            </div>
            <%-- TroopTextBox --%>
            <div class="col-md-2">
                <asp:TextBox CssClass="TroopTrainObject" ID="TextBox7" runat="server"></asp:TextBox>
            </div>
            <%-- Troop cost --%>
            <div class="col-md-3 TroopTrainObject" style="border: solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:Label ID="Label53" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="Label54" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="Label55" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- Stats --%>
            <div class="col-md-3 TroopTrainObject" style="border: solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:Label ID="Label56" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="Label57" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="Label58" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- TrainTime --%>
                <div class="col-md-2 TroopTrainObject" style="border: solid 1px gray">
                <asp:Label ID="Label59" runat="server" Text="1 Minute"></asp:Label>
            </div>
        </div>
           <%-- TROOP 9 --%>
        <div class="row">
            <%-- TroopName --%>
            <div class="col-md-2">
                <asp:Label CssClass="LogginLabel" ID="Label60" runat="server" Text="TroopName"></asp:Label>
            </div>
            <%-- TroopTextBox --%>
            <div class="col-md-2">
                <asp:TextBox CssClass="TroopTrainObject" ID="TextBox8" runat="server"></asp:TextBox>
            </div>
            <%-- Troop cost --%>
            <div class="col-md-3 TroopTrainObject" style="border: solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:Label ID="Label61" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="Label62" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="Label63" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- Stats --%>
            <div class="col-md-3 TroopTrainObject" style="border: solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:Label ID="Label64" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="Label65" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="Label66" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- TrainTime --%>
                <div class="col-md-2 TroopTrainObject" style="border: solid 1px gray">
                <asp:Label ID="Label67" runat="server" Text="1 Minute"></asp:Label>
            </div>
        </div>
        <%-- Troops END --%>
    </div>
  

    <%-- END --%>

    <asp:Button ID="btn_TrainTroops" runat="server" Text="Train" OnClick="btn_TrainTroops_Click" />
</asp:Content>
