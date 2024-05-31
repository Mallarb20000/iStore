<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaymentList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="BtnDelete" runat="server" style="z-index: 1; left: 191px; top: 413px; position: absolute" Text="Delete" />
        <asp:Button ID="BtnFilter" runat="server" style="z-index: 1; left: 277px; top: 409px; position: absolute" Text="Filter" />
        <asp:ListBox ID="ListBox1" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 359px; width: 388px"></asp:ListBox>
        <asp:Button ID="BtnAdd" runat="server" style="z-index: 1; left: 24px; top: 417px; position: absolute" Text="Add" />
        <asp:Button ID="BtnEdit" runat="server" style="z-index: 1; left: 114px; top: 416px; position: absolute" Text="Edit" />
    </form>
</body>
</html>
