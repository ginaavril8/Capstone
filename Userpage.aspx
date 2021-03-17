<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Userpage.aspx.cs" Inherits="Capstone.Leaderboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <%------------------------------ Userpage Img + Text -------------------------------------%>
        <img src="Images/leaderboardpage.jpg" alt="" style="max-width:100%; height:auto;" />

        <p style="text-align:center; font-size: 56px; color:#FF6900; font-family:Sigmar One;">User information</p>


        <%-------------------------------- Display data below ----------------------------------%>

    <br />

    <asp:Label ID="lblSessionFname" runat="server"></asp:Label>




</asp:Content>
