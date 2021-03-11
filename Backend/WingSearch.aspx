<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WingSearch.aspx.cs" Inherits="Capstone.Backend.WingSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p style="color:#FF6900">Wing Search</p> 

    <%------------------------------ Return to Control Panel ---------------------------%>
    <a href="~/Backend/ControlPanel.aspx" runat="server">Return to Control Panel</a>
    <br /> 
    <br />

 
    
    <%------------------------------ Wing Search Text Boxes ---------------------------%>
    <p style="color:#FF6900">

        Wing Name: <asp:TextBox ID="txtWingName" runat="server" Columns="30" /><br />
         
        Description: <asp:TextBox ID="txtWingDesc" runat="server" Columns="30" /><br />

    </p>
    <br />

    <%------------------------- Search button / Display DB or speciific search results ----------------------%>
    <asp:Button ID="btnSearch" runat="server" BackColor="#FF6900" ForeColor="Black" Text="Search" OnClick="btnSearch_Click" />

    <br />
    <br />


     <%------------------------------------------ Data grid -----------------------------------------------%>
    <asp:DataGrid ID="dgResults" runat="server" AutoGenerateColumns="false">

        <Columns>

             <asp:BoundColumn DataField="WingName" HeaderText="Name" /> 

             <asp:BoundColumn DataField="WingDesc" HeaderText="Description" /> 

             <asp:HyperLinkColumn Text="Edit" DataNavigateUrlFormatString="~/Backend/WingManager.aspx?EwingID={0}" DataNavigateUrlField="wingID" />

        </Columns>

    </asp:DataGrid>

</asp:Content>

