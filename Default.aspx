<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Capstone.Homepage" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <img src="Images/homepageWings.jpg" alt="" style="max-width:100%; height:auto;" />

    <p style="text-align:center; font-size: 56px; color:#FF6900; font-family:Sigmar One;">Welcome to The Boneyard!</p>
    

    <p style="text-align:center; font-size: 24px; color:#FFE4C4; font-family:Roboto;">Proudly serving award winning wings with homemade artisan sauces in a fun, family friendly atmosphere!</p>

    <br />
    <br />


    <%--------------------------------- Img + Menu Link ------------------------------------%>
    <div class="homeDiv">

        <img src="Images/homepageMenu.jpg" alt=""  style="max-width:60%; height:auto; float:left;" />

        <a href="Menu" style="text-align:center; font-size: 24px; color:#FF6900; font-family:Sigmar One; float:right;">Menu</a>

    </div>
    

    <%--------------------------------- Img + Leaderboard Link ------------------------------------%>
    <div class="homeDiv">

        <a href="Leaderboard" style="text-align:center; clear:left; font-size: 24px; color:#FF6900; font-family:Sigmar One; float:left;">Leaderboard</a>

        <img src="Images/homepageLeaderboard.jpg" alt=""  style="max-width:60%; height:auto; float:right;" />

    </div>


    <%--------------------------------- Img + About Link ------------------------------------%>
    <div class="homeDiv">

        <img src="Images/homepageAbout.jpg" alt=""  style="max-width:60%; height:auto; float:left;" />

        <a href="About" style="text-align:center; font-size: 24px; color:#FF6900; font-family:Sigmar One; float:right;">About</a>

    </div>


</asp:Content>
