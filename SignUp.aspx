﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="Capstone.SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 

    <%--------------------------------- Img + Sign Up Text ------------------------------------%>
    <img src="Images/signuppage.jpg" alt="" style="max-width:100%; height:auto;" />

    <p style="text-align:center; font-size: 56px; color:#FF6900; font-family:Sigmar One;">Sign Up</p>
    <p style="text-align:left; font-size: 24px; color:#FFE4C4; font-family:Roboto;">Sign up for our mailing list to receive news and special offers.</p>

<table>


<%--------------------------------- First Name ------------------------------------%>
    <tr>
        <td style="color:#FF6900;">First Name:</td>
        <td><asp:TextBox ID="txtFirstName" runat="server" /></td>
    </tr>
             
                
<%--------------------------------- Last Name ------------------------------------%>
    <tr>
        <td style="color:#FF6900;">Last Name:</td>
        <td><asp:TextBox ID="txtLastName" runat="server" /></td>
    </tr>

<%-------------------------------- Username ------------------------------------%>
    <tr>
        <td style="color:#FF6900;">Username:</td>
        <td><asp:TextBox ID="txtUserName" runat="server" /></td>
    </tr>
        

<%-------------------------------- Email ------------------------------------%>
    <tr>
        <td style="color:#FF6900;">Email:</td>
        <td><asp:TextBox ID="txtEmail" runat="server"  /></td>
       
    </tr>


<%-------------------------------- Password ------------------------------------%>
    <tr>
        <td style="color:#FF6900;">Password:</td>
        <td><asp:TextBox ID="txtUserPassword" TextMode="Password" runat="server" /></td>
    </tr>

</table>


    <%-------------------------------- Sign up / Add to database ------------------------------------%> 
    <br />
        <asp:Button ID="signUpButton" BackColor="#FF6900" ForeColor="Black" runat="server" onClick="signUpButton_Click" Text="Sign Up" />
    <br />
    <br />

     <%-------------------------------- Feedback ------------------------------------%> 
        <asp:Label ID="lblFeedback" runat="server" Text="" style="text-align:center; color:#FF6900;" />
 
</asp:Content>
