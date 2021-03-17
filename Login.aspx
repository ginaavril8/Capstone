<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Capstone.Login" %>



<%-------------------------------- Login Interface ------------------------------------%>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <img src="Images/memberloginpage.jpg" alt="" style="max-width:100%; height:auto;" />


    <p style="text-align:center; font-size: 56px; color:#FF6900; font-family:Sigmar One;">Member login</p>




        <div>
        <%-------------------------------- Username ------------------------------------%>
        <asp:Label ID="lblUsername" ForeColor="#FF6900" runat="server" Text="Username:"></asp:Label>
            <br />
        <asp:TextBox ID="txtUsername" runat="server" />
            <br />
        

        
        <%-------------------------------- Password ------------------------------------%>
        <asp:Label ID="lblPassword" ForeColor="#FF6900" runat="server" Text="Password:"></asp:Label>
            <br />
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
            <br />
        


    
        <%-------------------------------- Login button ------------------------------------%>
        <asp:Button ID="loginButton" BackColor="#FF6900" ForeColor="Black" runat="server" onClick="loginButton_Click" Text="Login" />
            <br />

        <asp:Label ID="lblFeedback" ForeColor="#FF6900" runat="server" Text="" />

            <br />
        <a href="Backend/Default.aspx">Admin login</a>
            <br />
 
        </div>




</asp:Content>
