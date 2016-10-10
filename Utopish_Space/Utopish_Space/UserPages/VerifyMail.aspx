<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerifyMail.aspx.cs" Inherits="Utopish_Space.UserPages.VerifyMail" %>

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
<body style="overflow: hidden; margin: 0">
    <div class="overlay" id="main">
        <form id="form2" runat="server">
           <%-- <asp:Label ID="LabelGameName" runat="server" CssClass="LogginLabel" Text="Game name" Font-Names="Consolas" ForeColor="White"></asp:Label>--%>
         <%--   <asp:Button ID="ButtonChangeLoggin" CssClass="logginButton" runat="server" Font-Names="Consolas" Font-Size="Medium" Height="50px" Width="150px" Text="Register"  OnClick="Button3_Click" CausesValidation="false"/>--%>
            <br />
            <div id="logginPlanet1">
                <img src="../Graphic/Plantes/planet_21.png" style="height: 496px; width: 495px" />
            </div>
            <asp:Panel ID="PanelVerify"  runat="server">
               <table>
                   <tr>
                       <td>
                           <asp:Label ID="Label89" runat="server" CssClass="LogginLabel" Text="ActivationCode" ForeColor="White"></asp:Label>
                       </td>
                   </tr>
                   <tr>
                       <td>
                           <asp:TextBox ID="TextBox_ActivationCode" Font-Names="Consolas"  Height="40px" CssClass="LogginLabel" runat="server"></asp:TextBox>
                       </td>
                   </tr>
                   <tr>
                       <td>
                           <asp:Button ID="Button_Unlock" CssClass="logginButton" Font-Names="Consolas" runat="server" OnClick="Button_Unlock_Click"  Font-Size="Medium" Height="50px" Width="150px" Text="Verify" />
                         
                       </td>
                   </tr>
               </table>

            </asp:Panel>
            <%-- LoginPanel--%>
           <%-- <asp:Panel ID="PanelLoggin" runat="server">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" CssClass="LogginLabel" Text="User name" ForeColor="White"></asp:Label><br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="tb_UserEmail" CssClass="LogginLabel" runat="server" Font-Names="Consolas" Height="40px" OnTextChanged="tb_Username_TextChanged" ControlToValidate="tb_Username"></asp:TextBox>
                        </td>
                        <td>                   
                             
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
                            <asp:TextBox ID="tb_Password" CssClass="LogginLabel" runat="server" Height="40px" TextMode="Password" Font-Names="Consolas" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                        </td>
                        <td>
                            
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Required" ControlToValidate="tb_Password" ForeColor="Red"></asp:RequiredFieldValidator>                 
                          </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="ButtonLogin" CssClass="logginButton" runat="server" Text="Loggin" Font-Names="Consolas" Font-Size="Medium" Height="50px" Width="150px" OnClick="ButtonLogin_Click" />
                        </td>

                    </tr>
                </table>


            </asp:Panel>--%>
         
        </form>
        <div id="logginPlanet2">
            <img src="../Graphic/Plantes/planet_18.png" />

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

