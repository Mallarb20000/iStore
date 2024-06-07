<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="50pt" style="z-index: 1; left: 279px; top: 40px; position: absolute" Text="ISTORE"></asp:Label>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 45px; top: 198px; position: absolute" Text="Employee Management System" />
        <p>
            <asp:Button ID="btnstock" runat="server" OnClick="btnstock_Click" style="z-index: 1; left: 407px; top: 201px; position: absolute; height: 21px; width: 275px" Text="Stock Managment System" />
            <asp:Button ID="BtnCms" runat="server" OnClick="BtnCms_Click" style="z-index: 1; left: 43px; top: 261px; position: absolute; height: 23px; width: 271px" Text="Customer Managment System" />
        </p>
    </form>
</body>
</html>
