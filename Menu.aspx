﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Capstone.Menu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>MENU</h1>


    <!--    <p>

        Wing Name: <asp:TextBox ID="txtWingName" runat="server" Columns="30" />
        &nbsp; &nbsp; &nbsp; &nbsp;
        Description: <asp:TextBox ID="txtWingDesc" runat="server" Columns="30" />
    </p>
    -->




    
<table>


    <asp:DataGrid ID="dgResults" runat="server" AutoGenerateColumns="false">
 
        <Columns>

             <asp:BoundColumn DataField="WingName" HeaderText="Name" /> 
               
             <asp:BoundColumn DataField="WingDesc" HeaderText="Description" /> 

 
            
           

        </Columns>
 
    </asp:DataGrid>


     
        
</table>

 

    <%-- Display Menu  --%>
    <asp:Button ID="btnMenu" runat="server" Text="Load Menu" OnClick="btnMenu_Click" />

    <asp:Label ID="lblFeedback" runat="server" Text="" style="text-align:center;" />


</asp:Content>
