<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaymentList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 528px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="BtnDelete" runat="server" style="z-index: 1; left: 165px; top: 417px; position: absolute" Text="Delete" />
        <asp:ListBox ID="PaymentListBox" runat="server" style="z-index: 1; left: 102px; top: 44px; position: absolute; height: 359px; width: 388px"></asp:ListBox>
        <asp:Button ID="BtnAdd" runat="server" style="z-index: 1; left: 32px; top: 417px; position: absolute" Text="Add" />
        <asp:Button ID="BtnEdit" runat="server" style="z-index: 1; left: 97px; top: 417px; position: absolute" Text="Edit" />
        <p>
            <asp:Button ID="BtnApplyFilter" runat="server" style="z-index: 1; left: 583px; top: 156px; position: absolute" Text="Apply Filter" />
            <asp:Button ID="BtnClearFilter" runat="server" style="z-index: 1; left: 733px; top: 155px; position: absolute" Text="Clear Filter" />
            <asp:Button ID="BtnBackToMenu" runat="server" style="z-index: 1; left: 648px; top: 225px; position: absolute" Text="Back To Menu" />
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 577px; top: 106px; position: absolute; right: 849px" Text="Enter a Payment ID"></asp:Label>
            <asp:TextBox ID="txtPaymentID" runat="server" style="z-index: 1; left: 714px; top: 105px; position: absolute"></asp:TextBox>
        </p>
    </form>
</body>
</html>
