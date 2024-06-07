<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDetailViewer.aspx.cs" Inherits="_1Viewer" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div id="txtLogIn" style="height: 628px; width: 1456px">
            <asp:Label ID="txtUserName" runat="server" style="z-index: 1; left: 368px; top: 176px; position: absolute" Text="User Name"></asp:Label>
            <asp:Label ID="txtPassword" runat="server" style="z-index: 1; left: 375px; top: 231px; position: absolute" Text="Password"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 500px; top: 173px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 495px; top: 232px; position: absolute"></asp:TextBox>
&nbsp;<asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 403px; top: 294px; position: absolute; height: 25px; width: 59px;" Text="Login" />
            <asp:Button ID="btnCancel" runat="server"  style="z-index: 1; left: 547px; top: 294px; position: absolute; height: 26px; width: 60px;" Text="Cancel" OnClick="btnCancel_Click" />
        </div>
        <asp:Label ID="txtLogIn" runat="server" style="z-index: 1; left: 384px; top: 109px; position: absolute; right: 879px" Text="Customer Management Log In System"></asp:Label>
    </form>
</body>
</html>

