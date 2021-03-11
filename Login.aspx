<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Capstone.Login" %>



<%-------------------------------- Login Interface ------------------------------------%>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <img src="Images/memberloginpage.jpg" alt="" style="max-width:100%; height:auto;" />


    <p style="text-align:center; font-size: 56px; color:#FF6900; font-family:Sigmar One;">Member login</p>

    <table>


        <tr>
        <%-------------------------------- Username ------------------------------------%>
        <td style="color:#FF6900;">Username:</td>
        <td><asp:TextBox ID="txtUsername" runat="server" /></td>
        </tr>

        <tr>
        <%-------------------------------- Password ------------------------------------%>
        <td style="color:#FF6900;">Password:</td>
        <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password" /></td>
        </tr>

    </table>

    
        <%-------------------------------- Login button ------------------------------------%>
        <asp:Button ID="loginButton" BackColor="#FF6900" ForeColor="Black" runat="server" onClick="loginButton_Click" Text="Login" />

        <asp:Label ID="lblFeedback" ForeColor="#FF6900" runat="server" Text="" />
 




</asp:Content>
