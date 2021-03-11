<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Capstone.Menu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <img src="Images/menupage.jpg" alt="" style="max-width:100%; height:auto;" />
    <p style="text-align:center; font-size: 56px; color:#FF6900; font-family:Sigmar One;">Menu</p>


    <!--    <p>

        Wing Name: <asp:TextBox ID="txtWingName" runat="server" Columns="30" />
        &nbsp; &nbsp; &nbsp; &nbsp;
        Description: <asp:TextBox ID="txtWingDesc" runat="server" Columns="30" />
    </p>
    -->

    


<div>
<table>


    <asp:DataGrid ID="dgResults" runat="server" AutoGenerateColumns="false" GridLines="None">
 
        <Columns>

             <asp:BoundColumn DataField="WingName" ItemStyle-ForeColor="#FF6900" ItemStyle-Font-Size="20px"/> 
               
             <asp:BoundColumn DataField="WingDesc" ItemStyle-ForeColor="#FFE4C4" ItemStyle-Font-Size="18px"/> 

 
            
           

        </Columns>
 
    </asp:DataGrid>


     
        
</table>
    </div>

 

    <%-- Display Menu  --%>
    <asp:Button ID="btnMenu" runat="server" Text="Load Menu"  OnLoad="btnMenu_Click" />

    <asp:Label ID="lblFeedback" runat="server" Text="" style="text-align:center;" />


</asp:Content>
