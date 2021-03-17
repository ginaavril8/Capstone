<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Capstone.Homepage" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <img src="Images/homepageWings.jpg" alt="" style="max-width:100%; height:auto;" />

    <p style="text-align:center; font-size: 56px; color:#FF6900; font-family:Sigmar One;">Welcome to The Boneyard!</p>
    

    <p style="text-align:center; font-size: 24px; color:#FFE4C4; font-family:Roboto;">Proudly serving award winning wings with homemade artisan sauces in a fun, family friendly atmosphere!</p>

    <br />
    <br />


    <%--------------------------------- Img + Menu Link ------------------------------------%>
    <div class="homeDiv">



        <a href="Menu"><img src="Images/menuLink.png" alt="Menu" style="max-width:100%; height:auto; float:left;" /></a>

    </div>
    

    <%--------------------------------- Img + About Link ------------------------------------%>
    <div class="homeDiv">

        <a href="About"><img src="Images/aboutLink.png" alt="About" style="max-width:100%; height:auto; float:left;" /></a>

    </div>


    <%--------------------------------- Img + About Link ------------------------------------%>
    <div class="homeDiv">

        <a href="Contact"><img src="Images/contactLink.png" alt="Contact" style="max-width:100%; height:auto; float:left;" /></a>

    </div>


</asp:Content>
