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
            <asp:Label ID="LabelGameName" runat="server" CssClass="LogginLabel" Text="Game name" Font-Names="Consolas" ForeColor="White"></asp:Label>
            <asp:Button ID="ButtonChangeLoggin" CssClass="logginButton" runat="server" Font-Names="Consolas" Font-Size="Medium" Height="50px" Width="150px" Text="Register" OnClick="Button3_Click" />
            <br />
            <div id="logginPlanet1">
                <img src="Graphic/Plantes/planet_21.png" style="height: 496px; width: 495px" />
            </div>
            <%-- LoginPanel--%>
            <asp:Panel ID="PanelLoggin" runat="server">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" CssClass="LogginLabel" Text="User name" ForeColor="White"></asp:Label><br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="tb_Username" CssClass="LogginLabel" runat="server" Font-Names="Consolas" Height="40px"></asp:TextBox>
                        </td>
                        <td>
                            <%--     <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="tb_Username" ErrorMessage="Required" Font-Names="Consolas" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                            --%> </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" CssClass="LogginLabel" runat="server" Text="Password" ForeColor="White"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="tb_Password" CssClass="LogginLabel" runat="server" Height="40px" TextMode="Password" Font-Names="Consolas" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                        </td>
                        <td>
                            <%--       <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="tb_Password" ErrorMessage="Required" Font-Names="Consolas" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                            --%>   </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button1" CssClass="logginButton" runat="server" Text="Loggin" Font-Names="Consolas" Font-Size="Medium" Height="50px" Width="150px" />

                        </td>

                    </tr>
                </table>


            </asp:Panel>
            <%--RegistrationPanel--%>
            <asp:Panel ID="PanelRegistration" runat="server" Visible="False">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" CssClass="LogginLabel" Text="User name" ForeColor="White"></asp:Label><br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="tb_RegUserName" CssClass="LogginLabel" runat="server" Font-Names="Consolas" Height="40px" Width="300px" ></asp:TextBox>
                        </td>
                        <td>
                          <asp:Label ID="Label_ValidRegUsername" CssClass="ValidatorLabel" runat="server" Text=""></asp:Label>                 
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label7" runat="server" CssClass="LogginLabel" Text="Email" ForeColor="White"></asp:Label><br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="tb_RegEmail" CssClass="LogginLabel" runat="server" Font-Names="Consolas" Height="40px" Width="300px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="Label_ValidRegEmail" CssClass="ValidatorLabel" runat="server" Text=""></asp:Label>                 
                            --%>             
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label5" CssClass="LogginLabel" runat="server" Text="Password" ForeColor="White"></asp:Label><br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="tb_RegPassword" CssClass="LogginLabel" runat="server" Height="40px" TextMode="Password" Font-Names="Consolas" OnTextChanged="TextBox2_TextChanged" Width="300px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="Label_Valid_RegPassword" CssClass="ValidatorLabel" runat="server" Text=""></asp:Label>          
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label8" runat="server" CssClass="LogginLabel" ForeColor="White" Text="Repeat Password"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="tb_RegRepeatPassword" runat="server" CssClass="LogginLabel" Font-Names="Consolas" Height="40px" OnTextChanged="TextBox2_TextChanged" TextMode="Password" Width="300px"></asp:TextBox>
                        </td>
                        <td>
                          <asp:Label ID="Label_Valid_RegRePassword" CssClass="ValidatorLabel" runat="server" Text=""></asp:Label>               
                            --%>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="ButtonRegister" CssClass="logginButton" runat="server" Text="Register" Font-Names="Consolas" Font-Size="Medium" Height="50px" Width="150px" OnClick="ButtonRegister_Click" />
                        </td>
                    </tr>
                </table>

            </asp:Panel>
        </form>
        <div id="logginPlanet2">
            <img src="Graphic/Plantes/planet_18.png" />

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
