﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginSupplier.aspx.cs" Inherits="LoginSupplier" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Supplier Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Supplier Login</h2>
            <asp:Label ID="lblContactEmail" runat="server" Text="Contact Email:"></asp:Label>
            <asp:TextBox ID="txtContactEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            <br />
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
