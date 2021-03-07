<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WingManager.aspx.cs" Inherits="Capstone.Backend.WingManager" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>Wing Management</p>

    <%------------------------------ Return to Control Panel ---------------------------%>
    <a href="~/Backend/ControlPanel.aspx" runat="server">Return to Control Panel</a><br />
     



    
    <%------------------------------ Wing Management Table ---------------------------%>
    <table>

    <%-- Wing ID--%>
    <tr>
        <td>Wing ID</td>
        <td><asp:Label ID="lblWingID" runat="server"  /></td>
    </tr>

    <%-- Wing Name --%>
    <tr>
        <td>Wing Name</td>
        <td><asp:Textbox ID="txtWingName" runat="server" MaxLength="255" /></td>
    </tr>

    <%-- Wing Information --%>
    <tr>
        <td>Wing Flavor(s)</td>
        <td><asp:Textbox ID="txtWingFlavor" runat="server" MaxLength="50" /></td>
    </tr>

    <tr>
        <td>Wing Description</td>
        <td><asp:Textbox ID="txtWingDesc" runat="server" MaxLength="200" /></td>
    </tr>



    </table>

               <%-- Add Wing Button (to Database) --%>
            <br />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />

                <%-- Delete Button --%>
            <br />

            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />

               <%-- Update Button --%>
            <br />

            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />

               <%-- Cancle Button --%>
            <br />
 
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />

    <%-- Feedback Label--%>
    <br />
    <br />

    <asp:Label ID="lblFeedback" runat="server" />


 
</asp:Content>