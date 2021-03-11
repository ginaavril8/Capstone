<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Capstone.Login" %>



<%-- Login Interface--%>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <img src="Images/memberloginpage.jpg" alt="" style="max-width:100%; height:auto;" />
    <p style="text-align:center; font-size: 56px; color:#FF6900; font-family:Sigmar One;">Member login</p>


    <div>
        <h3 style="color:#FF6900"><strong>Username:</strong></h3>
        <asp:TextBox ID="txtUsername" runat="server" />

        <br />
        <br />

        <h3 style="color:#FF6900"><strong>Password:</strong></h3>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"/>

        <br />
        <br />

        <asp:Button ID="loginButton" BackColor="#FF6900" ForeColor="Black" runat="server" onClick="loginButton_Click" Text="Login" />

        <br />
        <br />

        <asp:Label ID="lblFeedback" ForeColor="#FF6900" runat="server" Text="" />
    </div>

</asp:Content>
