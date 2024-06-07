<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderViewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 151px; top: 220px; position: absolute" Text="Yes" />
            <asp:Button ID="BtnNo" runat="server" OnClick="BtnNo_Click" style="z-index: 1; left: 314px; top: 220px; position: absolute" Text="No" />
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 117px; top: 165px; position: absolute; width: 293px" Text="Are you sure you want to delete this record?"></asp:Label>
    </form>
</body>
</html>
