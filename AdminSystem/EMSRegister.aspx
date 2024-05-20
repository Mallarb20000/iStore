<%@ Page Language="C#" AutoEventWireup="true" CodeFile="5DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 140px;
            left: 78px;
            z-index: 1;
            right: 1053px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 148px">
            <br />
            Username<asp:TextBox ID="txtUsername" runat="server" style="margin-left: 67px" Width="234px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" CssClass="auto-style1" OnClick="Button1_Click" Text="Button" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
