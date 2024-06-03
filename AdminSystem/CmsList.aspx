<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CmsList.aspx.cs" Inherits="_1_List" %>


<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomersList" runat="server" Height="540px" OnSelectedIndexChanged="lstCustomersList_SelectedIndexChanged" Width="708px"></asp:ListBox>
    </form>
</body>
</html>
