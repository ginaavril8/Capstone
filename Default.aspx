<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Capstone.Homepage" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <img src="Images/homepageWings.jpg" alt="" style="max-width:100%; height:auto;" />
    <p style="text-align:center; font-size: 56px; color:darkorange;">Welcome to The Boneyard!</p>
    
    <p style="text-align:center; font-size: 24px; color:darkorange;">Proudly serving award winning wings with homemade artisan sauces in a fun, family friendly atmosphere!</p>

        <br />
    <br />

    <div class="homeDiv">
        <img src="Images/homepageMenu.jpg" alt=""  style="max-width:60%; height:auto; float:left;" />
        <a href="~/Menu.aspx" style="text-align:center; font-size: 36px; color:darkorange; float:right;">View the menu</a>
    </div>
    <div class="homeDiv">
        <a href="~/Leaderboard.aspx" style="text-align:center; clear:left; font-size: 36px; color:darkorange; float:left;">Check the leaderboard</a>
        <img src="Images/homepageLeaderboard.jpg" alt=""  style="max-width:60%; height:auto; float:right;" />
    </div>
    <div class="homeDiv">
        <img src="Images/homepageAbout.jpg" alt=""  style="max-width:60%; height:auto; float:left;" />
        <a href="~/Menu.aspx" style="text-align:center; font-size: 36px; color:darkorange; float:right;">More about us</a>
    </div>


</asp:Content>
