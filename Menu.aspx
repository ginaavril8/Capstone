<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Capstone.Menu" %>
    



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <%--------------------------- Style sheet link -------------------------------%>
     <link rel="stylesheet" runat="server" media="screen" href="~/css/Menu.css" />




    <%------------------------------------ Image --------------------------------%>
    <img src="Images/menupage.jpg" alt="" style="max-width:100%; height:auto;" />



    <%-------------------------------- Menu Header ------------------------------%>
    <p style="text-align:center; font-size: 56px; color:#FF6900; font-family:Sigmar One;">Menu</p>


    <!--    <p>

        Wing Name: <asp:TextBox ID="txtWingName" runat="server" Columns="30" />
        &nbsp; &nbsp; &nbsp; &nbsp;
        Description: <asp:TextBox ID="txtWingDesc" runat="server" Columns="30" />
    </p>
    -->

    
<table>

    <%-------------------------------- Menu Grid ------------------------------%>
    <asp:DataGrid ID="dgResults" runat="server" AutoGenerateColumns="false" CssClass="DataGrid">
 
        <Columns>

         
             <asp:BoundColumn DataField="WingName" HeaderText="Name" /> 
          
             <asp:BoundColumn DataField="WingDesc" HeaderText="Description" /> 

       </Columns>
 
    </asp:DataGrid>

</table>

 

    <%--------------------------- Display Menu  ----------------------------------%>
    <asp:Button ID="btnMenu" runat="server" class="MenuButton"  Text="Load Menu" OnClick="btnMenu_Click" />




    <%--------------------------- Feedback Message -------------------------------%>
    <asp:Label ID="lblFeedback" runat="server" Text="" style="text-align:center;" />





</asp:Content>
