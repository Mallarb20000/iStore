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
        <asp:Button ID="BtnDelete" runat="server" style="z-index: 1; left: 165px; top: 417px; position: absolute" Text="Delete" OnClick="BtnDelete_Click" />
        <asp:ListBox ID="PaymentListBox" runat="server" style="z-index: 1; left: 27px; top: 34px; position: absolute; height: 359px; width: 388px"></asp:ListBox>
        <asp:Button ID="BtnAdd" runat="server" style="z-index: 1; left: 32px; top: 417px; position: absolute" Text="Add" OnClick="BtnAdd_Click" />
        <asp:Button ID="BtnEdit" runat="server" style="z-index: 1; left: 97px; top: 417px; position: absolute; height: 26px;" Text="Edit" OnClick="BtnEdit_Click" />
        <p>
            <asp:Button ID="BtnApplyFilter" runat="server" style="z-index: 1; left: 583px; top: 156px; position: absolute" Text="Apply Filter" OnClick="BtnApplyFilter_Click" />
            <asp:Button ID="BtnClearFilter" runat="server" style="z-index: 1; left: 733px; top: 155px; position: absolute" Text="Clear Filter" OnClick="BtnClearFilter_Click" />
            <asp:Button ID="BtnBackToMenu" runat="server" style="z-index: 1; left: 648px; top: 225px; position: absolute" Text="Back To Menu" />
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 577px; top: 106px; position: absolute; right: 494px" Text="Enter a Payment ID"></asp:Label>
            <asp:TextBox ID="txtPaymentID" runat="server" style="z-index: 1; left: 714px; top: 105px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 275px; top: 419px; position: absolute"></asp:Label>
        </p>
    </form>
</body>
</html>
