<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaymentViewer.aspx.cs" Inherits="_1Viewer" Theme="" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 552px">
    <form id="form1" runat="server">
        <p style="height: 43px">
            <asp:HyperLink ID="hlPayPal" runat="server" BorderStyle="Solid" ForeColor="Blue" NavigateUrl="https://www.paypal.com/signin" style="z-index: 1; left: 929px; top: 347px; position: absolute">PayPal</asp:HyperLink>
            <asp:HyperLink ID="hlApplePay" runat="server" BorderStyle="Solid" ForeColor="#000066" NavigateUrl="https://www.apple.com/uk/apple-pay/" style="z-index: 1; left: 729px; top: 351px; position: absolute">Apple Pay</asp:HyperLink>
            <asp:HyperLink ID="hlCard" runat="server" BorderStyle="Solid" ForeColor="#0066FF" NavigateUrl="https://pay.sumup.com/b2c/QTDTAEYV" style="z-index: 1; left: 848px; top: 349px; position: absolute; width: 42px; height: 22px">Card</asp:HyperLink>
        </p>
        <div style="margin-top: 0px; height: 38px;">
            <asp:Label ID="lblCheckOut" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Double" ForeColor="#0066FF" style="z-index: 1; left: 478px; top: 83px; position: absolute" Text="CheckOut"></asp:Label>
            <asp:Label ID="lblFind" runat="server" style="z-index: 1; left: 727px; top: 84px; position: absolute" Text="Search"></asp:Label>
            <asp:TextBox ID="txtFindBox" runat="server" style="z-index: 1; left: 789px; top: 81px; position: absolute"></asp:TextBox>
        </div>
        <p style="height: 377px">
            <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 24px; top: 167px; position: absolute; right: 1439px" Text="Email"></asp:Label>
            <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 21px; top: 221px; position: absolute; right: 1345px; bottom: 414px" Text="First Name"></asp:Label>
            <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 23px; top: 251px; position: absolute" Text="Address"></asp:Label>
            <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 19px; top: 318px; position: absolute" Text="Phone Number"></asp:Label>
            <asp:CheckBox ID="cxSameForBillingInformation" runat="server" style="z-index: 1; left: 103px; top: 368px; position: absolute" Text="Same For Billing Information" />
            <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 22px; top: 283px; position: absolute" Text="PostCode"></asp:Label>
            <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 302px; top: 221px; position: absolute" Text="Last Name"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 68px; top: 165px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 104px; top: 219px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 382px; top: 219px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 104px; top: 249px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 103px; top: 280px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtPhoneNumber" runat="server" style="z-index: 1; left: 125px; top: 316px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblContactInformation" runat="server" ForeColor="#0066FF" style="z-index: 1; left: 23px; top: 135px; position: absolute" Text="Contact Information"></asp:Label>
            <asp:Label ID="lblShipmentInformation" runat="server" ForeColor="#0066FF" style="z-index: 1; left: 21px; top: 190px; position: absolute" Text="Shipment Information"></asp:Label>
            <asp:Label ID="lblOrderSummary" runat="server" style="z-index: 1; left: 726px; top: 136px; position: absolute" Text="Order Summary"></asp:Label>
            <asp:Label ID="lblItem" runat="server" style="z-index: 1; left: 789px; top: 165px; position: absolute; width: 92px; right: 553px;" Text="MacBook Pro"></asp:Label>
            <asp:Image ID="Image1" runat="server" style="z-index: 1; left: 731px; top: 161px; position: absolute; height: 29px; width: 44px;" ImageUrl="~/New folder/mac.jpeg" />
            <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 956px; top: 165px; position: absolute" Text="£999"></asp:Label>
            <asp:Label ID="lblShippingFee" runat="server" style="z-index: 1; left: 738px; top: 205px; position: absolute" Text="Shipping Fee"></asp:Label>
            <asp:Label ID="lblShip" runat="server" style="z-index: 1; left: 956px; top: 205px; position: absolute" Text="£0"></asp:Label>
            <asp:Label ID="lblTotal" runat="server" style="z-index: 1; left: 742px; top: 244px; position: absolute" Text="Total"></asp:Label>
            <asp:Label ID="lblTotalFee" runat="server" style="z-index: 1; left: 956px; top: 240px; position: absolute" Text="£999"></asp:Label>
            <asp:Button ID="btnAddItems" runat="server" ForeColor="#0066FF" style="z-index: 1; left: 725px; top: 277px; position: absolute; right: 499px; height: 26px" Text="Add Items" />
            <asp:Button ID="btnRemove" runat="server" ForeColor="#0066FF" style="z-index: 1; left: 729px; top: 314px; position: absolute; width: 291px; height: 28px" Text="Remove" />
        </p>
        <p>
            &nbsp;</p>
        &nbsp;<p>
            &nbsp;</p>
    </form>
</body>
</html>
