<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label8" runat="server" height="19px" style="z-index: 1; left: 89px; top: 349px; position: absolute" Text="Payment Method" width="111px"></asp:Label>
            <asp:Label ID="Label10" runat="server" height="19px" style="z-index: 1; left: 79px; top: 46px; position: absolute" Text="Order ID" width="111px"></asp:Label>
            <asp:Label ID="Label11" runat="server" height="19px" style="z-index: 1; left: 92px; top: 312px; position: absolute" Text="Payment Date" width="111px"></asp:Label>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 304px; top: 16px; position: absolute; width: 235px" Text="Order Details Management"></asp:Label>
        </div>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 79px; top: 75px; position: absolute; height: 19px; width: 111px" Text="Customer ID"></asp:Label>
        <asp:Label ID="Label3" runat="server" height="19px" style="z-index: 1; left: 78px; top: 144px; position: absolute; width: 111px" Text="City"></asp:Label>
        <asp:Label ID="Label4" runat="server" height="19px" style="z-index: 1; left: 79px; top: 188px; position: absolute; width: 111px" Text="Order Date"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 83px; top: 227px; position: absolute" Text="Transaction Status"></asp:Label>
        <asp:Label ID="Label6" runat="server" height="19px" style="z-index: 1; left: 85px; top: 114px; position: absolute; width: 111px" Text="Product ID"></asp:Label>
        <asp:Label ID="Label7" runat="server" height="19px" style="z-index: 1; left: 87px; top: 272px; position: absolute" Text="Payment Amount" width="111px"></asp:Label>
        <p>
            <asp:Label ID="Label9" runat="server" height="19px" style="z-index: 1; left: 87px; top: 387px; position: absolute" Text="Order Status" width="111px"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" height="22px" style="z-index: 1; left: 222px; top: 387px; position: absolute" width="128px"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" height="22px" style="z-index: 1; left: 222px; top: 274px; position: absolute" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtproductid" runat="server" height="22px" style="z-index: 1; left: 212px; top: 108px; position: absolute" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtcity" runat="server" height="22px" style="z-index: 1; left: 214px; top: 142px; position: absolute" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtcustomerid" runat="server" height="22px" style="z-index: 1; left: 209px; top: 77px; position: absolute" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtorderid" runat="server" style="z-index: 1; left: 204px; top: 44px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="TextBox7" runat="server" height="22px" style="z-index: 1; left: 223px; top: 309px; position: absolute" width="128px"></asp:TextBox>
            <asp:TextBox ID="TextBox8" runat="server" height="22px" style="z-index: 1; left: 221px; top: 340px; position: absolute" width="128px"></asp:TextBox>
            <asp:TextBox ID="TextBox9" runat="server" height="22px" style="z-index: 1; left: 219px; top: 225px; position: absolute" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtdate" runat="server" height="22px" style="z-index: 1; left: 211px; top: 177px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 488px; top: 323px; position: absolute" Text="OK" />
        <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 551px; top: 322px; position: absolute" Text="Cancel" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="z-index: 1; left: 553px; top: 90px; position: absolute" Text="Find" />
    </form>
</body>
</html>
