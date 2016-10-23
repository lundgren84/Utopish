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
                <asp:Label CssClass="LogginLabel" ID="lbl_T2Name" runat="server" Text="TroopName"></asp:Label>
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
                            <asp:Label ID="lbl_T2Speed" runat="server" Text="0"></asp:Label>
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
                <asp:Label CssClass="LogginLabel" ID="lbl_T3Name" runat="server" Text="TroopName"></asp:Label>
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
                            <asp:Label ID="lbl_T3Mineral" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T3Monney" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T3Oli" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- Stats --%>
            <div class="col-md-3 TroopTrainObject" style="border: solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T3Attack" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T3Defence" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T3Speed" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- TrainTime --%>
                <div class="col-md-2 TroopTrainObject" style="border: solid 1px gray">
                <asp:Label ID="lbl_T3TrainTime" runat="server" Text="1"></asp:Label>
            </div>
        </div>
           <%-- TROOP 4 --%>
        <div class="row">
            <%-- TroopName --%>
            <div class="col-md-2">
                <asp:Label CssClass="LogginLabel" ID="lbl_T4Name" runat="server" Text="TroopName"></asp:Label>
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
                            <asp:Label ID="lbl_T4Mineral" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T4Monney" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T4Oil" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- Stats --%>
            <div class="col-md-3 TroopTrainObject" style="border: solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T4Attack" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T4Defence" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T4Speed" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- TrainTime --%>
                <div class="col-md-2 TroopTrainObject" style="border: solid 1px gray">
                <asp:Label ID="lbl_T4TrainTime" runat="server" Text="1"></asp:Label>
            </div>
        </div>
           <%-- TROOP 5 --%>
        <div class="row">
            <%-- TroopName --%>
            <div class="col-md-2">
                <asp:Label CssClass="LogginLabel" ID="lbl_T5Name" runat="server" Text="TroopName"></asp:Label>
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
                            <asp:Label ID="lbl_T5Mineral" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T5Monney" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T5Oil" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- Stats --%>
            <div class="col-md-3 TroopTrainObject" style="border: solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T5Attack" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T5Defence" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T5Speed" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- TrainTime --%>
                <div class="col-md-2 TroopTrainObject" style="border: solid 1px gray">
                <asp:Label ID="lbl_T5TrainTime" runat="server" Text="1"></asp:Label>
            </div>
        </div>
           <%-- TROOP 6 --%>
        <div class="row">
            <%-- TroopName --%>
            <div class="col-md-2">
                <asp:Label CssClass="LogginLabel" ID="lbl_T6Name" runat="server" Text="TroopName"></asp:Label>
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
                            <asp:Label ID="lbl_T6Mineral" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T6Monney" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T6Oil" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- Stats --%>
            <div class="col-md-3 TroopTrainObject" style="border: solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T6Attack" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T6Defence" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T6Speed" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- TrainTime --%>
                <div class="col-md-2 TroopTrainObject" style="border: solid 1px gray">
                <asp:Label ID="lbl_T6TrainTime" runat="server" Text="1"></asp:Label>
            </div>
        </div>
           <%-- TROOP 7 --%>
        <div class="row">
            <%-- TroopName --%>
            <div class="col-md-2">
                <asp:Label CssClass="LogginLabel" ID="lbl_T7Name" runat="server" Text="TroopName"></asp:Label>
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
                            <asp:Label ID="lbl_T7Mineral" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T7Monney" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T7Oil" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- Stats --%>
            <div class="col-md-3 TroopTrainObject" style="border: solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T7Attack" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T7Defence" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T7Speed" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- TrainTime --%>
                <div class="col-md-2 TroopTrainObject" style="border: solid 1px gray">
                <asp:Label ID="lbl_T7TrainTime" runat="server" Text="1"></asp:Label>
            </div>
        </div>
           <%-- TROOP 8 --%>
        <div class="row">
            <%-- TroopName --%>
            <div class="col-md-2">
                <asp:Label CssClass="LogginLabel" ID="lbl_T8Name" runat="server" Text="TroopName"></asp:Label>
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
                            <asp:Label ID="lbl_T8Mineral" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T8Monney" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T8Oil" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- Stats --%>
            <div class="col-md-3 TroopTrainObject" style="border: solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T8Attack" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T8Defence" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T8Speed" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- TrainTime --%>
                <div class="col-md-2 TroopTrainObject" style="border: solid 1px gray">
                <asp:Label ID="lbl_T8TrainTime" runat="server" Text="1"></asp:Label>
            </div>
        </div>
           <%-- TROOP 9 --%>
        <div class="row">
            <%-- TroopName --%>
            <div class="col-md-2">
                <asp:Label CssClass="LogginLabel" ID="lbl_T9Name" runat="server" Text="TroopName"></asp:Label>
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
                            <asp:Label ID="lbl_T9Mineral" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_MonneyT9" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T9Oil" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- Stats --%>
            <div class="col-md-3 TroopTrainObject" style="border: solid 1px gray">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T9Attack" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T9Defence" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="lbl_T9Speed" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <%-- TrainTime --%>
                <div class="col-md-2 TroopTrainObject" style="border: solid 1px gray">
                <asp:Label ID="lbl_T9TrainTime" runat="server" Text="1"></asp:Label>
            </div>
        </div>
        <%-- Troops END --%>
    </div>
  

    <%-- END --%>

    <asp:Button ID="btn_TrainTroops" runat="server" Text="Train" OnClick="btn_TrainTroops_Click" />
</asp:Content>
