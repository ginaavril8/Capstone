<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Capstone.Menu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>MENU</h1>


        <p>

        Wing Name: <asp:TextBox ID="txtWingName" runat="server" Columns="30" />
        &nbsp; &nbsp; &nbsp; &nbsp;
        Description: <asp:TextBox ID="txtWingDesc" runat="server" Columns="30" />
    </p>


    
<table>


    <asp:DataGrid ID="dgResults" runat="server" AutoGenerateColumns="false">

        <Columns>
             <asp:BoundColumn DataField="WingName" HeaderText="Name" /> 
               
             <asp:BoundColumn DataField="WingDesc" HeaderText="Description" /> 


                 <%--  Review --%>
             <asp:HyperLinkColumn Text="R" DataNavigateUrlFormatString="~/Review.aspx?EwingID={0}" DataNavigateUrlField="wingID" />


                 <%--  Wish List --%>
              <asp:HyperLinkColumn Text="W" DataNavigateUrlFormatString="~/WishList.aspx?EwingID={0}" DataNavigateUrlField="wingID" />

        </Columns>

    </asp:DataGrid>


     
        
</table>


    <%-- Review up / Wish list --%>  
    <!--<asp:Button ID="reviewFlavor" runat="server" OnClick="reviewFlavor_Click" Text="R" />
    <asp:Button ID="wishList" runat="server" OnClick="wishList_Click" Text="W" /> 
    <br />
    <br /> -->


    <%-- Display Menu  --%>
    <asp:Button ID="btnMenu" runat="server" Text="Load Menu" OnClick="btnMenu_Click" />

    <asp:Label ID="lblFeedback" runat="server" Text="" style="text-align:center;" />


</asp:Content>
