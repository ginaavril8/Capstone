<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Capstone.Login" %>



<%-- Login Interface--%>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h3><strong>Username:</strong></h3>
        <asp:TextBox ID="txtUsername" runat="server" />

        <br />
        <br />

        <h3><strong>Password:</strong></h3>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"/>

        <br />
        <br />

        <asp:Button ID="loginButton" runat="server" onClick="loginButton_Click" Text="Login" />

        <br />
        <br />

        <asp:Label ID="lblFeedback" runat="server" Text="" />
    </div>

</asp:Content>
