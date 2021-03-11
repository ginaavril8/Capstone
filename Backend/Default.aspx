<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Capstone.Backend.Default" %>




<%-- Login Interface--%>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h3 style="color:#FF6900"><strong>Username:</strong></h3>
        <asp:TextBox ID="txtUsername" runat="server" />

        <br />
        <br />

        <h3 style="color:#FF6900"><strong>Password:</strong></h3>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"/>

        <br />
        <br />

        <asp:Button ID="loginButton" runat="server" BackColor="#FF6900" ForeColor="Black" onClick="loginButton_Click" Text="Login" />

        <br />
        <br />

        <asp:Label ID="lblFeedback" ForeColor="#FF6900" runat="server" Text="" />
    </div>
</asp:Content>
