<%@ Page Title="Scanner" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="MainPage.aspx.cs" Inherits="Utopish_Space.User.MainPage" %>

<asp:Content ID="BodyContent"  ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="text-align: center;"><%: Title %>.</h2>
    <div class="container-fuid">
        <div class="row">
             <div class="col-xs-3"></div>
            <div class="col-xs-6">
                <div  class="container-fluid">
                    <%-- Row1 --%>
                    <div class="row">
                        <div  class="col-xs-12">
                            <a href="#" class="ScannerImg_A"> <span "><img src="../Graphic/StarSky/space_bk.png"  class="ScannerImg" /></span> </a>     
                            <a href="#" class="ScannerImg_A"> <span "><img src="../Graphic/Plantes/planet_19.png" class="ScannerImg"/> </span> </a>     
                            <a href="#" class="ScannerImg_A"> <span "><img src="../Graphic/StarSky/space_bk.png"  class="ScannerImg"/></span> </a>     
                            <a href="#" class="ScannerImg_A"> <span "><img src="../Graphic/StarSky/space_ft.png"  class="ScannerImg"/></span> </a>    
                            <a href="#" class="ScannerImg_A"> <span "><img src="../Graphic/Plantes/planet_30.png" class="ScannerImg"/> </span> </a>     
                    </div>
                    </div>
                        <%-- Row1 --%>
                    <div class="row">
                        <div  class="col-xs-12">
                            <a href="#" class="ScannerImg_A"> <span "><img src="../Graphic/StarSky/space_bk.png" class="ScannerImg"/></span> </a>     
                            <a href="#" class="ScannerImg_A"> <span "><img src="../Graphic/StarSky/space_bk.png" class="ScannerImg"/></span> </a>     
                            <a href="#" class="ScannerImg_A"> <span "><img src="../Graphic/StarSky/space_ft.png" class="ScannerImg"/></span> </a>    
                            <a href="#" class="ScannerImg_A"> <span "><img src="../Graphic/StarSky/space_bk.png" class="ScannerImg"/></span> </a>     
                            <a href="#" class="ScannerImg_A"> <span "><img src="../Graphic/StarSky/space_ft.png" class="ScannerImg"/></span> </a>   
                    </div>
                    </div>
                        <%-- Row1 --%>
                    <div class="row">
                        <div  class="col-xs-12">
                             <a href="#" class="ScannerImg_A"> <span "><img src="../Graphic/StarSky/space_ft.png" class="ScannerImg"/></span> </a>     
                             <a href="#" class="ScannerImg_A"> <span "><img src="../Graphic/Plantes/planet_30.png" class="ScannerImg"/> </span> </a>     
                             <a href="#" class="ScannerImg_A"> <span "><img src="../Graphic/StarSky/space_bk.png"  class="ScannerImg"/></span> </a>     
                             <a href="#" class="ScannerImg_A"> <span "><img src="../Graphic/StarSky/space_ft.png" class="ScannerImg"/></span> </a>     
                             <a href="#" class="ScannerImg_A"> <span "><img src="../Graphic/StarSky/space_bk.png"  class="ScannerImg"/></span> </a>    
                    </div>
                    </div>
                        <%-- Row1 --%>
                    <div class="row">
                        <div  class="col-xs-12">
                            <a href="#" class="ScannerImg_A"> <span "><img src="../Graphic/StarSky/space_bk.png" class="ScannerImg"/></span> </a>     
                            <a href="#" class="ScannerImg_A"> <span "><img src="../Graphic/StarSky/space_bk.png" class="ScannerImg"/></span> </a>     
                            <a href="#" class="ScannerImg_A"> <span "><img src="../Graphic/StarSky/space_ft.png" class="ScannerImg"/></span> </a>     
                            <a href="#" class="ScannerImg_A"> <span "><img src="../Graphic/StarSky/space_bk.png" class="ScannerImg"/></span> </a>     
                            <a href="#" class="ScannerImg_A"> <span "><img src="../Graphic/Plantes/planet_19.png" class="ScannerImg"/> </span> </a>     
                    </div>
                    </div>
                 
                </div>         
          </div>
              <div class="col-xs-3 ScannerPlanetInfo">
                  <div class="container">
                      <div class="row">
                          <div class="col-xs-12">
                              <h3><asp:Label ID="Label1" runat="server" Text="Info thats shows after  CLick"></asp:Label></h3>
                          </div>
                                 <div class="col-xs-12">
                              <h3><asp:Label ID="Label2" runat="server" Text="Info"></asp:Label></h3>
                          </div>
                                 <div class="col-xs-12">
                              <h3><asp:Label ID="Label3" runat="server" Text="Info"></asp:Label></h3>
                          </div>
                                 <div class="col-xs-12">
                              <h3><asp:Label ID="Label4" runat="server" Text="Info"></asp:Label></h3>
                          </div>
                                  <div class="col-xs-12">
                              <h3><asp:Label ID="Label5" runat="server" Text="Info"></asp:Label></h3>
                          </div>
                                 <div class="col-xs-12">
                              <h3><asp:Label ID="Label6" runat="server" Text="Info"></asp:Label></h3>
                          </div>
                      </div>

                  </div>
              </div>
        </div>
   </div>



</asp:Content>
