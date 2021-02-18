<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Capstone.Contact" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    
<table>


<%-- First Name --%>
    <tr> 
        <td><asp:TextBox ID="txtContactName" runat="server" Text="Name" Width="400px" /></td>
    </tr>
             
                
<%-- Email --%>
    <tr> 
        <td><asp:TextBox ID="txtContactEmail" runat="server" Text="Email" Width="400px" /></td>
    </tr>

<%-- Comment --%>
    <tr> 
        <td><asp:TextBox ID="txtContactMessage" runat="server" TextMode="MultiLine" Width="400px" Height="200px" Text="Comments" /></td>
    </tr>
        

</table>

    <%-- Submit comment --%>  

    <asp:Button ID="btnContact" runat="server" text="Contact" OnClick="btnContact_Click" />
    <asp:Label ID="lblFeedback" runat="server" />

</asp:Content>
