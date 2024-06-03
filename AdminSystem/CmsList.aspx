<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CmsList.aspx.cs" Inherits="_1_List" %>


<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 551px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
        <div>
        </div>
        <asp:ListBox ID="lstCustomersList" runat="server" Height="435px" OnSelectedIndexChanged="lstCustomersList_SelectedIndexChanged" Width="587px"></asp:ListBox>
        <br />
        <asp:Button ID="BtnAdd" runat="server" OnClick="BtnAdd_Click" Text="Add" />
        <asp:Button ID="BtnEdit" runat="server" OnClick="BtnEdit_Click" Text="Edit" />
        <br />
        <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
    </form>
</body>
</html>
