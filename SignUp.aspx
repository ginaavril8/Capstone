<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="Capstone.SignUp" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 

<table>


<%-- First Name --%>
    <tr>
        <td>First Name:</td>
        <td><asp:TextBox ID="txtFirstName" runat="server" /></td>
    </tr>
             
                
<%-- Last Name --%>
    <tr>
        <td>Last Name:</td>
        <td><asp:TextBox ID="txtLastName" runat="server" /></td>
    </tr>

<%-- Username --%>
    <tr>
        <td>Username:</td>
        <td><asp:TextBox ID="txtUserName" runat="server" /></td>
    </tr>
        

<%-- Email --%>
    <tr>
        <td>Email:</td>
        <td><asp:TextBox ID="txtEmail" runat="server"  /></td>
    </tr>


<%-- Password --%>
    <tr>
        <td>Password:</td>
        <td><asp:TextBox ID="txtUserPassword" TextMode="Password" runat="server" /></td>
    </tr>

</table>


    <%-- Sign up / Add to database --%>  

        <asp:Button ID="signUpButton" runat="server" onClick="signUpButton_Click" Text="Sign Up" />
    <br />
    <br />

        <asp:Label ID="lblFeedback" runat="server" Text="" style="text-align:center;" />
 
</asp:Content>
