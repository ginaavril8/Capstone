<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ContactUsManager.aspx.cs" Inherits="Capstone.Backend.ContactUsManager" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
    <%------------------------------ Return to Control Panel ---------------------------%>
    <a href="~/Backend/ControlPanel.aspx" runat="server">Return to Control Panel</a><br />
     

        <%------------------------------ Wing Management Table ---------------------------%>
    <table>

    <%-- Contact ID--%>
    <tr>
        <td>Contact ID</td>
        <td><asp:Label ID="lblContactID" runat="server"  /></td>
    </tr>

    <%-- Contact Name --%>
     <tr>
         <td>Customer Name: </td>
         <td><asp:Label ID="lblContactName" runat="server" /></td>
     </tr>

        <%-- Email --%>
    <tr>
        <td>Email: </td>
        <td><asp:Label ID="lblContactEmail" runat="server" /></td>
    </tr>


    <%-- Message --%>
    <tr>
        <td>Comment: </td>
        <td><asp:Label ID="lblContactMessage" runat="server" /></td>
    </tr>

   <%-- Admin Response --%>
     <tr>
        <td>Response</td>
        <td><asp:Textbox ID="txtContactStatus" runat="server" MaxLength="200" /></td>
    </tr>

        
    </table>

    <%-- Add note to a contact message --%>

    <asp:Button ID="btnUpdateContactMsg" runat="server" Text="Update" OnClick="btnUpdateContactMsg_Click" />

   <%-- Cancle Button --%>
            <br />
    <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />

    <%-- Feedback Label--%>

    <asp:Label ID="lblFeedback" runat="server" />



</asp:Content>
