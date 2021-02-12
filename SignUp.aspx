<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="Capstone.SignUp" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <!-- ------------------------------------------------------ NEEDS TO BE CONNECTED TO DATABASE ---------------------------------------------->
        <div>
        <h3><strong>First Name:</strong></h3>
        <asp:TextBox ID="txtFirstName" runat="server" />

        <br />
        <br />

        <h3><strong>Last Name:</strong></h3>
        <asp:TextBox ID="txtLastName" runat="server"/>

        <br />
        <br />

        <h3><strong>Username:</strong></h3>
        <asp:TextBox ID="txtUserName" runat="server"/>

        <br />
        <br />

        <br />
        <h3><strong>Email:</strong></h3>
        <asp:TextBox ID="txtEmail1" runat="server"/>

        <br />
        <h3><strong>Confirm Email:</strong></h3>
        <asp:TextBox ID="txtEmail2" runat="server" />

        <br />
        <br />

        <h3><strong>Password:</strong></h3>
        <asp:TextBox ID="txtUserPassword1" runat="server" TextMode="Password"/>

        <br />

        <h3><strong>Confirm Password:</strong></h3>
        <asp:TextBox ID="txtUserPassword2" runat="server" TextMode="Password"/>

        <br />
        <br />

        <asp:Button ID="signUpButton" runat="server" onClick="signUpButton_Click" Text="Sign Up" />

        <br />
        <br />

        <asp:Label ID="lblFeedback" runat="server" Text="" />
    </div>
</asp:Content>
