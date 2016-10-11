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
            <asp:Button ID="ButtonChangeLoggin" CssClass="logginButton" runat="server" Font-Names="Consolas" Font-Size="Medium" Height="50px" Width="150px" Text="Register"  OnClick="ButtonChangeLogin_Click" CausesValidation="false"/>
            <br />
            <div id="logginPlanet1">
                <img src="Graphic/Plantes/planet_21.png" style="height: 496px; width: 495px" />
            </div>
            <%-- LoginPanel--%>
            <asp:Panel ID="PanelLoggin" CssClass="StartPanel" runat="server">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" CssClass="LogginLabel" Text="User name" ForeColor="White"></asp:Label><br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="tb_UserEmail" CssClass="LogginLabel" runat="server" Font-Names="Consolas" Height="40px" ControlToValidate="tb_Username"></asp:TextBox>
                        </td>
                        <td>                   
                                 <%-- Validate login Username --%>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Required" ControlToValidate="tb_UserEmail" ForeColor="Red"></asp:RequiredFieldValidator>                
                          </td>
                    </tr>
                
                    <tr>
                        <td>
                            <asp:Label ID="Label2" CssClass="LogginLabel" runat="server" Text="Password" ForeColor="White"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="tb_Password" CssClass="LogginLabel" runat="server" Height="40px" TextMode="Password" Font-Names="Consolas"></asp:TextBox>
                        </td>
                        <td>
                               <%-- Validate login Password --%>
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Required" ControlToValidate="tb_Password" ForeColor="Red"></asp:RequiredFieldValidator>                 
                          </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="ButtonLogin" CssClass="logginButton" runat="server" Text="Loggin" Font-Names="Consolas" Font-Size="Medium" Height="50px" Width="150px" OnClick="ButtonLogin_Click" />
                        </td>

                    </tr>
                </table>


            </asp:Panel>
            <%--RegistrationPanel--%>
            <asp:Panel ID="PanelRegistration" CssClass="StartPanel" runat="server" Visible="False">
                <table>  
                     <tr>
                        <td>
                            <asp:Label ID="Label_EMailInUse" runat="server" CssClass="LogginLabel" Text="" ForeColor="Red"></asp:Label><br />
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
                            <%-- Validate Registration email --%>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Required" ControlToValidate="tb_RegEmail" ForeColor="Red"></asp:RequiredFieldValidator>                                    
                            <br />
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Not valid email" ForeColor="Red" ControlToValidate="tb_RegEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                             </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label5" CssClass="LogginLabel" runat="server" Text="Password" ForeColor="White"></asp:Label><br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="tb_RegPassword" CssClass="LogginLabel" runat="server" Height="40px" TextMode="Password" Font-Names="Consolas"  Width="300px"></asp:TextBox>
                        </td>
                        <td>
                            <%-- Validate Registration Password --%>
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="tb_RegPassword" ForeColor="Red" Text="Required"></asp:RequiredFieldValidator>            
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label8" runat="server" CssClass="LogginLabel" ForeColor="White" Text="Repeat Password"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="tb_RegRepeatPassword" runat="server" CssClass="LogginLabel" Font-Names="Consolas" Height="40px"  TextMode="Password" Width="300px"></asp:TextBox>
                        </td>
                        <td>
                            <%-- Validate Registration password repeat --%>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="tb_RegRepeatPassword" Text="Required" ForeColor="Red"></asp:RequiredFieldValidator>  
                            <br />
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="tb_RegRepeatPassword" ErrorMessage="Not equal passwords!" ForeColor="Red" ControlToCompare="tb_RegPassword"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <%-- Math Label --%>
                            <asp:Label ID="Label_Math" CssClass="LogginLabel" ForeColor="White" runat="server" Text="2+2 ="></asp:Label>
                            <asp:Label ID="Label_MathError" CssClass="LogginLabel" ForeColor="Red" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <%-- Math Awnser --%>
                              <asp:TextBox ID="TextBox_MathAwnser" placeholder="Im not a robot" Font-Names="Consolas" Height="40px" Width="300px" CssClass="LogginLabel" runat="server"></asp:TextBox>
                        </td>                  
                    </tr>
                    <tr>
                        <td>
                            <%-- Game rules --%>
                            <asp:Label ID="Label6" Font-Names="Consolas" ForeColor="White" runat="server" Text="I Accept all"></asp:Label>
                            <asp:HyperLink Target="_blank" NavigateUrl="~/UserPages/GameRules.aspx" ID="HyperLink1" runat="server">Game Rules</asp:HyperLink>
                            <asp:CheckBox ID="CheckBox_GameRules" runat="server" />   
                             <asp:Label ID="Label_GameRuleError" CssClass="LogginLabel" ForeColor="Red" runat="server" Text=""></asp:Label>        
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="ButtonRegister" CssClass="logginButton" runat="server" Text="Register" Font-Names="Consolas" Font-Size="Medium" Height="50px" Width="150px" OnClick="ButtonRegister_Click" />
                        </td>
                    </tr>
                </table>

            </asp:Panel>
            <%-- Registration compleated --%>
            <asp:Panel ID="Panel_RegCompleated" CssClass="StartPanel" runat="server" Visible="False">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="You Account is created!" CssClass="LogginLabel" ForeColor="White"></asp:Label>
                        </td>
                    </tr>
                      <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="A activation code is sended to you mail!" CssClass="LogginLabel" ForeColor="White"></asp:Label>
                        </td>
                    </tr>                 
                </table>

            </asp:Panel>
            <%-- END --%>
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
