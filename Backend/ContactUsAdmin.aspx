﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ContactUsAdmin.aspx.cs" Inherits="Capstone.Backend.ContactUsAdmin" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <p>Customer Feedback</p>

    <p style="color:#FF6900;">
    <!-------------------------------- Name Search -------------------------------------->
    Name: <asp:TextBox ID="txtCustomerName" runat="server" Columns="30" />
    <br />
    <br />
      
    <!-------------------------------- Email Search -------------------------------------->
    Email: <asp:TextBox ID="txtCustomerEmail" runat="server" Columns="30" />
    </p>

    <br />
    <asp:Button ID="btnFeedback" runat="server"  BackColor="#FF6900" ForeColor="Black" Text="Display" OnClick="btnFeedback_Click" />

    <br />
    <br />

    <!-------------------------------- Search Results ----------------------------------->
    <asp:DataGrid ID="dgResults" runat="server" AutoGenerateColumns="false">

        <Columns>

            <asp:BoundColumn DataField="contactName" HeaderText="Name" /> 
             
            <asp:BoundColumn DataField="contactEmail" HeaderText="Description" />   
              
            <asp:HyperLinkColumn Text="View" DataNavigateUrlFormatString="~/Backend/ContactUsManager.aspx?ContactID={0}" DataNavigateUrlField="contactID" /> 

        </Columns>

    </asp:DataGrid>

</asp:Content>
