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
        body {
            font-family: Arial, sans-serif;
            background-color: #2e004f;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }
        .container {
            background: rgba(255, 255, 255, 0.1);
            box-shadow: 0 4px 30px rgba(0, 0, 0, 0.1);
            backdrop-filter: blur(10px);
            -webkit-backdrop-filter: blur(10px);
            border-radius: 10px;
            border: 1px solid rgba(255, 255, 255, 0.2);
            padding: 20px;
            width: 350px;
            text-align: center;
            position: relative;
        }
        h2 {
            color: #ffffff;
            margin-bottom: 20px;
        }
        .input-label {
            color: #ffffff;
            display: block;
            margin: 10px 0 5px;
        }
        .input-field {
    width: 100%;
    padding: 10px;
    margin-bottom: 10px;
    border: none;
    border-radius: 5px;
    outline: none;
    background: rgba(255, 255, 255, 0.2);
    color: #ffffff;
    box-sizing: border-box;
}
        .button {
            width: 100%;
            padding: 10px;
            margin-bottom: 10px;
            border: none;
            border-radius: 5px;
            background: rgba(255, 255, 255, 0.2);
            color: #ffffff;
            cursor: pointer;
            transition: background 0.3s;
        }
        .button:hover {
            background: rgba(255, 255, 255, 0.3);
        }
        .message {
            color: red;
        }
        .header {
            position: absolute;
            top: 10px;
            right: 10px;
            text-align: right;
            color: #ffffff;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <asp:Label ID="lblWelcome" runat="server" Text=""></asp:Label>
            <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" CssClass="button" />
        </div>
        <div class="container">
            <h2>Manage Supplier</h2>
            <asp:Label ID="lblSupplierName" runat="server" CssClass="input-label" Text="Supplier Name:"></asp:Label>
            <asp:TextBox ID="txtSupplierName" runat="server" CssClass="input-field"></asp:TextBox>
            <asp:Label ID="lblContactName" runat="server" CssClass="input-label" Text="Contact Name:"></asp:Label>
            <asp:TextBox ID="txtContactName" runat="server" CssClass="input-field"></asp:TextBox>
            <asp:Label ID="lblContactEmail" runat="server" CssClass="input-label" Text="Contact Email:"></asp:Label>
            <asp:TextBox ID="txtContactEmail" runat="server" CssClass="input-field" ReadOnly="true"></asp:TextBox>
            <asp:Label ID="lblPassword" runat="server" CssClass="input-label" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" CssClass="input-field" TextMode="Password"></asp:TextBox>
            <asp:Label ID="lblIsActive" runat="server" CssClass="input-label" Text="Is Active:"></asp:Label>
            <asp:CheckBox ID="chkIsActive" runat="server" CssClass="input-field" />
            <asp:Label ID="lblJoinDate" runat="server" CssClass="input-label" Text="Join Date:"></asp:Label>
            <asp:TextBox ID="txtJoinDate" runat="server" CssClass="input-field"></asp:TextBox>
            <asp:Label ID="lblRating" runat="server" CssClass="input-label" Text="Rating:"></asp:Label>
            <asp:TextBox ID="txtRating" runat="server" CssClass="input-field"></asp:TextBox>
            <asp:Button ID="btnUpdate" runat="server" CssClass="button" Text="Update" OnClick="btnUpdate_Click" />
            <asp:Button ID="btnDelete" runat="server" CssClass="button" Text="Delete Account" OnClientClick="return confirmDelete();" OnClick="btnDelete_Click" />
            <asp:Label ID="lblMessage" runat="server" CssClass="message"></asp:Label>
        </div>
    </form>
</body>
</html>
