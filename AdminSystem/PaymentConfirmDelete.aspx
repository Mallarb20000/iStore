<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaymentConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p style="height: 96px">
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 71px; top: 74px; position: absolute" Text="Yes" />
            <asp:Label ID="lblDeleteConfirmation" runat="server" style="z-index: 1; left: 47px; top: 38px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
            <asp:Button ID="btnNo" runat="server" height="26px" OnClick="btnNo_Click" style="z-index: 1; left: 146px; top: 73px; position: absolute" Text="No" width="37px" />
        </p>
        <p style="height: 96px">
            &nbsp;</p>
    </form>
</body>
</html>
