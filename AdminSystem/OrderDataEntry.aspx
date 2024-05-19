<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnsearch" runat="server" OnClick="btnsearch_Click" style="z-index: 1; left: 466px; top: 52px; position: absolute" Text="Search" />
            <asp:Button ID="Cart" runat="server" OnClick="Cart_Click" style="z-index: 1; left: 546px; top: 15px; position: absolute" Text="Cart" />
        </div>
        <asp:TextBox ID="Searchbox" runat="server" style="z-index: 1; left: 265px; top: 55px; position: absolute; width: 179px"></asp:TextBox>
        <p>
            <asp:Button ID="Login" runat="server" height="26px" OnClick="Login_Click" style="z-index: 1; left: 620px; top: 14px; position: absolute; width: 55px;" Text="Login" />
        </p>
        <p>
            <asp:Label ID="Item1" runat="server" style="z-index: 1; left: 229px; top: 127px; position: absolute; height: 104px; width: 106px" Text="Item1"></asp:Label>
        </p>
        <asp:Label ID="Item2" runat="server" style="z-index: 1; left: 397px; top: 131px; position: absolute; height: 104px; width: 106px" Text="Item2"></asp:Label>
        <asp:Label ID="Item3" runat="server" style="z-index: 1; left: 575px; top: 130px; position: absolute; height: 104px; width: 106px" Text="Item3"></asp:Label>
        <asp:Button ID="Add1" runat="server" OnClick="Button3_Click" style="z-index: 1; left: 221px; top: 255px; position: absolute" Text="Add to Cart" />
        <asp:Button ID="Add2" runat="server" height="26px" OnClick="Add2_Click" style="z-index: 1; left: 397px; top: 257px; position: absolute" Text="Add to Cart" width="100px" />
        <asp:Button ID="Add3" runat="server" height="26px" OnClick="Add3_Click" style="z-index: 1; left: 568px; top: 256px; position: absolute; right: 617px" Text="Add to Cart" width="100px" />
    </form>
</body>
</html>
