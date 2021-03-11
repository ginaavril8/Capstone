<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Capstone.Contact" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <img src="Images/contactpage.jpg" alt="" style="max-width:100%; height:auto;" />
    <p style="text-align:center; font-size: 56px; color:#FF6900; font-family:Sigmar One;">Contact Us</p>
    
    
<table>


    <%--------------------------------- First Name ------------------------------------%>
    <tr> 
        <td><asp:TextBox ID="txtContactName" runat="server" Text="Name" Width="400px" /></td>
    </tr>
             
                
    <%----------------------------------- Email --------------------------------------%>
    <tr> 
        <td><asp:TextBox ID="txtContactEmail" runat="server" Text="Email" Width="400px" /></td>
    </tr>

    <%----------------------------------- Comment --------------------------------------%>
    <tr> 
        <td><asp:TextBox ID="txtContactMessage" runat="server" TextMode="MultiLine" Width="400px" Height="200px" Text="Comment" /></td>
    </tr>
        

</table>

    <%----------------------------------- Submit comment --------------------------------------%>  
    <asp:Button ID="btnContact" BackColor="#FF6900" ForeColor="Black" runat="server" text="Contact" OnClick="btnContact_Click" />

    <%-------------------------------------- Feedback ----------------------------------------%>  
    <asp:Label ID="lblFeedback" runat="server" />

</asp:Content>
