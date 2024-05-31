<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaymentDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 54px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblPaymentDetailsManagement0" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Large" style="z-index: 1; left: 79px; top: 50px; position: absolute" Text="Payment Details Management"></asp:Label>
        <asp:Label ID="LBLPaymentMethod" runat="server" height="22px" style="z-index: 1; left: 51px; top: 503px; position: absolute" Text="Payment Method"></asp:Label>
        <asp:TextBox ID="TXTPaymentAmount" runat="server" height="25px" style="z-index: 1; left: 207px; top: 379px; position: absolute"></asp:TextBox>
        <asp:Label ID="LBLOrderID" runat="server" style="z-index: 1; left: 51px; top: 107px; position: absolute; right: 1152px" Text="Order ID"></asp:Label>
        <asp:Label ID="LBLTransactionStatus" runat="server" height="22px" style="z-index: 1; left: 51px; top: 423px; position: absolute; right: 1098px;" Text="Transaction Status"></asp:Label>
        <asp:Label ID="LBLTransactionId" runat="server" height="22px" style="z-index: 1; left: 51px; top: 146px; position: absolute" Text="TransactionID"></asp:Label>
        <asp:Label ID="LBLEmail" runat="server" height="22px" style="z-index: 1; left: 51px; top: 179px; position: absolute; right: 1176px;" Text="Email"></asp:Label>
        <asp:Label ID="LBLPostCode" runat="server" height="22px" style="z-index: 1; left: 51px; top: 348px; position: absolute; bottom: 306px" Text="Post Code"></asp:Label>
        <asp:TextBox ID="TXTLastName" runat="server" height="25px" style="z-index: 1; left: 207px; top: 243px; position: absolute"></asp:TextBox>
        <asp:Label ID="LBLFirstname" runat="server" height="22px" style="z-index: 1; left: 51px; top: 213px; position: absolute" Text="First Name"></asp:Label>
        <asp:Label ID="LBLLastName" runat="server" height="22px" style="z-index: 1; left: 51px; top: 249px; position: absolute" Text="Last Name"></asp:Label>
        <asp:Label ID="LBLPhoneNumber" runat="server" height="22px" style="z-index: 1; left: 51px; top: 280px; position: absolute" Text="Phone Number"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 294px; top: 553px; position: absolute"></asp:Label>
        <asp:Label ID="LBLAddress" runat="server" height="22px" style="z-index: 1; left: 51px; top: 312px; position: absolute; right: 1158px;" Text="Address"></asp:Label>
        <asp:Button ID="BtnDelete" runat="server" style="z-index: 1; left: 195px; top: 547px; position: absolute" Text="Delete" Height="33px" Width="53px" />
        <asp:Label ID="LBLPaymentAmount" runat="server" height="22px" style="z-index: 1; left: 51px; top: 384px; position: absolute" Text="Payment Amount"></asp:Label>
        <asp:TextBox ID="TXTAddress" runat="server" height="25px" style="z-index: 1; left: 207px; top: 306px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TXTPaymentDate" runat="server" height="25px" style="z-index: 1; left: 207px; top: 458px; position: absolute"></asp:TextBox>
        <br />
        <asp:Label ID="LBLPaymentDate" runat="server" height="22px" style="z-index: 1; left: 51px; top: 464px; position: absolute" Text="Payment Date"></asp:Label>
        <asp:TextBox ID="TXTOrderID" runat="server" height="25px" style="z-index: 1; left: 207px; top: 100px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TXTTranscationID" runat="server" style="z-index: 1; left: 207px; top: 139px; position: absolute; height: 25px;"></asp:TextBox>
        <asp:TextBox ID="TXTEmail" runat="server" Height="25px" Style="z-index: 1; left: 207px; top: 173px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TXTFirstName" runat="server" height="25px" style="z-index: 1; left: 207px; top: 207px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TXTPhoneNumber" runat="server" height="25px" style="z-index: 1; left: 207px; top: 274px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TXTPostCode" runat="server" height="25px" style="z-index: 1; left: 207px; top: 343px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TXTTransactionStutas" runat="server" height="25px" style="z-index: 1; left: 207px; top: 418px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TXTPaymentMethod" runat="server" height="25px" style="z-index: 1; left: 207px; top: 496px; position: absolute"></asp:TextBox>
        <p>
            <asp:Button ID="BtnEdit" runat="server" style="z-index: 1; left: 124px; top: 547px; position: absolute; right: 1099px;" Text="Edit" Height="33px" Width="38px" />
        </p>
        <asp:Button ID="BtnAdd" runat="server" style="z-index: 1; left: 57px; top: 548px; position: absolute; right: 1165px; width: 38px;" Text="Add" Height="33px" OnClick="BtnAdd_Click" Width="38px" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 577px; top: 106px; position: absolute; right: 566px" Text="Enter a Transaction"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 714px; top: 105px; position: absolute"></asp:TextBox>
        <asp:Button ID="BtnApplyFilter" runat="server" style="z-index: 1; left: 583px; top: 156px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="BtnClearFilter" runat="server" style="z-index: 1; left: 733px; top: 155px; position: absolute" Text="Clear Filter" />
        <asp:Button ID="BtnBackToMenu" runat="server" style="z-index: 1; left: 644px; top: 314px; position: absolute" Text="Back To Menu" />
    </form>
</body>
</html>
