<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 515px">
    <form id="form1" runat="server">
        
        <div>
                    <asp:ListBox ID="lstStockList" runat="server" Height="431px" Width="606px" OnSelectedIndexChanged="lstStockList_SelectedIndexChanged"></asp:ListBox>

                    <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 189px; top: 478px; position: absolute; width: 90px; height: 41px;" Text="Edit" />

        </div>
        
        <p>
            <asp:Button ID="BtnAdd" runat="server" OnClick="BtnAdd_Click" style="z-index: 1; left: 55px; top: 482px; position: absolute; right: 1070px; width: 90px; height: 41px;" Text="Add" />
            <asp:Button ID="BtnDelete" runat="server" OnClick="BtnDelete_Click" style="z-index: 1; left: 336px; top: 477px; position: absolute; height: 42px; width: 123px" Text="Delete " />
        </p>
        <p>
            <asp:Label ID="LblError1" runat="server" style="z-index: 1; left: 18px; top: 551px; position: absolute" Text="[lblError]" Visible="False"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnApplyFilter" runat="server" style="z-index: 1; left: 44px; top: 701px; position: absolute" Text="Apply Filter" />
        </p>
        <p>
            <asp:Button ID="BtnClearFilter" runat="server" style="z-index: 1; left: 315px; top: 699px; position: absolute" Text="Clear Filter " />
        </p>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 7px; top: 625px; position: absolute" Text="Enter a Product Name"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 319px; top: 614px; position: absolute; height: 45px"></asp:TextBox>
    </form>
</body>
</html>
