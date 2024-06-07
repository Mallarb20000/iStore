<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="BtnNo" runat="server" OnClick="BtnNo_Click" style="z-index: 1; left: 489px; top: 331px; position: absolute; width: 73px" Text="No" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 346px; top: 288px; position: absolute; width: 309px" Text="Are you sure you want to delete this record?"></asp:Label>
        <p>
            <asp:Button ID="BtnYes" runat="server" OnClick="BtnYes_Click" style="z-index: 1; left: 384px; top: 332px; position: absolute; height: 26px; width: 73px" Text="Yes" />
        </p>
    </form>
</body>
</html>
