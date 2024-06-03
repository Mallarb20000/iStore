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
        <asp:TextBox ID="TXTPaymentAmount" runat="server" height="25px" style="z-index: 1; left: 207px; top: 316px; position: absolute"></asp:TextBox>
        <asp:Label ID="LBLTransactionStatus" runat="server" height="22px" style="z-index: 1; left: 51px; top: 369px; position: absolute; width: 120px;" Text="Transaction Status"></asp:Label>
        <asp:Label ID="lblPaymentID" runat="server" height="22px" style="z-index: 1; left: 51px; top: 146px; position: absolute" Text="PaymentID"></asp:Label>
        <asp:Label ID="LBLEmail" runat="server" height="22px" style="z-index: 1; left: 51px; top: 189px; position: absolute; " Text="Email" width="40"></asp:Label>
        <asp:Label ID="LBLPostCode" runat="server" height="22px" style="z-index: 1; left: 51px; top: 276px; position: absolute; bottom: 378px" Text="Post Code"></asp:Label>
        <asp:Label ID="LBLName" runat="server" height="22px" style="z-index: 1; left: 51px; top: 232px; position: absolute" Text="Name"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 294px; top: 553px; position: absolute"></asp:Label>
        <asp:Button ID="BtnDelete" runat="server" style="z-index: 1; left: 223px; top: 477px; position: absolute; width: 50px;" Text="Delete" Height="33px" />
        <asp:Label ID="LBLPaymentAmount" runat="server" height="22px" style="z-index: 1; left: 51px; top: 322px; position: absolute" Text="Payment Amount"></asp:Label>
        <asp:TextBox ID="TXTPaymentDate" runat="server" height="25px" style="z-index: 1; left: 207px; top: 409px; position: absolute"></asp:TextBox>
        <br />
        <asp:Label ID="LBLPaymentDate" runat="server" height="22px" style="z-index: 1; left: 51px; top: 415px; position: absolute" Text="Payment Date"></asp:Label>
        <asp:TextBox ID="txtPaymentID" runat="server" style="z-index: 1; left: 207px; top: 140px; position: absolute; height: 25px;"></asp:TextBox>
        <asp:TextBox ID="TXTEmail" runat="server" Height="25px" Style="z-index: 1; left: 207px; top: 183px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TXTName" runat="server" height="25px" style="z-index: 1; left: 207px; top: 226px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TXTPostCode" runat="server" height="25px" style="z-index: 1; left: 207px; top: 270px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TXTTransactionStutas" runat="server" height="25px" style="z-index: 1; left: 207px; top: 363px; position: absolute"></asp:TextBox>
        <p>
            <asp:Button ID="BtnEdit" runat="server" style="z-index: 1; left: 150px; top: 478px; position: absolute; right: 1361px;" Text="Edit" Height="33px" Width="38px" />
        </p>
        <asp:Button ID="BtnAdd" runat="server" style="z-index: 1; left: 72px; top: 479px; position: absolute; right: 1439px; width: 38px;" Text="Add" Height="33px" OnClick="BtnAdd_Click" Width="38px" />
        <asp:Button ID="BtnFind" runat="server" OnClick="BtnFind_Click" style="z-index: 1; left: 310px; top: 479px; position: absolute; height: 33px; width: 38px;" Text="Find" />
    </form>
</body>
</html>
