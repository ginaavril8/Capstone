<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ControlPanel.aspx.cs" Inherits="Capstone.Backend.ControlPanel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div>

        <h2>Control Panel</h2>

        <table>
            <tr>
                <td><a href="WingManager.aspx" runat="server">Add</a></td>
            </tr>
         
            <tr>
                <td><a href="WingSearch.aspx" runat="server">Search</a></td>
            </tr>

            <tr>
                <td><asp:Button ID="btnLogout" runat="server" Text="Log Out" OnClick="btnLogout_Click" /></td>
            </tr>

        </table>

    </div>
</asp:Content>
