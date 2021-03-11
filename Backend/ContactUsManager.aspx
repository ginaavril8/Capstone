<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ContactUsManager.aspx.cs" Inherits="Capstone.Backend.ContactUsManager" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
    <%------------------------------ Return to Control Panel ---------------------------%>
    <a href="~/Backend/ControlPanel.aspx" runat="server">Return to Control Panel</a><br />
    <a href="~/Backend/ContactUsAdmin.aspx" runat="server">Back to Comments</a><br />
 
     

        <%------------------------------ Wing Management Table ---------------------------%>
    <table style="color:#FF6900;">

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
        <td>Staff Notes: </td>
        <td><asp:Textbox ID="txtContactStatus" runat="server"  TextMode="MultiLine" Width="300px" Height="90px"  /></td>
    </tr>

        
    </table>

    <%-- Add note to a contact message --%>

    <asp:Button ID="btnUpdateContactMsg" runat="server" BackColor="#FF6900" ForeColor="Black" Text="Update" OnClick="btnUpdateContactMsg_Click" />

   <%-- Cancle Button --%>
            <br /> 
            <br />
            <br /> 
    <asp:Button ID="btnCancel" runat="server" BackColor="#FF6900" ForeColor="Black" Text="Cancel" OnClick="btnCancel_Click" />
            <br />
            <br />
            <br /> 


    <%-- Feedback Label--%>
    <asp:Label ID="lblFeedback" runat="server" />



</asp:Content>
