<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WingManager.aspx.cs" Inherits="Capstone.Backend.WingManager" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p style="color:#FF6900">Wing Management</p>

    <%------------------------------ Return to Control Panel ---------------------------%>
    <a href="~/Backend/ControlPanel.aspx" runat="server">Return to Control Panel</a><br />
     



    
    <%------------------------------ Wing Management Table ---------------------------%>
    <table>

    <%-- Wing ID--%>
    <tr>
        <td style="color:#FF6900;">Wing ID</td>
        <td><asp:Label ID="lblWingID" runat="server"  /></td>
    </tr>

    <%-- Wing Name --%>
    <tr>
        <td style="color:#FF6900;">Wing Name</td>
        <td><asp:Textbox ID="txtWingName" runat="server" MaxLength="255" /></td>
    </tr>

    <%-- Wing Information --%>
    <tr>
        <td style="color:#FF6900;">Wing Flavor(s)</td>
        <td><asp:Textbox ID="txtWingFlavor" runat="server" MaxLength="50" /></td>
    </tr>

    <tr>
        <td style="color:#FF6900;">Wing Description</td>
        <td><asp:Textbox ID="txtWingDesc" runat="server" MaxLength="200" /></td>
    </tr>



    </table>

               <%-- Add Wing Button (to Database) --%>
            <br />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnAdd" runat="server" BackColor="#FF6900" ForeColor="Black" Text="Add" OnClick="btnAdd_Click" />

                <%-- Delete Button --%>
            <br />
            <br />
            <br /> 

            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" BackColor="#FF6900" ForeColor="Black" Text="Delete" OnClick="btnDelete_Click" />

               <%-- Update Button --%>
            <br />
            <br />
            <br /> 

            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnUpdate" runat="server"  BackColor="#FF6900" ForeColor="Black" Text="Update" OnClick="btnUpdate_Click" />

               <%-- Cancel Button --%>
            <br />
            <br />
            <br /> 
 
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" BackColor="#FF6900" ForeColor="Black" Text="Cancel" OnClick="btnCancel_Click" />

    <%-- Feedback Label--%>
    <br />
    <br />

    <asp:Label ID="lblFeedback" ForeColor="#FF6900" runat="server" />


 
</asp:Content>