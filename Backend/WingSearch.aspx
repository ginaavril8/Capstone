﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WingSearch.aspx.cs" Inherits="Capstone.Backend.WingSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>Wing Search</p>

    <p>

        Wing Name: <asp:TextBox ID="txtWingName" runat="server" Columns="30" />
        &nbsp; &nbsp; &nbsp; &nbsp;
        Description: <asp:TextBox ID="txtWingDesc" runat="server" Columns="30" />
    </p>

    <br />

    <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />

    <br />
    <br />

    <asp:DataGrid ID="dgResults" runat="server" AutoGenerateColumns="false">

        <Columns>
             <asp:BoundColumn DataField="WingName" HeaderText="Wing Name" />
             <asp:BoundColumn DataField="WingDesc" HeaderText="Description" /> 

             <asp:HyperLinkColumn Text="Edit" DataNavigateUrlFormatString="~/Backend/WingManager.aspx?EwingID={0}" DataNavigateUrlField="wingID" />
        </Columns>

    </asp:DataGrid>












</asp:Content>

