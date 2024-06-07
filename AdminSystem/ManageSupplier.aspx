<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ManageSupplier.aspx.cs" Inherits="ManageSupplier" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Manage Supplier</title>
    <script type="text/javascript">
        function confirmDelete() {
            return confirm('Are you sure you want to delete your account? This action cannot be undone.');
        }
    </script>
    <style>
        .logout-button {
            position: absolute;
            top: 10px;
            right: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="logout-button">
                <asp:Label ID="lblWelcome" runat="server" Text=""></asp:Label>
                <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
            </div>
            <h2>Manage Supplier</h2>
            <asp:Label ID="lblSupplierName" runat="server" Text="Supplier Name:"></asp:Label>
            <asp:TextBox ID="txtSupplierName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblContactName" runat="server" Text="Contact Name:"></asp:Label>
            <asp:TextBox ID="txtContactName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblContactEmail" runat="server" Text="Contact Email:"></asp:Label>
            <asp:TextBox ID="txtContactEmail" runat="server" ReadOnly="true"></asp:TextBox>
            <br />
            <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Label ID="lblIsActive" runat="server" Text="Is Active:"></asp:Label>
            <asp:CheckBox ID="chkIsActive" runat="server" />
            <br />
            <asp:Label ID="lblJoinDate" runat="server" Text="Join Date:"></asp:Label>
            <asp:TextBox ID="txtJoinDate" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblRating" runat="server" Text="Rating:"></asp:Label>
            <asp:TextBox ID="txtRating" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete Account" OnClientClick="return confirmDelete();" OnClick="btnDelete_Click" />
            <br />
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
