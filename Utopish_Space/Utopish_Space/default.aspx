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
                <asp:Label ID="Label3" runat="server" class="LogginLabel"  Text="Game name" Font-Names="Consolas" ForeColor="White"></asp:Label><br />           
            <div id="logginPlanet1">
                <img src="Graphic/Plantes/planet_21.png"   style="height: 496px; width: 495px" />
            </div>
            <asp:Panel ID="PanelLoggin" runat="server">
                <asp:Label ID="Label1" runat="server" class="LogginLabel" Text="User name" ForeColor="White"></asp:Label><br />
                <asp:TextBox ID="tb_Username" class="LogginLabel" runat="server" Font-Names="Consolas" Height="40px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="tb_Username" ErrorMessage="Required" Font-Names="Consolas" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                <br />
                <asp:Label ID="Label2" class="LogginLabel" runat="server" Text="Password" ForeColor="White"></asp:Label><br />
                <asp:TextBox ID="tb_Password" class="LogginLabel" runat="server" Height="40px" TextMode="Password" Font-Names="Consolas" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="tb_Password" ErrorMessage="Required" Font-Names="Consolas" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                <br />
                <asp:Button ID="Button1" CssClass="logginButton" runat="server" Text="Loggin" Font-Names="Consolas" Font-Size="Medium" Height="50px" Width="150px" />            
            </asp:Panel>
                <%--RegistrationPanel--%>
               <asp:Panel ID="PanelRegistration" runat="server">
                <asp:Label ID="Label4" runat="server" class="LogginLabel" Text="User name" ForeColor="White"></asp:Label><br />
                <asp:TextBox ID="tb_RegUserName" class="LogginLabel" runat="server" Font-Names="Consolas" Height="40px" Width="300px"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Required" ControlToValidate="tb_RegUserName" Font-Names="Consolas" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                   <br />
                   <asp:Label ID="Label7" runat="server" class="LogginLabel" Text="Email" ForeColor="White"></asp:Label><br />
                <asp:TextBox ID="tb_RegEmail" class="LogginLabel" runat="server" Font-Names="Consolas" Height="40px" Width="300px"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Required" ControlToValidate="tb_RegEmail" Font-Names="Consolas" ForeColor="#CC0000" Display="Dynamic"></asp:RequiredFieldValidator>
                   <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tb_RegEmail" ErrorMessage="You must enter a valid E-Mail" Font-Names="Consolas" ForeColor="#CC0000" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                   <br />
                <asp:Label ID="Label5" class="LogginLabel" runat="server" Text="Password" ForeColor="White"></asp:Label><br />
                <asp:TextBox ID="tb_RegPassword" class="LogginLabel" runat="server" Height="40px" TextMode="Password" Font-Names="Consolas" OnTextChanged="TextBox2_TextChanged" Width="300px"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Required" ControlToValidate="tb_RegPassword" Font-Names="Consolas" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                   <br />
                    <asp:Label ID="Label8" runat="server" class="LogginLabel" ForeColor="White" Text="Repeat Password"></asp:Label>
                   <br />
                   <asp:TextBox ID="tb_RegRepeatPassword" runat="server" class="LogginLabel" Font-Names="Consolas" Height="40px" OnTextChanged="TextBox2_TextChanged" TextMode="Password" Width="300px"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="tb_RegRepeatPassword" Display="Dynamic" ErrorMessage="Required" Font-Names="Consolas" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                   <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="tb_RegPassword" ControlToValidate="tb_RegRepeatPassword" ErrorMessage="Both password fields must be same" Font-Names="Consolas" ForeColor="#CC0000" Display="Dynamic"></asp:CompareValidator>
                   <br />  
                <asp:Button ID="ButtonRegister" CssClass="logginButton" runat="server" Text="Register" Font-Names="Consolas" Font-Size="Medium" Height="50px" Width="150px" OnClick="ButtonRegister_Click" />            
                   <input id="Reset1" type="reset" value="reset" />
            </asp:Panel>

            <div id="logginPlanet2">
                <img src="Graphic/Plantes/planet_18.png" />
            </div>
        </form>
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
