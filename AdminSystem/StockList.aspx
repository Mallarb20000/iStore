<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
                    <asp:ListBox ID="lstStockList" runat="server" Height="388px" Width="380px" OnSelectedIndexChanged="lstStockList_SelectedIndexChanged"></asp:ListBox>

        </div>
        
        <p>
            <asp:Button ID="BtnAdd" runat="server" OnClick="BtnAdd_Click" style="z-index: 1; left: 16px; top: 416px; position: absolute" Text="Add" />
        </p>
    </form>
</body>
</html>
