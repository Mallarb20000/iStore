﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 515px">
    <form id="form1" runat="server">
        
        <div style="height: 715px; width: 472px;">
                    <asp:ListBox ID="lstStockList" runat="server" Height="431px" Width="413px" OnSelectedIndexChanged="lstStockList_SelectedIndexChanged"></asp:ListBox>

                    <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 152px; top: 477px; position: absolute; width: 90px; height: 43px;" Text="Edit" />

            <asp:Button ID="BtnClearFilter" runat="server" style="z-index: 1; top: 652px; position: absolute; right: 1305px; height: 28px; width: 93px; margin-top: 0px;" Text="Clear Filter " OnClick="BtnClearFilter_Click" />

        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 17px; top: 610px; position: absolute" Text="Enter a Product Name"></asp:Label>

        </div>
        
        <p>
            <asp:Button ID="BtnAdd" runat="server" OnClick="BtnAdd_Click" style="z-index: 1; left: 40px; top: 478px; position: absolute; right: 1032px; width: 90px; height: 41px;" Text="Add" />
            <asp:Button ID="BtnDelete" runat="server" OnClick="BtnDelete_Click" style="z-index: 1; left: 258px; top: 479px; position: absolute; height: 42px; width: 100px" Text="Delete " />
        </p>
        <p>
            <asp:Label ID="LblError1" runat="server" style="z-index: 1; left: 18px; top: 551px; position: absolute" Text="[lblError]" Visible="False"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnApplyFilter" runat="server" style="z-index: 1; left: 20px; top: 651px; position: absolute; height: 30px;" Text="Apply Filter" OnClick="btnApplyFilter_Click1" />
        </p>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 163px; top: 592px; position: absolute; height: 37px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 35px; top: 699px; position: absolute; height: 24px" Text="Return to Main Menu" />
    </form>
</body>
</html>
