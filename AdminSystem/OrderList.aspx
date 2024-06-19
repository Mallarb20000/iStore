<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderList" runat="server" style="z-index: 1; left: 11px; top: 15px; position: absolute; height: 303px; width: 420px"></asp:ListBox>
            <asp:Button ID="btnadd" runat="server" style="z-index: 1; left: 30px; top: 346px; position: absolute" Text="Add" OnClick="btnadd_Click" />
            <asp:Button ID="btnEdit" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 100px; top: 348px; position: absolute" Text="Edit" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 362px; top: 355px; position: absolute; height: 27px; width: 67px" Text="LblError"></asp:Label>
        </div>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 174px; top: 348px; position: absolute" Text="Delete" />
        <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 445px; top: 170px; position: absolute; width: 111px; bottom: 196px" Text="Enter an Order ID"></asp:Label>
        <asp:Button ID="BtnApply" runat="server" OnClick="BtnApply_Click" style="z-index: 1; left: 444px; top: 230px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="BtnClearFilter" runat="server" OnClick="BtnClearFilter_Click" style="z-index: 1; left: 566px; top: 228px; position: absolute" Text="Clear Filter" />
        <asp:TextBox ID="txtorderid" runat="server" style="z-index: 1; left: 571px; top: 168px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
