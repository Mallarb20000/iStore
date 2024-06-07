<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderList" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 303px; width: 420px"></asp:ListBox>
            <asp:Button ID="btnadd" runat="server" style="z-index: 1; left: 30px; top: 346px; position: absolute" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 100px; top: 348px; position: absolute" Text="Edit" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 188px; top: 350px; position: absolute; height: 27px; width: 67px" Text="LblError"></asp:Label>
        </div>
    </form>
</body>
</html>
