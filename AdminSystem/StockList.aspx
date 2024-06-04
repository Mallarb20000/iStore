<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
                    <asp:ListBox ID="lstStockList" runat="server" Height="431px" Width="435px" OnSelectedIndexChanged="lstStockList_SelectedIndexChanged"></asp:ListBox>

                    <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 83px; top: 462px; position: absolute; width: 42px" Text="Edit" />

        </div>
        
        <p>
            <asp:Button ID="BtnAdd" runat="server" OnClick="BtnAdd_Click" style="z-index: 1; left: 21px; top: 462px; position: absolute; right: 1254px;" Text="Add" height="26px" width="42px" />
        </p>
        <p>
            <asp:Label ID="LblError1" runat="server" style="z-index: 1; left: 24px; top: 500px; position: absolute" Text="[lblError]"></asp:Label>
        </p>
    </form>
</body>
</html>
