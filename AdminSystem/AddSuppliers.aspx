<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddSuppliers.aspx.cs" Inherits="AddSuppliers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Supplier</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Add Supplier</h2>
            <asp:Label ID="lblSupplierName" runat="server" Text="Supplier Name:"></asp:Label>
            <asp:TextBox ID="txtSupplierName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblContactName" runat="server" Text="Contact Name:"></asp:Label>
            <asp:TextBox ID="txtContactName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblContactEmail" runat="server" Text="Contact Email:"></asp:Label>
            <asp:TextBox ID="txtContactEmail" runat="server"></asp:TextBox>
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
            <asp:Button ID="btnAddSupplier" runat="server" Text="Add Supplier" OnClick="btnAddSupplier_Click" />
            <br />
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
