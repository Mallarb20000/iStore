<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaymentManagementLogin.aspx.cs" Inherits="_1Viewer" Theme="" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 552px">
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        &nbsp;<asp:Label ID="lblPaymentManagementSystem" runat="server" style="z-index: 1; left: 302px; top: 58px; position: absolute" Text="Payment Management Login"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 271px; top: 98px; position: absolute" Text="Username"></asp:Label>
        <p>
            <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 348px; top: 129px; position: absolute" TextMode="Password"></asp:TextBox>
            <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 348px; top: 97px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblPassword" runat="server" height="19px" style="z-index: 1; left: 271px; top: 130px; position: absolute" Text="Password" width="61px"></asp:Label>
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 557px; top: 169px; position: absolute"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 290px; top: 169px; position: absolute" Text="Login" OnClick="btnLogin_Click" />
        <asp:Button ID="btnCancel" runat="server" height="26px" OnClick="btnCancel_Click" style="z-index: 1; left: 395px; top: 169px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
