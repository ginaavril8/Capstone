<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ControlPanel.aspx.cs" Inherits="Capstone.Backend.ControlPanel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div>

        <h2 style="color:#FF6900">Control Panel</h2>

        <table>
 
            
            <tr>
                <%-------------------------------------- Edit Wings Hyperlink ------------------------------------%>
                <td style="color:#FF6900"><a href="WingSearch.aspx" runat="server">Edit Wings<br /></a></td> 
     
            </tr>
      
         
            <tr>
                 <%-------------------------------------- Feedback Hyperlink ------------------------------------%>
                <td style="color:#FF6900"><a href="ContactUsAdmin.aspx" runat="server">Customer Feedback<br /></a></td>
            
            </tr>
           
            
            <tr>
                 <%-------------------------------------- Log off/end session ------------------------------------%>
                <td><asp:Button ID="btnLogout" runat="server" BackColor="#FF6900" ForeColor="Black" Text="Log Out" OnClick="btnLogout_Click" /></td>
            </tr>

        </table>

    </div>
</asp:Content>
