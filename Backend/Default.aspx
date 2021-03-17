<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Capstone.Backend.Default" %>




<%----------------------------------------- Login Interface ----------------------------------%>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
    <p style="text-align:center; font-size: 56px; color:#FF6900; font-family:Sigmar One;">Admin login</p>

    <table>


        <tr>
        <%-------------------------------- Username ------------------------------------%>
        <td style="color:#FF6900;">Username:</td>
        <td><asp:TextBox ID="txtUsername" runat="server" /><br /><br /></td>
             
        </tr>

        <tr>
        <%-------------------------------- Password ------------------------------------%>
        <td style="color:#FF6900;">Password:</td> 
        <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password"/><br /></td>
        </tr>

    </table>

        <%----------------------------------------- Login Button ------------------------------------%>
        <asp:Button ID="loginButton" runat="server" BackColor="#FF6900" ForeColor="Black" onClick="loginButton_Click" Text="Login" />

        <br />
        <br />

        <asp:Label ID="lblFeedback" ForeColor="#FF6900" runat="server" Text="" />
  
</asp:Content>
