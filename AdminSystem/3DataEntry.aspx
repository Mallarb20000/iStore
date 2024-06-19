<%@ Page Language="C#" AutoEventWireup="true" CodeFile="3DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblpass" runat="server" style="z-index: 1; left: 169px; top: 140px; position: absolute" Text="Password"></asp:Label>
            <asp:Label ID="lbluser" runat="server" style="z-index: 1; left: 169px; top: 90px; position: absolute" Text="Username"></asp:Label>
        </div>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 292px; top: 93px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 96px; top: 279px; position: absolute; height: 16px; margin-bottom: 0px" Text="Label"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 292px; top: 137px; position: absolute"></asp:TextBox>
        <asp:Button ID="btncancel" runat="server" style="z-index: 1; left: 390px; top: 206px; position: absolute" Text="Cancel" />
        <asp:Button ID="btnlogin" runat="server" OnClick="btnlogin_Click" style="z-index: 1; left: 253px; top: 211px; position: absolute" Text="Login" />
    </form>
</body>
</html>
