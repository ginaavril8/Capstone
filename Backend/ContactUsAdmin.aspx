<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ContactUsAdmin.aspx.cs" Inherits="Capstone.Backend.ContactUsAdmin" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


        <p>Customer Feedback</p>

    <p>

        Name: <asp:TextBox ID="txtCustomerName" runat="server" Columns="30" />
        &nbsp; &nbsp; &nbsp; &nbsp;
        Email: <asp:TextBox ID="txtCustomerEmail" runat="server" Columns="30" />
    </p>

    <br />

    <asp:Button ID="btnFeedback" runat="server" Text="Display" OnClick="btnFeedback_Click" />

    <br />
    <br />

    <asp:DataGrid ID="dgResults" runat="server" AutoGenerateColumns="false">

        <Columns>
             <asp:BoundColumn DataField="contactName" HeaderText="Name" /> 
             <asp:BoundColumn DataField="contactEmail" HeaderText="Description" /> 

             <asp:HyperLinkColumn Text="View" DataNavigateUrlFormatString="~/Backend/ContactUsManager.aspx?ContactID={0}" DataNavigateUrlField="contactID" /> 
        </Columns>

    </asp:DataGrid>







</asp:Content>
